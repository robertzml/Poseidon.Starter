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
            this.bbiModelTypeMan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGroupMan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDictOv = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUserMan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRoleMan = new DevExpress.XtraBars.BarButtonItem();
            this.barLoginUser = new DevExpress.XtraBars.BarStaticItem();
            this.bbiChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrivilegeMan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrivilegeAssign = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGroupTree = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTest = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAttachmentMan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCacheManage = new DevExpress.XtraBars.BarButtonItem();
            this.rpModel = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSystemFunction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgPrivilege = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpBase = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgPersonnel = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
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
            this.bbiModelTypeMan,
            this.bbiGroupMan,
            this.bbiDictOv,
            this.bbiUserMan,
            this.bbiRoleMan,
            this.barLoginUser,
            this.bbiChangePassword,
            this.bbiExit,
            this.bbiPrivilegeMan,
            this.bbiPrivilegeAssign,
            this.bbiGroupTree,
            this.bbiTest,
            this.bbiAttachmentMan,
            this.bbiCacheManage});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 17;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpModel,
            this.rpSystem,
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
            // bbiModelTypeMan
            // 
            this.bbiModelTypeMan.Caption = "模型类型管理";
            this.bbiModelTypeMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiModelTypeMan.Glyph")));
            this.bbiModelTypeMan.Id = 17;
            this.bbiModelTypeMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiModelTypeMan.LargeGlyph")));
            this.bbiModelTypeMan.Name = "bbiModelTypeMan";
            this.bbiModelTypeMan.Tag = "Model.ModelType";
            this.bbiModelTypeMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModelTypeMan_ItemClick);
            // 
            // bbiGroupMan
            // 
            this.bbiGroupMan.Caption = "分组管理";
            this.bbiGroupMan.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiGroupMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiGroupMan.Glyph")));
            this.bbiGroupMan.Id = 19;
            this.bbiGroupMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiGroupMan.LargeGlyph")));
            this.bbiGroupMan.Name = "bbiGroupMan";
            this.bbiGroupMan.Tag = "Model.Group";
            this.bbiGroupMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGroupMan_ItemClick);
            // 
            // bbiDictOv
            // 
            this.bbiDictOv.Caption = "字典总览";
            this.bbiDictOv.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiDictOv.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiDictOv.Glyph")));
            this.bbiDictOv.Id = 28;
            this.bbiDictOv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiDictOv.LargeGlyph")));
            this.bbiDictOv.Name = "bbiDictOv";
            this.bbiDictOv.Tag = "System.Dict";
            this.bbiDictOv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDictOv_ItemClick);
            // 
            // bbiUserMan
            // 
            this.bbiUserMan.Caption = "用户管理";
            this.bbiUserMan.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiUserMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiUserMan.Glyph")));
            this.bbiUserMan.Id = 30;
            this.bbiUserMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiUserMan.LargeGlyph")));
            this.bbiUserMan.Name = "bbiUserMan";
            this.bbiUserMan.Tag = "System.User";
            this.bbiUserMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUserMan_ItemClick);
            // 
            // bbiRoleMan
            // 
            this.bbiRoleMan.Caption = "角色管理";
            this.bbiRoleMan.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiRoleMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiRoleMan.Glyph")));
            this.bbiRoleMan.Id = 31;
            this.bbiRoleMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiRoleMan.LargeGlyph")));
            this.bbiRoleMan.Name = "bbiRoleMan";
            this.bbiRoleMan.Tag = "System.Role";
            this.bbiRoleMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRoleMan_ItemClick);
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
            // bbiPrivilegeMan
            // 
            this.bbiPrivilegeMan.Caption = "权限管理";
            this.bbiPrivilegeMan.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiPrivilegeMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiPrivilegeMan.Glyph")));
            this.bbiPrivilegeMan.Id = 6;
            this.bbiPrivilegeMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiPrivilegeMan.LargeGlyph")));
            this.bbiPrivilegeMan.Name = "bbiPrivilegeMan";
            this.bbiPrivilegeMan.Tag = "System.Privilege";
            this.bbiPrivilegeMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrivilegeMan_ItemClick);
            // 
            // bbiPrivilegeAssign
            // 
            this.bbiPrivilegeAssign.Caption = "权限分配";
            this.bbiPrivilegeAssign.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiPrivilegeAssign.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiPrivilegeAssign.Glyph")));
            this.bbiPrivilegeAssign.Id = 7;
            this.bbiPrivilegeAssign.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiPrivilegeAssign.LargeGlyph")));
            this.bbiPrivilegeAssign.Name = "bbiPrivilegeAssign";
            this.bbiPrivilegeAssign.Tag = "System.Privilege";
            this.bbiPrivilegeAssign.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrivilegeAssign_ItemClick);
            // 
            // bbiGroupTree
            // 
            this.bbiGroupTree.Caption = "分组树查看";
            this.bbiGroupTree.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiGroupTree.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiGroupTree.Glyph")));
            this.bbiGroupTree.Id = 8;
            this.bbiGroupTree.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiGroupTree.LargeGlyph")));
            this.bbiGroupTree.Name = "bbiGroupTree";
            this.bbiGroupTree.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGroupTree_ItemClick);
            // 
            // bbiTest
            // 
            this.bbiTest.Caption = "测试";
            this.bbiTest.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiTest.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiTest.Glyph")));
            this.bbiTest.Id = 14;
            this.bbiTest.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiTest.LargeGlyph")));
            this.bbiTest.Name = "bbiTest";
            this.bbiTest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTest_ItemClick);
            // 
            // bbiAttachmentMan
            // 
            this.bbiAttachmentMan.Caption = "附件管理";
            this.bbiAttachmentMan.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiAttachmentMan.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiAttachmentMan.Glyph")));
            this.bbiAttachmentMan.Id = 15;
            this.bbiAttachmentMan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiAttachmentMan.LargeGlyph")));
            this.bbiAttachmentMan.Name = "bbiAttachmentMan";
            this.bbiAttachmentMan.Tag = "System.Attachment";
            this.bbiAttachmentMan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAttachmentMan_ItemClick);
            // 
            // bbiCacheManage
            // 
            this.bbiCacheManage.Caption = "缓存管理";
            this.bbiCacheManage.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bbiCacheManage.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiCacheManage.Glyph")));
            this.bbiCacheManage.Id = 16;
            this.bbiCacheManage.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiCacheManage.LargeGlyph")));
            this.bbiCacheManage.Name = "bbiCacheManage";
            this.bbiCacheManage.Tag = "System.Cache";
            this.bbiCacheManage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCacheManage_ItemClick);
            // 
            // rpModel
            // 
            this.rpModel.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgGroup});
            this.rpModel.Name = "rpModel";
            this.rpModel.Tag = "Model";
            this.rpModel.Text = "模型管理";
            // 
            // rpgGroup
            // 
            this.rpgGroup.ItemLinks.Add(this.bbiModelTypeMan);
            this.rpgGroup.ItemLinks.Add(this.bbiGroupMan);
            this.rpgGroup.ItemLinks.Add(this.bbiGroupTree);
            this.rpgGroup.Name = "rpgGroup";
            this.rpgGroup.Text = "模型类型";
            // 
            // rpSystem
            // 
            this.rpSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSystemFunction,
            this.rpgPrivilege});
            this.rpSystem.Name = "rpSystem";
            this.rpSystem.Tag = "System";
            this.rpSystem.Text = "系统管理";
            // 
            // rpgSystemFunction
            // 
            this.rpgSystemFunction.ItemLinks.Add(this.bbiDictOv);
            this.rpgSystemFunction.ItemLinks.Add(this.bbiCacheManage);
            this.rpgSystemFunction.ItemLinks.Add(this.bbiAttachmentMan);
            this.rpgSystemFunction.Name = "rpgSystemFunction";
            this.rpgSystemFunction.Text = "系统功能";
            // 
            // rpgPrivilege
            // 
            this.rpgPrivilege.ItemLinks.Add(this.bbiUserMan);
            this.rpgPrivilege.ItemLinks.Add(this.bbiRoleMan);
            this.rpgPrivilege.ItemLinks.Add(this.bbiPrivilegeMan);
            this.rpgPrivilege.ItemLinks.Add(this.bbiPrivilegeAssign);
            this.rpgPrivilege.Name = "rpgPrivilege";
            this.rpgPrivilege.Text = "权限管理";
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
            this.rpgBase.ItemLinks.Add(this.bbiTest);
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSystemFunction;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabMdiManager;
        private DevExpress.XtraBars.BarMdiChildrenListItem barChildList;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpModel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGroup;
        private DevExpress.XtraBars.BarButtonItem bbiModelTypeMan;
        private DevExpress.XtraBars.BarButtonItem bbiGroupMan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPrivilege;
        private DevExpress.XtraBars.BarButtonItem bbiDictOv;
        private DevExpress.XtraBars.BarButtonItem bbiUserMan;
        private DevExpress.XtraBars.BarButtonItem bbiRoleMan;
        private DevExpress.XtraBars.BarStaticItem barLoginUser;
        private DevExpress.XtraBars.BarButtonItem bbiChangePassword;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPersonnel;
        private DevExpress.XtraBars.BarButtonItem bbiExit;
        private DevExpress.XtraBars.BarButtonItem bbiPrivilegeMan;
        private DevExpress.XtraBars.BarButtonItem bbiPrivilegeAssign;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpBase;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBase;
        private DevExpress.XtraBars.BarButtonItem bbiGroupTree;
        private DevExpress.XtraBars.BarButtonItem bbiTest;
        private DevExpress.XtraBars.BarButtonItem bbiAttachmentMan;
        private DevExpress.XtraBars.BarButtonItem bbiCacheManage;
    }
}

