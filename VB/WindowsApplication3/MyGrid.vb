Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraTab
Imports DevExpress.XtraGrid.Tab
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports DevExpress.Utils
Imports System.Collections

Namespace DXSample


	Public Class MyGridControl
		Inherits GridControl

		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("MyGridView")
		End Function
		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridViewInfoRegistrator())
		End Sub
	End Class

	Public Class MyGridViewInfoRegistrator
		Inherits GridInfoRegistrator

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyGridView(TryCast(grid, GridControl))
		End Function
	End Class

	Public Class MyGridView
		Inherits DevExpress.XtraGrid.Views.Grid.GridView

		Public Event DetailTabStyle As DetailTabStyleEventHandler

		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
			MyBase.New(grid)
		End Sub
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property

		Protected Overrides Sub PopulateTabMasterData(ByVal tabControl As DevExpress.XtraGrid.Tab.ViewTab, ByVal rowHandle As Integer)
			tabControl.HeaderLocation = DetailTabHeaderLocation
			Dim details() As GridDetailInfo = GetDetailInfo(rowHandle, False)
			If details Is Nothing Then
				Return
			End If
			Dim vIndex As Integer = GetVisibleDetailRelationIndex(rowHandle)
			For Each detail As GridDetailInfo In details
				If Not OptionsDetail.AllowExpandEmptyDetails AndAlso IsMasterRowEmptyEx(rowHandle, detail.RelationIndex) Then
					Continue For
				End If
				Dim detailRows As Integer = DataController.GetDetailList(rowHandle, detail.RelationIndex).Count
				Dim exp As Boolean = vIndex = detail.RelationIndex
				Dim e As New DetailTabStyleEventArgs(rowHandle, detail.RelationName, detail.RelationIndex, True)
				RaiseDetailTabStyle(e)
				If e.Enabled Then
					CreateEnableTabPage(exp, tabControl, detail)
				Else
					CreateDisableTabPage(exp, tabControl, detail)
				End If
			Next detail
		End Sub

		Friend Sub RaiseDetailTabStyle(ByVal e As DetailTabStyleEventArgs)
			RaiseEvent DetailTabStyle(Me, e)
		End Sub

		Private Sub CreateEnableTabPage(ByVal exp As Boolean, ByVal tabControl As DevExpress.XtraGrid.Tab.ViewTab, ByVal detail As GridDetailInfo)
			Dim page As New ViewTabPage(tabControl)
			page.Text = detail.Caption.Trim()
			page.Tag = detail.RelationIndex
			page.DetailInfo = detail
			AddTabPage(exp, tabControl, page)
		End Sub

		Private Sub CreateDisableTabPage(ByVal exp As Boolean, ByVal tabControl As DevExpress.XtraGrid.Tab.ViewTab, ByVal detail As GridDetailInfo)
			Dim page As New DisableViewTabPage(tabControl)
			page.Text = detail.Caption.Trim()
			page.Tag = detail.RelationIndex
			page.DetailInfo = detail
			AddTabPage(exp, tabControl, page)
		End Sub

		Private Shared Sub AddTabPage(ByVal exp As Boolean, ByVal tabControl As DevExpress.XtraGrid.Tab.ViewTab, ByVal page As ViewTabPage)
			tabControl.Pages.Add(page)
			If exp Then
				tabControl.SelectedPage = page
			End If
		End Sub

		Friend Function GetDetailInfo(ByVal rowHandle As Integer, ByVal shortInfo As Boolean) As GridDetailInfo()
			If Not AllowMasterDetail OrElse GridControl Is Nothing Then
				Return Nothing
			End If
			Dim levelNode As GridLevelNode = GetLevelNode()
			If GridControl.ShowOnlyPredefinedDetails AndAlso (levelNode Is Nothing OrElse Not levelNode.HasChildren) Then
				Return Nothing
			End If
			Dim details As New ArrayList()
			If GridControl.ShowOnlyPredefinedDetails Then
				For Each node As GridLevelNode In levelNode.Nodes
					Dim id As Integer = GetRelationIndex(rowHandle, node.RelationName)
					If id < -1 Then
						Continue For
					End If
					details.Add(New GridDetailInfo(id, node.RelationName, GetRelationDisplayName(rowHandle, id)))
				Next node
			Else
				Dim count As Integer = GetRelationCount(rowHandle)
				For n As Integer = 0 To count - 1
					Dim name As String = GetRelationName(rowHandle, n)
					details.Add(New GridDetailInfo(n, name,If(shortInfo, name, GetRelationDisplayName(rowHandle, n))))
				Next n
			End If
			If details.Count = 0 Then
				Return Nothing
			End If
			Return TryCast(details.ToArray(GetType(GridDetailInfo)), GridDetailInfo())
		End Function
	End Class

	Public Class DisableViewTabPage
		Inherits ViewTabPage
		Implements IXtraTabPage

		Public Sub New(ByVal tabControl As ViewTab)
			MyBase.New(tabControl)
		End Sub

		Private ReadOnly Property IXtraTabPage_Image() As Image Implements IXtraTabPage.Image
			Get
				Return Nothing
			End Get
		End Property
		Private ReadOnly Property IXtraTabPage_ImageIndex() As Integer Implements IXtraTabPage.ImageIndex
			Get
				Return -1
			End Get
		End Property
		Private ReadOnly Property IXtraTabPage_TabPageWidth() As Integer Implements IXtraTabPage.TabPageWidth
			Get
				Return 0
			End Get
		End Property
		Private ReadOnly Property IXtraTabPage_PageEnabled() As Boolean Implements IXtraTabPage.PageEnabled
			Get
				Return False
			End Get
		End Property
		Private ReadOnly Property IXtraTabPage_PageVisible() As Boolean Implements IXtraTabPage.PageVisible
			Get
				Return True
			End Get
		End Property
		Private Sub IXtraTabPage_Invalidate() Implements IXtraTabPage.Invalidate
			TabControl.Invalidate(TabControl.Bounds)
		End Sub
		Private ReadOnly Property IXtraTabPage_Appearance() As PageAppearance Implements IXtraTabPage.Appearance
			Get
				Return Nothing
			End Get
		End Property
		Private ReadOnly Property IXtraTabPage_Tooltip() As String Implements IXtraTabPage.Tooltip
			Get
				Return String.Empty
			End Get
		End Property
		Private ReadOnly Property IXtraTabPage_TooltipTitle() As String Implements IXtraTabPage.TooltipTitle
			Get
				Return String.Empty
			End Get
		End Property
		Private ReadOnly Property IXtraTabPage_TooltipIconType() As ToolTipIconType Implements IXtraTabPage.TooltipIconType
			Get
				Return ToolTipIconType.None
			End Get
		End Property
		Private ReadOnly Property IXtraTabPage_SuperTip() As SuperToolTip Implements IXtraTabPage.SuperTip
			Get
				Return Nothing
			End Get
		End Property
		Private ReadOnly Property IXtraTabPage_ShowCloseButton() As DefaultBoolean Implements IXtraTabPage.ShowCloseButton
			Get
				Return DefaultBoolean.Default
			End Get
		End Property

		Private ReadOnly Property IXtraTabPage_ImagePadding() As System.Windows.Forms.Padding Implements IXtraTabPage.ImagePadding
			Get
				Return New System.Windows.Forms.Padding(0)
			End Get
		End Property
	End Class
End Namespace