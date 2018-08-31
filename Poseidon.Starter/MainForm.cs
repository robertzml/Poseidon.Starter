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
        /// 检查权限载入菜单
        /// </summary>
        private void LoadMenus()
        {
            var menus = CallerFactory<IMenuService>.Instance.FindAll().Where(r => r.Visible == true);
            var privileges = CallerFactory<IUserService>.Instance.GetPrivileges(GlobalAction.CurrentUser.Id);

            Assembly assembly = Assembly.GetExecutingAssembly();
            ResourceManager rm = new ResourceManager("Poseidon.Starter.Properties.Resources", assembly);

            // 模块分页
            var pages = menus.Where(r => r.Type == (int)MenuType.Page).OrderByDescending(r => r.Sort);
            foreach (var page in pages)
            {
                if (!GlobalAction.CurrentUser.IsRoot && !privileges.Contains(page.PrivilegeCode))
                    continue;

                RibbonPage rp = new RibbonPage();
                rp.Text = page.Name;
                this.ribbonControl.Pages.Insert(0, rp);

                // 二级分组
                var groups = menus.Where(r => r.ParentId == page.Id && r.Type == (int)MenuType.Group).OrderBy(r => r.Sort);
                foreach (var group in groups)
                {
                    if (!GlobalAction.CurrentUser.IsRoot && !privileges.Contains(group.PrivilegeCode))
                        continue;

                    RibbonPageGroup rpg = new RibbonPageGroup();
                    rpg.Text = group.Name;
                    rp.Groups.Add(rpg);

                    // 功能按钮
                    var buttons = menus.Where(r => r.ParentId == group.Id && r.Type == (int)MenuType.Button).OrderBy(r => r.Sort);
                    foreach (var button in buttons)
                    {
                        if (!GlobalAction.CurrentUser.IsRoot && !privileges.Contains(button.PrivilegeCode))
                            continue;

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

            this.ribbonControl.SelectedPage = this.ribbonControl.Pages[0];
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

            LoadMenus();
            SetStatusBar();
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

            if (string.IsNullOrEmpty(assemblyName) || string.IsNullOrEmpty(typeName))
            {
                MessageUtil.ShowError("菜单未正确配置");
                return;
            }

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
        /// 资源管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiResource_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmResourceManage));
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
        #endregion //Event
    }
}
