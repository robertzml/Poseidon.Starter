using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
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

            CheckPrivilege();
            SetStatusBar();

#if DEBUG
            this.bbiTest.Visibility = BarItemVisibility.Always;
#else
            this.bbiTest.Visibility = BarItemVisibility.Never;
#endif
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

        /// <summary>
        /// 指标制定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiTargetMake_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmTargetMake";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 人数总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiPopulationOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmPopulationOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 人数管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiPopulationMan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmPopulationManage";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 经费总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiFundOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmFundOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 经费管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiFundMan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmFundManage";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 计量总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiMeasureOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmMeasureOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 计量管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiMeasureMan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmMeasureManage";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 能源结算总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiSettlementOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmSettlementOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 能源结算管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiSettlementMan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmSettlementManage";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 部门总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDepartmentOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmDepartmentOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }
        #endregion //Energy

        #region Expense
        /// <summary>
        /// 支出总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiExpenseOv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Expense.ClientDx";
            string typeName = "Poseidon.Expense.ClientDx.FrmExpenseOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 支出单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiExpenseReceipt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Expense.ClientDx";
            string typeName = "Poseidon.Expense.ClientDx.FrmExpenseReceipt";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 支出账户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiExpenseAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Expense.ClientDx";
            string typeName = "Poseidon.Expense.ClientDx.FrmExpenseAccount";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }
        #endregion //Expense

        #region Recovery
        /// <summary>
        /// 回收总览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiRecoveryOv_ItemClick(object sender, ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Recovery.ClientDx";
            string typeName = "Poseidon.Recovery.ClientDx.FrmRecoveryOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 回收单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiRecoveryReceipt_ItemClick(object sender, ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Recovery.ClientDx";
            string typeName = "Poseidon.Recovery.ClientDx.FrmRecoveryReceipt";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 回收账户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiRecoveryAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Recovery.ClientDx";
            string typeName = "Poseidon.Recovery.ClientDx.FrmAccountManage";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }

        /// <summary>
        /// 计费建筑管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiChargeBuildingMan_ItemClick(object sender, ItemClickEventArgs e)
        {
            string assemblyName = "Poseidon.Recovery.ClientDx";
            string typeName = "Poseidon.Recovery.ClientDx.FrmChargeBuildingManage";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);
        }
        #endregion //Recovery

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
            string assemblyName = "Poseidon.Energy.ClientDx";
            string typeName = "Poseidon.Energy.ClientDx.FrmDepartmentOverview";

            ChildFormManage.LoadMdiForm(this, assemblyName, typeName);

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
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ChildFormManage.ShowDialogForm(typeof(FrmChangePassword));
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
