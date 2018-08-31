namespace Poseidon.Starter
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barChildList = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barLoginUser = new DevExpress.XtraBars.BarStaticItem();
            this.bbiChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExit = new DevExpress.XtraBars.BarButtonItem();
            this.rpBase = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgPersonnel = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.bbiResource = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barChildList,
            this.barLoginUser,
            this.bbiChangePassword,
            this.bbiExit,
            this.bbiResource});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 18;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpBase});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.Size = new System.Drawing.Size(924, 147);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // barChildList
            // 
            this.barChildList.Caption = "窗口";
            this.barChildList.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barChildList.Glyph = ((System.Drawing.Image)(resources.GetObject("barChildList.Glyph")));
            this.barChildList.Id = 3;
            this.barChildList.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barChildList.LargeGlyph")));
            this.barChildList.Name = "barChildList";
            // 
            // barLoginUser
            // 
            this.barLoginUser.Caption = "当前用户：";
            this.barLoginUser.Glyph = ((System.Drawing.Image)(resources.GetObject("barLoginUser.Glyph")));
            this.barLoginUser.Id = 34;
            this.barLoginUser.Name = "barLoginUser";
            this.barLoginUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bbiChangePassword
            // 
            this.bbiChangePassword.Caption = "修改密码";
            this.bbiChangePassword.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiChangePassword.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiChangePassword.Glyph")));
            this.bbiChangePassword.Id = 35;
            this.bbiChangePassword.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiChangePassword.LargeGlyph")));
            this.bbiChangePassword.Name = "bbiChangePassword";
            this.bbiChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChangePassword_ItemClick);
            // 
            // bbiExit
            // 
            this.bbiExit.Caption = "退出系统";
            this.bbiExit.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiExit.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiExit.Glyph")));
            this.bbiExit.Id = 5;
            this.bbiExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiExit.LargeGlyph")));
            this.bbiExit.Name = "bbiExit";
            this.bbiExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExit_ItemClick);
            // 
            // rpBase
            // 
            this.rpBase.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgPersonnel,
            this.rpgBase});
            this.rpBase.Name = "rpBase";
            this.rpBase.Text = "基本操作";
            // 
            // rpgPersonnel
            // 
            this.rpgPersonnel.ItemLinks.Add(this.bbiChangePassword);
            this.rpgPersonnel.Name = "rpgPersonnel";
            this.rpgPersonnel.Text = "个人信息";
            // 
            // rpgBase
            // 
            this.rpgBase.ItemLinks.Add(this.bbiResource);
            this.rpgBase.ItemLinks.Add(this.barChildList);
            this.rpgBase.ItemLinks.Add(this.bbiExit);
            this.rpgBase.Name = "rpgBase";
            this.rpgBase.Text = "系统";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barLoginUser);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 557);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(924, 31);
            // 
            // tabMdiManager
            // 
            this.tabMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.tabMdiManager.MdiParent = this;
            this.tabMdiManager.PinPageButtonShowMode = DevExpress.XtraTab.PinPageButtonShowMode.InActiveTabPageHeader;
            // 
            // bbiResource
            // 
            this.bbiResource.Caption = "资源管理";
            this.bbiResource.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiResource.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiResource.Glyph")));
            this.bbiResource.Id = 17;
            this.bbiResource.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiResource.LargeGlyph")));
            this.bbiResource.Name = "bbiResource";
            this.bbiResource.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiResource_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "能源科信息化管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabMdiManager;
        private DevExpress.XtraBars.BarMdiChildrenListItem barChildList;
        private DevExpress.XtraBars.BarStaticItem barLoginUser;
        private DevExpress.XtraBars.BarButtonItem bbiChangePassword;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPersonnel;
        private DevExpress.XtraBars.BarButtonItem bbiExit;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpBase;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBase;
        private DevExpress.XtraBars.BarButtonItem bbiResource;
    }
}

