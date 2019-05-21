Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Dim dataSet1 As New DataSet()
			dataSet1.Tables.Add(DataHelper.CreateTable())
			dataSet1.Tables.Add(DataHelper.CreateChildTable())
			dataSet1.Tables.Add(DataHelper.CreateEmptyTable())
			Dim keyColumn As DataColumn = dataSet1.Tables(0).Columns("CustomerID")
			Dim foreignKeyColumn As DataColumn = dataSet1.Tables(1).Columns("CustomerID")
			dataSet1.Relations.Add("CustomersOrders", keyColumn, foreignKeyColumn)
			foreignKeyColumn = dataSet1.Tables(2).Columns("AnyColumn")
			 dataSet1.Relations.Add("Customers_AnyDataTable", keyColumn, foreignKeyColumn)
			myGridControl1.DataSource = dataSet1.Tables(0)
		End Sub

		Private Sub myGridView1_DetailTabStyle(ByVal sender As Object, ByVal e As DetailTabStyleEventArgs) Handles myGridView1.DetailTabStyle
			If e.RowHandle Mod 2 = 0 AndAlso e.RelationIndex = 1 Then
				e.Enabled = False
			End If
		End Sub
	End Class
End Namespace
