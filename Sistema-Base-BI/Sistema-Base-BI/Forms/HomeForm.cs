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
    public partial class HomeForm : MetroFramework.Forms.MetroForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Sistema_Base_BI.Managers.FormsManager.Instance.NewForm("TestForm", false);
        }
    }
}
