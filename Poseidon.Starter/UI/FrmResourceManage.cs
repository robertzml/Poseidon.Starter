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

        private void LoadResource()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            //Stream manifestResourceStream = assembly.GetManifestResourceStream("");

            ResourceManager rm = new ResourceManager("Poseidon.Starter.Properties.Resources", assembly);
                        
            var caption = rm.GetString("Caption");

            var rs = rm.GetResourceSet(Thread.CurrentThread.CurrentCulture, true, false);
        }
        #endregion //Function

        #region Event
        private void btnLoadIcon_Click(object sender, EventArgs e)
        {
          
        }
        #endregion //Event
    }
}
