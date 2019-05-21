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

'INSTANT VB NOTE: The variable rowHandle was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable relationName was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable relationIndex was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable enabled was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal rowHandle_Renamed As Integer, ByVal relationName_Renamed As String, ByVal relationIndex_Renamed As Integer, ByVal enabled_Renamed As Boolean)
			Me.rowHandle_Renamed = rowHandle_Renamed
			Me.relationName_Renamed = relationName_Renamed
			Me.relationIndex_Renamed = relationIndex_Renamed
			Me.enabled_Renamed = enabled_Renamed
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