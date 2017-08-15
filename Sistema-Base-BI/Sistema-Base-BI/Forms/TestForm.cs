using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Base_BI.Forms
{
    public partial class TestForm : MetroFramework.Forms.MetroForm
    {
        public TestForm()
        {
            InitializeComponent();

            MetroFramework.MetroMessageBox.Show(this, Sistema_Base_BI.Managers.ConfigManager.Instance.GetApplicationVersion());
        }
    }
}
