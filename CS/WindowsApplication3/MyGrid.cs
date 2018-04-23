using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraTab;
using DevExpress.XtraGrid.Tab;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using DevExpress.Utils;
using System.Collections;

namespace DXSample {
   

    public class MyGridControl : GridControl {
        protected override BaseView CreateDefaultView()
        {
            return CreateView("MyGridView");
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }
    }

    public class MyGridViewInfoRegistrator : GridInfoRegistrator  {
        public override string ViewName { get { return "MyGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyGridView(grid as GridControl); }
    }

    public class MyGridView : DevExpress.XtraGrid.Views.Grid.GridView {
        public event DetailTabStyleEventHandler DetailTabStyle;

        public MyGridView() : this(null) { }
        public MyGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) { }
        protected override string ViewName { get { return "MyGridView"; } }

        protected override void PopulateTabMasterData(DevExpress.XtraGrid.Tab.ViewTab tabControl, int rowHandle)
        {
            tabControl.HeaderLocation = DetailTabHeaderLocation;
            GridDetailInfo[] details = GetDetailInfo(rowHandle, false);
            if (details == null) return;
            int vIndex = GetVisibleDetailRelationIndex(rowHandle);
            foreach (GridDetailInfo detail in details)
            {
                if (!OptionsDetail.AllowExpandEmptyDetails && IsMasterRowEmptyEx(rowHandle, detail.RelationIndex))
                    continue;
                int detailRows = DataController.GetDetailList(rowHandle, detail.RelationIndex).Count;
                bool exp = vIndex == detail.RelationIndex;
                DetailTabStyleEventArgs e = new DetailTabStyleEventArgs(rowHandle, detail.RelationName, detail.RelationIndex, true);
                RaiseDetailTabStyle(e);
                if (e.Enabled)
                    CreateEnableTabPage(exp, tabControl, detail);
                else
                    CreateDisableTabPage(exp, tabControl, detail);
            }
        }

        internal void RaiseDetailTabStyle(DetailTabStyleEventArgs e)
        {
            if (DetailTabStyle != null)
                DetailTabStyle(this, e);
        }

        private void CreateEnableTabPage(bool exp, DevExpress.XtraGrid.Tab.ViewTab tabControl, GridDetailInfo detail)
        {
            ViewTabPage page = new ViewTabPage(tabControl);
            page.Text = detail.Caption.Trim();
            page.Tag = detail.RelationIndex;
            page.DetailInfo = detail;
            AddTabPage(exp, tabControl, page);
        }

        private void CreateDisableTabPage(bool exp, DevExpress.XtraGrid.Tab.ViewTab tabControl, GridDetailInfo detail)
        {
            DisableViewTabPage page = new DisableViewTabPage(tabControl);
            page.Text = detail.Caption.Trim();
            page.Tag = detail.RelationIndex;
            page.DetailInfo = detail;
            AddTabPage(exp, tabControl, page);
        }

        private static void AddTabPage(bool exp, DevExpress.XtraGrid.Tab.ViewTab tabControl, ViewTabPage page)
        {
            tabControl.Pages.Add(page);
            if (exp) tabControl.SelectedPage = page;
        }

        internal GridDetailInfo[] GetDetailInfo(int rowHandle, bool shortInfo)
        {
            if (!AllowMasterDetail || GridControl == null) return null;
            GridLevelNode levelNode = GetLevelNode();
            if (GridControl.ShowOnlyPredefinedDetails && (levelNode == null || !levelNode.HasChildren)) return null;
            ArrayList details = new ArrayList();
            if (GridControl.ShowOnlyPredefinedDetails)
            {
                foreach (GridLevelNode node in levelNode.Nodes)
                {
                    int id = GetRelationIndex(rowHandle, node.RelationName);
                    if (id < -1) continue;
                    details.Add(new GridDetailInfo(id, node.RelationName, GetRelationDisplayName(rowHandle, id)));
                }
            }
            else
            {
                int count = GetRelationCount(rowHandle);
                for (int n = 0; n < count; n++)
                {
                    string name = GetRelationName(rowHandle, n);
                    details.Add(new GridDetailInfo(n, name, shortInfo ? name : GetRelationDisplayName(rowHandle, n)));
                }
            }
            if (details.Count == 0) return null;
            return details.ToArray(typeof(GridDetailInfo)) as GridDetailInfo[];
        }
    }

    public class DisableViewTabPage : ViewTabPage, IXtraTabPage {
        public DisableViewTabPage(ViewTab tabControl)
            : base(tabControl) { }
       
        Image IXtraTabPage.Image { get { return null; } }
        int IXtraTabPage.ImageIndex { get { return -1; } }
        int IXtraTabPage.TabPageWidth { get { return 0; } }
        bool IXtraTabPage.PageEnabled { get { return false; } }
        bool IXtraTabPage.PageVisible { get { return true; } }
        void IXtraTabPage.Invalidate()
        {
            TabControl.Invalidate(TabControl.Bounds);
        }
        PageAppearance IXtraTabPage.Appearance
        {
            get { return null; }
        }
        string IXtraTabPage.Tooltip { get { return string.Empty; } }
        string IXtraTabPage.TooltipTitle { get { return string.Empty; } }
        ToolTipIconType IXtraTabPage.TooltipIconType { get { return ToolTipIconType.None; } }
        SuperToolTip IXtraTabPage.SuperTip { get { return null; } }
        DefaultBoolean IXtraTabPage.ShowCloseButton { get { return DefaultBoolean.Default; } }

        System.Windows.Forms.Padding IXtraTabPage.ImagePadding
        {
            get { return new System.Windows.Forms.Padding(0); }
        }
    }
}