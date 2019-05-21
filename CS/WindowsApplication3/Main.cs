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
