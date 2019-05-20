using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }

        void GenerateCreateTableMethodByGridData(GridView gridView)
        {
            gridView.GridControl.ForceInitialize();
            string method = string.Empty;
            method =
                "DataTable CreateTable()" +
                 "{ DataTable table = new DataTable();" + Environment.NewLine + "DataRow dataRow;" + Environment.NewLine;
            for (int i = 0; i < gridView.Columns.Count; i++)
                method += @"table.Columns.Add(""" + gridView.Columns[i].FieldName + @"""" + ", typeof(" + gridView.Columns[i].ColumnType + "));" + Environment.NewLine;

            for (int j = 0; j < gridView.DataRowCount; j++)
            {
                method += "dataRow = table.NewRow();" + Environment.NewLine;
                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    method += @"dataRow[""" + gridView.Columns[i].FieldName + @"""" + "] = ";
                    if (gridView.Columns[i].ColumnType == typeof(String))
                        method += @"""" + gridView.GetRowCellValue(j, gridView.Columns[i]).ToString() + @""";" + Environment.NewLine;
                    else
                        if (gridView.Columns[i].ColumnType == typeof(DateTime))
                        method += @"DateTime.Parse(""" + gridView.GetRowCellValue(j, gridView.Columns[i]).ToString() + @""");" + Environment.NewLine;
                    else
                        method += gridView.GetRowCellValue(j, gridView.Columns[i]).ToString() + ";" + Environment.NewLine;
                }
                method += "table.Rows.Add(dataRow);" + Environment.NewLine + Environment.NewLine;
            }

            method += "return table;" + Environment.NewLine + " }";
            Clipboard.SetText(method);
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            DataSet dataSet1 = new DataSet();
            dataSet1.Tables.Add(DataHelper.CreateTable());
            dataSet1.Tables.Add(DataHelper.CreateChildTable());
            dataSet1.Tables.Add(DataHelper.CreateEmptyTable());
            DataColumn keyColumn = dataSet1.Tables[0].Columns["CustomerID"];
            DataColumn foreignKeyColumn = dataSet1.Tables[1].Columns["CustomerID"];
            dataSet1.Relations.Add("CustomersOrders", keyColumn, foreignKeyColumn);
            foreignKeyColumn = dataSet1.Tables[2].Columns["AnyColumn"];
             dataSet1.Relations.Add("Customers_AnyDataTable", keyColumn, foreignKeyColumn);
            myGridControl1.DataSource = dataSet1.Tables[0];
        }

        private void myGridView1_DetailTabStyle(object sender, DetailTabStyleEventArgs e)
        {
            if (e.RowHandle % 2 == 0 && e.RelationIndex == 1)
                e.Enabled = false;
        }
    }
}
