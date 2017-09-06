using System;

using System.Windows.Forms;
using MetroFramework.Forms;

using Sistema_Base_BI.Managers;

namespace Sistema_Base_BI.Forms
{
    public partial class LoginForm : MetroForm
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            components.SetStyle(this);
        }

        private void LoginForm_NewUser_Click(object sender, EventArgs e)
        {
            NewUserForm nuf = new NewUserForm();
            nuf.Show();
        }

        private void LoginForm_LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginForm_UserTextBox.Text == "" && LoginForm_PassTextBox.Text == "")
                FormsManager.Instance.NewForm("TestForm", false);
            else
                MetroFramework.MetroMessageBox.Show(this, "Usuario o contraseña incorrectos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void LoginForm_LicenceButton_Click(object sender, EventArgs e)
        {
            FormsManager.Instance.NewForm("LicenciaForm", false);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormsManager.Instance.PrevForm();
        }
    }
}
