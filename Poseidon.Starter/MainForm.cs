using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Starter
{
    using DevExpress.XtraBars;
    using DevExpress.XtraBars.Ribbon;
    using Poseidon.Base.Framework;
    using Poseidon.Caller.Facade;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;

    /// <summary>
    /// 主窗体界面
    /// </summary>
    public partial class MainForm : RibbonForm
    {
        #region Field

        #endregion //Field

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 检查权限
        /// </summary>
        protected void CheckPrivilege()
        {
            if (GlobalAction.CurrentUser.IsRoot)
                return;

            var privileges = CallerFactory<IUserService>.Instance.GetPrivileges(GlobalAction.CurrentUser.Id);

            foreach (RibbonPage page in this.ribbonControl.Pages)
            {
                if (page.Tag == null || privileges.Contains(page.Tag.ToString()))
                {
                    page.Visible = true;

                    foreach (RibbonPageGroup group in page.Groups)
                    {
                        if (group.Tag == null || privileges.Contains(group.Tag.ToString()))
                        {
                            group.Visible = true;
                        }
                        else
                            group.Visible = false;
                    }
                }
                else
                    page.Visible = false;
            }

            foreach (BarItem item in this.ribbonControl.Items)
            {
                if (item.Tag == null || privileges.Contains(item.Tag.ToString()))
                    item.Visibility = BarItemVisibility.Always;
                else
                    item.Visibility = BarItemVisibility.Never;
            }
        }

        /// <summary>
        /// 载入菜单
        /// </summary>
        private void LoadMenus()
        {
            var menus = CallerFactory<IMenuService>.Instance.FindAll();

            Assembly assembly = Assembly.GetExecutingAssembly();           
            ResourceManager rm = new ResourceManager("Poseidon.Starter.Properties.Resources", assembly);

            var pages = menus.Where(r => r.Type == (int)MenuType.Page).OrderBy(r => r.Sort);

            foreach(var page in pages)
            {
                RibbonPage rp = new RibbonPage();
                rp.Text = page.Name;
                this.ribbonControl.Pages.Insert(0, rp);

                var groups = menus.Where(r => r.ParentId == page.Id && r.Type == (int)MenuType.Group).OrderBy(r => r.Sort);
                foreach(var group in groups)
                {
                    RibbonPageGroup rpg = new RibbonPageGroup();
                    rpg.Text = group.Name;
                    rp.Groups.Add(rpg);

                    var buttons = menus.Where(r => r.ParentId == group.Id && r.Type == (int)MenuType.Button).OrderBy(r => r.Sort);
                    foreach(var button in buttons)
                    {
                        BarButtonItem bbi = new BarButtonItem();
                        bbi.Caption = button.Name;
                        bbi.Tag = button.AssemblyName + "," + button.TypeName;

                        // 设置图标
                        if (!string.IsNullOrEmpty(button.Glyph))
                        {
                            var glyph = rm.GetObject(button.Glyph);
                            if (glyph != null)
                                bbi.Glyph = (System.Drawing.Image)glyph;
                        }
                        if (!string.IsNullOrEmpty(button.LargeGlyph))
                        {
                            var large = rm.GetObject(button.LargeGlyph);
                            if (large != null)
                                bbi.LargeGlyph = (System.Drawing.Image)large;
                        }

                        rpg.ItemLinks.Add(bbi);

                        bbi.ItemClick += menuItem_Click;
                    }
                }

            }
        }

        /// <summary>
        /// 设置状态栏显示
        /// </summary>
        private void SetStatusBar()
        {
            this.barLoginUser.Caption = string.Format("当前用户：{0}", GlobalAction.CurrentUser.Name);
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = AppConfig.ApplicationName;

            //CheckPrivilege();
            LoadMenus();
            SetStatusBar();

#if DEBUG
            this.bbiTest.Visibility = BarItemVisibility.Always;
#else
            this.bbiTest.Visibility = BarItemVisibility.Never;
#endif
        }

   
        /// <summary>
        /// 菜单点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem_Click(object sender, ItemClickEventArgs e)
        {
            var item = e.Item as BarButtonItem;

            var s = item.Tag.ToString().Split(',');
            string assemblyName = s[0];
            string typeName = s[1];

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmChangePassword));
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageUtil.ConfirmYesNo("是否退出系统") == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #region Ribbon Event

        #region Energy
        /// <summary>
        /// 指标总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiTargetOverview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmTargetOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

      
        #endregion //Energy

     

      
        #region Model
        /// <summary>
        /// 模型类型管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiModelTypeMan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ChildFormManage.LoadMdiForm(this, typeof(FrmModelTypeManage));
        }

        /// <summary>
        /// 分组管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiGroupMan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ChildFormManage.LoadMdiForm(this, typeof(FrmGroupManage));
        }

        /// <summary>
        /// 分组树查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiGroupTree_ItemClick(object sender, ItemClickEventArgs e)
        {
            //ChildFormManage.LoadMdiForm(this, typeof(FrmGroupTree));
        }
        #endregion //Model

        #region System
        /// <summary>
        /// 字典总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDictOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ChildFormManage.LoadMdiForm(this, typeof(FrmDictOverview));
        }

        /// <summary>
        /// 缓存管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiCacheManage_ItemClick(object sender, ItemClickEventArgs e)
        {
            //string assemblyName = "Poseidon.Energy.ClientDx";
            //string typeName = "Poseidon.Energy.ClientDx.FrmDepartmentOverview";

            //ChildFormManage.LoadMdiForm(this, assemblyName, typeName);

            //ChildFormManage.LoadMdiForm(this, typeof(FrmCacheManage));
        }

        /// <summary>
        /// 附件管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiAttachmentMan_ItemClick(object sender, ItemClickEventArgs e)
        {
            //ChildFormManage.LoadMdiForm(this, typeof(FrmAttachmentManage));
        }

  

        /// <summary>
        /// 用户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiUserMan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ChildFormManage.LoadMdiForm(this, typeof(FrmUserList));
        }

        /// <summary>
        /// 角色管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiRoleMan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ChildFormManage.LoadMdiForm(this, typeof(FrmRoleManage));
        }

        /// <summary>
        /// 权限管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiPrivilegeMan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ChildFormManage.LoadMdiForm(this, typeof(FrmPrivilegeManage));
        }

        /// <summary>
        /// 权限分配
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiPrivilegeAssign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ChildFormManage.LoadMdiForm(this, typeof(FrmPrivilegeAssign));
        }

    

        /// <summary>
        /// 测试窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiTest_ItemClick(object sender, ItemClickEventArgs e)
        {
            //ChildFormManage.ShowDialogForm(typeof(TestForm));
        }
        #endregion //System

        #endregion //Ribbon Event

        #endregion //Event
    }
}
