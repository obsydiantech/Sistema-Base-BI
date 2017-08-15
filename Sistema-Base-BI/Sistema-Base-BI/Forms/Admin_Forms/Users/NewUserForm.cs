using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Base_BI.Forms.Admin_Forms.Users
{
    public partial class NewUserForm : MetroFramework.Forms.MetroForm
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }

        private void NewUserForm_CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NewUserForm_PhotoBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                NewUserForm_PhotoPathTextBox.Text = openFileDialog1.FileName;
                NewUserForm_PictureBox.Image = new Bitmap(openFileDialog1.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
        }

        private void NewUserForm_CreateUserButton_Click(object sender, EventArgs e)
        {
            if (NewUserForm_PassTextBox1.Text != NewUserForm_PassTextBox2.Text)
            {
                NewUserForm_PassTextBox1.Style = MetroFramework.MetroColorStyle.Red;
                Refresh();
                NewUserForm_PassTextBox2.Style = MetroFramework.MetroColorStyle.Red;
                NewUserForm_PassTextBox2.Refresh();
            }
        }

        private void NewUserForm_PassTextBox1_Enter(object sender, EventArgs e)
        {
            NewUserForm_PassTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            Refresh();
            NewUserForm_PassTextBox2.Style = MetroFramework.MetroColorStyle.Blue;
            NewUserForm_PassTextBox2.Refresh();
        }
    }
}
