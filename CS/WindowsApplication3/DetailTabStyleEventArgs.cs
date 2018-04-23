using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;

namespace DXSample {
    public delegate void DetailTabStyleEventHandler(object sender, DetailTabStyleEventArgs e);

    public class DetailTabStyleEventArgs : EventArgs
    {
        bool enabled;
        int relationIndex, rowHandle;
        string relationName;

        public DetailTabStyleEventArgs(int rowHandle, string relationName, int relationIndex, bool enabled)
        {
            this.rowHandle = rowHandle;
            this.relationName = relationName;
            this.relationIndex = relationIndex;
            this.enabled = enabled;
        }

        public int RowHandle
        {
            get { return rowHandle; }
        }

        public int RelationIndex
        {
            get { return relationIndex; }
        }

        public string RelationName
        {
            get { return relationName; }
        }

        public bool Enabled
        {
            get { return enabled; }
            set
            {
                if (enabled != value)
                    enabled = value;
            }
        }
    }
}