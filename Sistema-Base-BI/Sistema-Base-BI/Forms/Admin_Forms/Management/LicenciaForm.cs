using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Base_BI.Forms.Admin_Forms.Management
{
    public partial class LicenciaForm : MetroFramework.Forms.MetroForm
    {
        public LicenciaForm()
        {
            InitializeComponent();
        }

        private void LicenciaForm_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }

        private void LicenciaForm_CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
    }
}
