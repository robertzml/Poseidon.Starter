using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
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
    using System.Resources;

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

            ResourceManager rm = new ResourceManager("Poseidon.Starter.Resources.MainResource", assembly);
                        
            var caption = rm.GetString("Caption");


            ResourceWriter write = new ResourceWriter("");
        }
        #endregion //Function

        private void btnLoadIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //dialog.FileName
            }
        }
    }
}
