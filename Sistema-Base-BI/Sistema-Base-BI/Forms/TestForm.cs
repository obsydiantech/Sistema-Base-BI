using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sistema_Base_BI.Managers;

namespace Sistema_Base_BI.Forms
{
    public partial class TestForm : MetroFramework.Forms.MetroForm
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }

        private void onTile_MouseEnter(object sender, EventArgs e)
        {
            ((MetroFramework.Controls.MetroTile)sender).Style = MetroFramework.MetroColorStyle.Black;
        }

        private void onTile_MouseLeave(object sender, EventArgs e)
        {

            ((MetroFramework.Controls.MetroTile)sender).Style = MetroFramework.MetroColorStyle.Default;
        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {

        }
    }
}
