Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace DXSample
	Public Delegate Sub DetailTabStyleEventHandler(ByVal sender As Object, ByVal e As DetailTabStyleEventArgs)

	Public Class DetailTabStyleEventArgs
		Inherits EventArgs

'INSTANT VB NOTE: The field enabled was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private enabled_Renamed As Boolean
'INSTANT VB NOTE: The field relationIndex was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field rowHandle was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private relationIndex_Renamed, rowHandle_Renamed As Integer
'INSTANT VB NOTE: The field relationName was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private relationName_Renamed As String

		Public Sub New(ByVal rowHandle As Integer, ByVal relationName As String, ByVal relationIndex As Integer, ByVal enabled As Boolean)
			Me.rowHandle_Renamed = rowHandle
			Me.relationName_Renamed = relationName
			Me.relationIndex_Renamed = relationIndex
			Me.enabled_Renamed = enabled
		End Sub

		Public ReadOnly Property RowHandle() As Integer
			Get
				Return rowHandle_Renamed
			End Get
		End Property

		Public ReadOnly Property RelationIndex() As Integer
			Get
				Return relationIndex_Renamed
			End Get
		End Property

		Public ReadOnly Property RelationName() As String
			Get
				Return relationName_Renamed
			End Get
		End Property

		Public Property Enabled() As Boolean
			Get
				Return enabled_Renamed
			End Get
			Set(ByVal value As Boolean)
				If enabled_Renamed <> value Then
					enabled_Renamed = value
				End If
			End Set
		End Property
	End Class
End Namespace