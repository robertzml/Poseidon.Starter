using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Starter
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Caller.Facade;
    using Poseidon.Core.DL;
    using Poseidon.Common;
    using Poseidon.Winform.Base;


    /// <summary>
    /// 资源管理窗体
    /// </summary>
    public partial class FrmResourceManage : BaseMdiForm
    {
        #region Constructor
        public FrmResourceManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadResource();

            base.InitForm();
        }

        /// <summary>
        /// 载入资源
        /// </summary>
        private void LoadResource()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            ResourceManager rm = new ResourceManager("Poseidon.Starter.Properties.Resources", assembly);

            var caption = rm.GetString("Caption"); //keep this line

            var rs = rm.GetResourceSet(Thread.CurrentThread.CurrentCulture, true, false);
            var en = rs.GetEnumerator();

            while (en.MoveNext())
            {
                var key = en.Key;
                var val = en.Value;

                this.lbResource.Items.Add(en.Key);
            }
        }
        #endregion //Function

        #region Event
        private void btnLoadIcon_Click(object sender, EventArgs e)
        {
            LoadResource();
        }
        #endregion //Event
    }
}
