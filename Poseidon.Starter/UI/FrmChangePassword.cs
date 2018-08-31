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
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Caller.Facade;
    using Poseidon.Common;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 修改密码窗体
    /// </summary>
    public partial class FrmChangePassword : BaseSingleForm
    {
        #region Constructor
        public FrmChangePassword()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtOldPassword.Text))
            {
                errorMessage = "原密码不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            if (string.IsNullOrEmpty(this.txtNewPassword.Text))
            {
                errorMessage = "新密码不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            if (this.txtNewPassword.Text != this.txtConfirmPassword.Text)
            {
                errorMessage = "两次输入密码不一致";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                string oldPass = Hasher.SHA1Encrypt(this.txtOldPassword.Text);
                string newPass = Hasher.SHA1Encrypt(this.txtNewPassword.Text);

                var result = CallerFactory<IUserService>.Instance.CheckPassword(this.currentUser.UserName, oldPass);
                if (!result)
                {
                    MessageUtil.ShowInfo("原密码错误");
                    return;
                }

                result = CallerFactory<IUserService>.Instance.ChangePassword(this.currentUser.UserName, oldPass, newPass);
                if (result)
                {
                    MessageUtil.ShowInfo("修改密码成功");
                    this.Close();
                }
                else
                {
                    MessageUtil.ShowInfo("修改密码失败");
                }
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
