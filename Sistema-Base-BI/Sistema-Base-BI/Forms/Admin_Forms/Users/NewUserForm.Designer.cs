namespace Sistema_Base_BI.Forms.Admin_Forms.Users
{
    partial class NewUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NewUserForm_NombreLabel = new MetroFramework.Controls.MetroLabel();
            this.NewUserForm_ApellidoLabel = new MetroFramework.Controls.MetroLabel();
            this.NewUserForm_EmailLabel = new MetroFramework.Controls.MetroLabel();
            this.NewUserForm_CargoLabel = new MetroFramework.Controls.MetroLabel();
            this.NewUserForm_DniLabel = new MetroFramework.Controls.MetroLabel();
            this.NewUserForm_EdadLabel = new MetroFramework.Controls.MetroLabel();
            this.NewUserForm_BornDateCalendar = new MetroFramework.Controls.MetroDateTime();
            this.NewUserForm_NombreTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NewUserForm_ApellidoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NewUserForm_EmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NewUserForm_DniTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.NewUserForm_CreateUserButton = new MetroFramework.Controls.MetroTile();
            this.NewUserForm_CancelButton = new MetroFramework.Controls.MetroTile();
            this.NewUserForm_PhotoLabel = new MetroFramework.Controls.MetroLabel();
            this.NewUserForm_PhotoBrowseButton = new MetroFramework.Controls.MetroTile();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NewUserForm_PhotoPathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NewUserForm_PictureBox = new System.Windows.Forms.PictureBox();
            this.NewUserForm_PassTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.NewUserForm_PassTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.NewUserForm_PasswordLabel1 = new MetroFramework.Controls.MetroLabel();
            this.NewUserForm_PasswordLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NewUserForm_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewUserForm_NombreLabel
            // 
            this.NewUserForm_NombreLabel.AutoSize = true;
            this.NewUserForm_NombreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewUserForm_NombreLabel.Location = new System.Drawing.Point(30, 112);
            this.NewUserForm_NombreLabel.Name = "NewUserForm_NombreLabel";
            this.NewUserForm_NombreLabel.Size = new System.Drawing.Size(72, 19);
            this.NewUserForm_NombreLabel.TabIndex = 3;
            this.NewUserForm_NombreLabel.Text = "Nombre* :";
            this.NewUserForm_NombreLabel.UseCustomBackColor = true;
            this.NewUserForm_NombreLabel.UseCustomForeColor = true;
            // 
            // NewUserForm_ApellidoLabel
            // 
            this.NewUserForm_ApellidoLabel.AutoSize = true;
            this.NewUserForm_ApellidoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewUserForm_ApellidoLabel.Location = new System.Drawing.Point(394, 112);
            this.NewUserForm_ApellidoLabel.Name = "NewUserForm_ApellidoLabel";
            this.NewUserForm_ApellidoLabel.Size = new System.Drawing.Size(71, 19);
            this.NewUserForm_ApellidoLabel.TabIndex = 4;
            this.NewUserForm_ApellidoLabel.Text = "Apellido* :";
            this.NewUserForm_ApellidoLabel.UseCustomBackColor = true;
            this.NewUserForm_ApellidoLabel.UseCustomForeColor = true;
            // 
            // NewUserForm_EmailLabel
            // 
            this.NewUserForm_EmailLabel.AutoSize = true;
            this.NewUserForm_EmailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewUserForm_EmailLabel.Location = new System.Drawing.Point(411, 168);
            this.NewUserForm_EmailLabel.Name = "NewUserForm_EmailLabel";
            this.NewUserForm_EmailLabel.Size = new System.Drawing.Size(54, 19);
            this.NewUserForm_EmailLabel.TabIndex = 5;
            this.NewUserForm_EmailLabel.Text = "E-Mail :";
            this.NewUserForm_EmailLabel.UseCustomBackColor = true;
            this.NewUserForm_EmailLabel.UseCustomForeColor = true;
            // 
            // NewUserForm_CargoLabel
            // 
            this.NewUserForm_CargoLabel.AutoSize = true;
            this.NewUserForm_CargoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewUserForm_CargoLabel.Location = new System.Drawing.Point(30, 222);
            this.NewUserForm_CargoLabel.Name = "NewUserForm_CargoLabel";
            this.NewUserForm_CargoLabel.Size = new System.Drawing.Size(59, 19);
            this.NewUserForm_CargoLabel.TabIndex = 6;
            this.NewUserForm_CargoLabel.Text = "Cargo* :";
            this.NewUserForm_CargoLabel.UseCustomBackColor = true;
            this.NewUserForm_CargoLabel.UseCustomForeColor = true;
            // 
            // NewUserForm_DniLabel
            // 
            this.NewUserForm_DniLabel.AutoSize = true;
            this.NewUserForm_DniLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewUserForm_DniLabel.Location = new System.Drawing.Point(30, 168);
            this.NewUserForm_DniLabel.Name = "NewUserForm_DniLabel";
            this.NewUserForm_DniLabel.Size = new System.Drawing.Size(43, 19);
            this.NewUserForm_DniLabel.TabIndex = 7;
            this.NewUserForm_DniLabel.Text = "D.N.I :";
            this.NewUserForm_DniLabel.UseCustomBackColor = true;
            this.NewUserForm_DniLabel.UseCustomForeColor = true;
            // 
            // NewUserForm_EdadLabel
            // 
            this.NewUserForm_EdadLabel.AutoSize = true;
            this.NewUserForm_EdadLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewUserForm_EdadLabel.Location = new System.Drawing.Point(382, 222);
            this.NewUserForm_EdadLabel.Name = "NewUserForm_EdadLabel";
            this.NewUserForm_EdadLabel.Size = new System.Drawing.Size(83, 19);
            this.NewUserForm_EdadLabel.TabIndex = 8;
            this.NewUserForm_EdadLabel.Text = "Nacimiento :";
            this.NewUserForm_EdadLabel.UseCustomBackColor = true;
            this.NewUserForm_EdadLabel.UseCustomForeColor = true;
            // 
            // NewUserForm_BornDateCalendar
            // 
            this.NewUserForm_BornDateCalendar.Location = new System.Drawing.Point(471, 218);
            this.NewUserForm_BornDateCalendar.MinimumSize = new System.Drawing.Size(0, 29);
            this.NewUserForm_BornDateCalendar.Name = "NewUserForm_BornDateCalendar";
            this.NewUserForm_BornDateCalendar.Size = new System.Drawing.Size(200, 29);
            this.NewUserForm_BornDateCalendar.TabIndex = 9;
            this.NewUserForm_BornDateCalendar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NewUserForm_BornDateCalendar.UseStyleColors = true;
            // 
            // NewUserForm_NombreTextBox
            // 
            // 
            // 
            // 
            this.NewUserForm_NombreTextBox.CustomButton.Image = null;
            this.NewUserForm_NombreTextBox.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.NewUserForm_NombreTextBox.CustomButton.Name = "";
            this.NewUserForm_NombreTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.NewUserForm_NombreTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewUserForm_NombreTextBox.CustomButton.TabIndex = 1;
            this.NewUserForm_NombreTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_NombreTextBox.CustomButton.UseSelectable = true;
            this.NewUserForm_NombreTextBox.CustomButton.Visible = false;
            this.NewUserForm_NombreTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.NewUserForm_NombreTextBox.Lines = new string[0];
            this.NewUserForm_NombreTextBox.Location = new System.Drawing.Point(120, 103);
            this.NewUserForm_NombreTextBox.MaxLength = 32767;
            this.NewUserForm_NombreTextBox.Name = "NewUserForm_NombreTextBox";
            this.NewUserForm_NombreTextBox.PasswordChar = '\0';
            this.NewUserForm_NombreTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewUserForm_NombreTextBox.SelectedText = "";
            this.NewUserForm_NombreTextBox.SelectionLength = 0;
            this.NewUserForm_NombreTextBox.SelectionStart = 0;
            this.NewUserForm_NombreTextBox.ShortcutsEnabled = true;
            this.NewUserForm_NombreTextBox.Size = new System.Drawing.Size(200, 28);
            this.NewUserForm_NombreTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewUserForm_NombreTextBox.TabIndex = 10;
            this.NewUserForm_NombreTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_NombreTextBox.UseSelectable = true;
            this.NewUserForm_NombreTextBox.UseStyleColors = true;
            this.NewUserForm_NombreTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewUserForm_NombreTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NewUserForm_ApellidoTextBox
            // 
            // 
            // 
            // 
            this.NewUserForm_ApellidoTextBox.CustomButton.Image = null;
            this.NewUserForm_ApellidoTextBox.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.NewUserForm_ApellidoTextBox.CustomButton.Name = "";
            this.NewUserForm_ApellidoTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.NewUserForm_ApellidoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewUserForm_ApellidoTextBox.CustomButton.TabIndex = 1;
            this.NewUserForm_ApellidoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_ApellidoTextBox.CustomButton.UseSelectable = true;
            this.NewUserForm_ApellidoTextBox.CustomButton.Visible = false;
            this.NewUserForm_ApellidoTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.NewUserForm_ApellidoTextBox.Lines = new string[0];
            this.NewUserForm_ApellidoTextBox.Location = new System.Drawing.Point(471, 103);
            this.NewUserForm_ApellidoTextBox.MaxLength = 32767;
            this.NewUserForm_ApellidoTextBox.Name = "NewUserForm_ApellidoTextBox";
            this.NewUserForm_ApellidoTextBox.PasswordChar = '\0';
            this.NewUserForm_ApellidoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewUserForm_ApellidoTextBox.SelectedText = "";
            this.NewUserForm_ApellidoTextBox.SelectionLength = 0;
            this.NewUserForm_ApellidoTextBox.SelectionStart = 0;
            this.NewUserForm_ApellidoTextBox.ShortcutsEnabled = true;
            this.NewUserForm_ApellidoTextBox.Size = new System.Drawing.Size(200, 28);
            this.NewUserForm_ApellidoTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewUserForm_ApellidoTextBox.TabIndex = 11;
            this.NewUserForm_ApellidoTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_ApellidoTextBox.UseSelectable = true;
            this.NewUserForm_ApellidoTextBox.UseStyleColors = true;
            this.NewUserForm_ApellidoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewUserForm_ApellidoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NewUserForm_EmailTextBox
            // 
            // 
            // 
            // 
            this.NewUserForm_EmailTextBox.CustomButton.Image = null;
            this.NewUserForm_EmailTextBox.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.NewUserForm_EmailTextBox.CustomButton.Name = "";
            this.NewUserForm_EmailTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.NewUserForm_EmailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewUserForm_EmailTextBox.CustomButton.TabIndex = 1;
            this.NewUserForm_EmailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_EmailTextBox.CustomButton.UseSelectable = true;
            this.NewUserForm_EmailTextBox.CustomButton.Visible = false;
            this.NewUserForm_EmailTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.NewUserForm_EmailTextBox.Lines = new string[0];
            this.NewUserForm_EmailTextBox.Location = new System.Drawing.Point(471, 159);
            this.NewUserForm_EmailTextBox.MaxLength = 32767;
            this.NewUserForm_EmailTextBox.Name = "NewUserForm_EmailTextBox";
            this.NewUserForm_EmailTextBox.PasswordChar = '\0';
            this.NewUserForm_EmailTextBox.PromptText = "yourname@example.com";
            this.NewUserForm_EmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewUserForm_EmailTextBox.SelectedText = "";
            this.NewUserForm_EmailTextBox.SelectionLength = 0;
            this.NewUserForm_EmailTextBox.SelectionStart = 0;
            this.NewUserForm_EmailTextBox.ShortcutsEnabled = true;
            this.NewUserForm_EmailTextBox.Size = new System.Drawing.Size(200, 28);
            this.NewUserForm_EmailTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewUserForm_EmailTextBox.TabIndex = 12;
            this.NewUserForm_EmailTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_EmailTextBox.UseSelectable = true;
            this.NewUserForm_EmailTextBox.UseStyleColors = true;
            this.NewUserForm_EmailTextBox.WaterMark = "yourname@example.com";
            this.NewUserForm_EmailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewUserForm_EmailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NewUserForm_DniTextBox
            // 
            // 
            // 
            // 
            this.NewUserForm_DniTextBox.CustomButton.Image = null;
            this.NewUserForm_DniTextBox.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.NewUserForm_DniTextBox.CustomButton.Name = "";
            this.NewUserForm_DniTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.NewUserForm_DniTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewUserForm_DniTextBox.CustomButton.TabIndex = 1;
            this.NewUserForm_DniTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_DniTextBox.CustomButton.UseSelectable = true;
            this.NewUserForm_DniTextBox.CustomButton.Visible = false;
            this.NewUserForm_DniTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.NewUserForm_DniTextBox.Lines = new string[0];
            this.NewUserForm_DniTextBox.Location = new System.Drawing.Point(120, 159);
            this.NewUserForm_DniTextBox.MaxLength = 32767;
            this.NewUserForm_DniTextBox.Name = "NewUserForm_DniTextBox";
            this.NewUserForm_DniTextBox.PasswordChar = '\0';
            this.NewUserForm_DniTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewUserForm_DniTextBox.SelectedText = "";
            this.NewUserForm_DniTextBox.SelectionLength = 0;
            this.NewUserForm_DniTextBox.SelectionStart = 0;
            this.NewUserForm_DniTextBox.ShortcutsEnabled = true;
            this.NewUserForm_DniTextBox.Size = new System.Drawing.Size(200, 28);
            this.NewUserForm_DniTextBox.TabIndex = 13;
            this.NewUserForm_DniTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_DniTextBox.UseSelectable = true;
            this.NewUserForm_DniTextBox.UseStyleColors = true;
            this.NewUserForm_DniTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewUserForm_DniTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Dueño",
            "Encargado",
            "Contador",
            "Empleado"});
            this.metroComboBox1.Location = new System.Drawing.Point(120, 218);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(200, 29);
            this.metroComboBox1.TabIndex = 14;
            this.metroComboBox1.UseSelectable = true;
            // 
            // NewUserForm_CreateUserButton
            // 
            this.NewUserForm_CreateUserButton.ActiveControl = null;
            this.NewUserForm_CreateUserButton.Location = new System.Drawing.Point(382, 474);
            this.NewUserForm_CreateUserButton.Name = "NewUserForm_CreateUserButton";
            this.NewUserForm_CreateUserButton.Size = new System.Drawing.Size(308, 46);
            this.NewUserForm_CreateUserButton.Style = MetroFramework.MetroColorStyle.Green;
            this.NewUserForm_CreateUserButton.TabIndex = 15;
            this.NewUserForm_CreateUserButton.Text = "Crear Usuario";
            this.NewUserForm_CreateUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewUserForm_CreateUserButton.UseSelectable = true;
            this.NewUserForm_CreateUserButton.UseStyleColors = true;
            this.NewUserForm_CreateUserButton.Click += new System.EventHandler(this.NewUserForm_CreateUserButton_Click);
            // 
            // NewUserForm_CancelButton
            // 
            this.NewUserForm_CancelButton.ActiveControl = null;
            this.NewUserForm_CancelButton.Location = new System.Drawing.Point(44, 474);
            this.NewUserForm_CancelButton.Name = "NewUserForm_CancelButton";
            this.NewUserForm_CancelButton.Size = new System.Drawing.Size(308, 46);
            this.NewUserForm_CancelButton.Style = MetroFramework.MetroColorStyle.Green;
            this.NewUserForm_CancelButton.TabIndex = 16;
            this.NewUserForm_CancelButton.Text = "Cancelar";
            this.NewUserForm_CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewUserForm_CancelButton.UseSelectable = true;
            this.NewUserForm_CancelButton.UseStyleColors = true;
            this.NewUserForm_CancelButton.Click += new System.EventHandler(this.NewUserForm_CancelButton_Click);
            // 
            // NewUserForm_PhotoLabel
            // 
            this.NewUserForm_PhotoLabel.AutoSize = true;
            this.NewUserForm_PhotoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewUserForm_PhotoLabel.Location = new System.Drawing.Point(30, 285);
            this.NewUserForm_PhotoLabel.Name = "NewUserForm_PhotoLabel";
            this.NewUserForm_PhotoLabel.Size = new System.Drawing.Size(43, 19);
            this.NewUserForm_PhotoLabel.TabIndex = 17;
            this.NewUserForm_PhotoLabel.Text = "Foto :";
            this.NewUserForm_PhotoLabel.UseCustomBackColor = true;
            this.NewUserForm_PhotoLabel.UseCustomForeColor = true;
            // 
            // NewUserForm_PhotoBrowseButton
            // 
            this.NewUserForm_PhotoBrowseButton.ActiveControl = null;
            this.NewUserForm_PhotoBrowseButton.Location = new System.Drawing.Point(120, 278);
            this.NewUserForm_PhotoBrowseButton.Name = "NewUserForm_PhotoBrowseButton";
            this.NewUserForm_PhotoBrowseButton.Size = new System.Drawing.Size(144, 35);
            this.NewUserForm_PhotoBrowseButton.TabIndex = 18;
            this.NewUserForm_PhotoBrowseButton.Text = "Examinar...";
            this.NewUserForm_PhotoBrowseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewUserForm_PhotoBrowseButton.UseSelectable = true;
            this.NewUserForm_PhotoBrowseButton.UseStyleColors = true;
            this.NewUserForm_PhotoBrowseButton.Click += new System.EventHandler(this.NewUserForm_PhotoBrowseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NewUserForm_PhotoPathTextBox
            // 
            this.NewUserForm_PhotoPathTextBox.BackColor = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.NewUserForm_PhotoPathTextBox.CustomButton.ForeColor = System.Drawing.Color.DarkRed;
            this.NewUserForm_PhotoPathTextBox.CustomButton.Image = null;
            this.NewUserForm_PhotoPathTextBox.CustomButton.Location = new System.Drawing.Point(360, 2);
            this.NewUserForm_PhotoPathTextBox.CustomButton.Name = "";
            this.NewUserForm_PhotoPathTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.NewUserForm_PhotoPathTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewUserForm_PhotoPathTextBox.CustomButton.TabIndex = 1;
            this.NewUserForm_PhotoPathTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_PhotoPathTextBox.CustomButton.UseSelectable = true;
            this.NewUserForm_PhotoPathTextBox.CustomButton.Visible = false;
            this.NewUserForm_PhotoPathTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.NewUserForm_PhotoPathTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.NewUserForm_PhotoPathTextBox.Lines = new string[] {
        "C:\\"};
            this.NewUserForm_PhotoPathTextBox.Location = new System.Drawing.Point(285, 285);
            this.NewUserForm_PhotoPathTextBox.MaxLength = 32767;
            this.NewUserForm_PhotoPathTextBox.Name = "NewUserForm_PhotoPathTextBox";
            this.NewUserForm_PhotoPathTextBox.PasswordChar = '\0';
            this.NewUserForm_PhotoPathTextBox.ReadOnly = true;
            this.NewUserForm_PhotoPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewUserForm_PhotoPathTextBox.SelectedText = "";
            this.NewUserForm_PhotoPathTextBox.SelectionLength = 0;
            this.NewUserForm_PhotoPathTextBox.SelectionStart = 0;
            this.NewUserForm_PhotoPathTextBox.ShortcutsEnabled = true;
            this.NewUserForm_PhotoPathTextBox.Size = new System.Drawing.Size(386, 28);
            this.NewUserForm_PhotoPathTextBox.TabIndex = 19;
            this.NewUserForm_PhotoPathTextBox.Text = "C:\\";
            this.NewUserForm_PhotoPathTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_PhotoPathTextBox.UseCustomForeColor = true;
            this.NewUserForm_PhotoPathTextBox.UseSelectable = true;
            this.NewUserForm_PhotoPathTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewUserForm_PhotoPathTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NewUserForm_PictureBox
            // 
            this.NewUserForm_PictureBox.Location = new System.Drawing.Point(394, 332);
            this.NewUserForm_PictureBox.Name = "NewUserForm_PictureBox";
            this.NewUserForm_PictureBox.Size = new System.Drawing.Size(104, 124);
            this.NewUserForm_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NewUserForm_PictureBox.TabIndex = 20;
            this.NewUserForm_PictureBox.TabStop = false;
            // 
            // NewUserForm_PassTextBox1
            // 
            // 
            // 
            // 
            this.NewUserForm_PassTextBox1.CustomButton.Image = null;
            this.NewUserForm_PassTextBox1.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.NewUserForm_PassTextBox1.CustomButton.Name = "";
            this.NewUserForm_PassTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.NewUserForm_PassTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewUserForm_PassTextBox1.CustomButton.TabIndex = 1;
            this.NewUserForm_PassTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_PassTextBox1.CustomButton.UseSelectable = true;
            this.NewUserForm_PassTextBox1.CustomButton.Visible = false;
            this.NewUserForm_PassTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.NewUserForm_PassTextBox1.Lines = new string[0];
            this.NewUserForm_PassTextBox1.Location = new System.Drawing.Point(120, 354);
            this.NewUserForm_PassTextBox1.MaxLength = 32767;
            this.NewUserForm_PassTextBox1.Name = "NewUserForm_PassTextBox1";
            this.NewUserForm_PassTextBox1.PasswordChar = '*';
            this.NewUserForm_PassTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewUserForm_PassTextBox1.SelectedText = "";
            this.NewUserForm_PassTextBox1.SelectionLength = 0;
            this.NewUserForm_PassTextBox1.SelectionStart = 0;
            this.NewUserForm_PassTextBox1.ShortcutsEnabled = true;
            this.NewUserForm_PassTextBox1.Size = new System.Drawing.Size(200, 28);
            this.NewUserForm_PassTextBox1.TabIndex = 21;
            this.NewUserForm_PassTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_PassTextBox1.UseSelectable = true;
            this.NewUserForm_PassTextBox1.UseStyleColors = true;
            this.NewUserForm_PassTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewUserForm_PassTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NewUserForm_PassTextBox1.Enter += new System.EventHandler(this.NewUserForm_PassTextBox1_Enter);
            // 
            // NewUserForm_PassTextBox2
            // 
            // 
            // 
            // 
            this.NewUserForm_PassTextBox2.CustomButton.Image = null;
            this.NewUserForm_PassTextBox2.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.NewUserForm_PassTextBox2.CustomButton.Name = "";
            this.NewUserForm_PassTextBox2.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.NewUserForm_PassTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewUserForm_PassTextBox2.CustomButton.TabIndex = 1;
            this.NewUserForm_PassTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_PassTextBox2.CustomButton.UseSelectable = true;
            this.NewUserForm_PassTextBox2.CustomButton.Visible = false;
            this.NewUserForm_PassTextBox2.ForeColor = System.Drawing.Color.Transparent;
            this.NewUserForm_PassTextBox2.Lines = new string[0];
            this.NewUserForm_PassTextBox2.Location = new System.Drawing.Point(120, 407);
            this.NewUserForm_PassTextBox2.MaxLength = 32767;
            this.NewUserForm_PassTextBox2.Name = "NewUserForm_PassTextBox2";
            this.NewUserForm_PassTextBox2.PasswordChar = '*';
            this.NewUserForm_PassTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewUserForm_PassTextBox2.SelectedText = "";
            this.NewUserForm_PassTextBox2.SelectionLength = 0;
            this.NewUserForm_PassTextBox2.SelectionStart = 0;
            this.NewUserForm_PassTextBox2.ShortcutsEnabled = true;
            this.NewUserForm_PassTextBox2.Size = new System.Drawing.Size(200, 28);
            this.NewUserForm_PassTextBox2.TabIndex = 22;
            this.NewUserForm_PassTextBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserForm_PassTextBox2.UseSelectable = true;
            this.NewUserForm_PassTextBox2.UseStyleColors = true;
            this.NewUserForm_PassTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewUserForm_PassTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NewUserForm_PasswordLabel1
            // 
            this.NewUserForm_PasswordLabel1.AutoSize = true;
            this.NewUserForm_PasswordLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewUserForm_PasswordLabel1.Location = new System.Drawing.Point(30, 354);
            this.NewUserForm_PasswordLabel1.Name = "NewUserForm_PasswordLabel1";
            this.NewUserForm_PasswordLabel1.Size = new System.Drawing.Size(88, 19);
            this.NewUserForm_PasswordLabel1.TabIndex = 23;
            this.NewUserForm_PasswordLabel1.Text = "Contraseña* :";
            this.NewUserForm_PasswordLabel1.UseCustomBackColor = true;
            this.NewUserForm_PasswordLabel1.UseCustomForeColor = true;
            // 
            // NewUserForm_PasswordLabel2
            // 
            this.NewUserForm_PasswordLabel2.AutoSize = true;
            this.NewUserForm_PasswordLabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewUserForm_PasswordLabel2.Location = new System.Drawing.Point(30, 407);
            this.NewUserForm_PasswordLabel2.Name = "NewUserForm_PasswordLabel2";
            this.NewUserForm_PasswordLabel2.Size = new System.Drawing.Size(64, 19);
            this.NewUserForm_PasswordLabel2.TabIndex = 24;
            this.NewUserForm_PasswordLabel2.Text = "Repetir* :";
            this.NewUserForm_PasswordLabel2.UseCustomBackColor = true;
            this.NewUserForm_PasswordLabel2.UseCustomForeColor = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 562);
            this.Controls.Add(this.NewUserForm_PasswordLabel2);
            this.Controls.Add(this.NewUserForm_PasswordLabel1);
            this.Controls.Add(this.NewUserForm_PassTextBox2);
            this.Controls.Add(this.NewUserForm_PassTextBox1);
            this.Controls.Add(this.NewUserForm_PictureBox);
            this.Controls.Add(this.NewUserForm_PhotoPathTextBox);
            this.Controls.Add(this.NewUserForm_PhotoBrowseButton);
            this.Controls.Add(this.NewUserForm_PhotoLabel);
            this.Controls.Add(this.NewUserForm_CancelButton);
            this.Controls.Add(this.NewUserForm_CreateUserButton);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.NewUserForm_DniTextBox);
            this.Controls.Add(this.NewUserForm_EmailTextBox);
            this.Controls.Add(this.NewUserForm_ApellidoTextBox);
            this.Controls.Add(this.NewUserForm_NombreTextBox);
            this.Controls.Add(this.NewUserForm_BornDateCalendar);
            this.Controls.Add(this.NewUserForm_EdadLabel);
            this.Controls.Add(this.NewUserForm_DniLabel);
            this.Controls.Add(this.NewUserForm_CargoLabel);
            this.Controls.Add(this.NewUserForm_EmailLabel);
            this.Controls.Add(this.NewUserForm_ApellidoLabel);
            this.Controls.Add(this.NewUserForm_NombreLabel);
            this.Name = "NewUserForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Crear nuevo usuario";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewUserForm_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel NewUserForm_NombreLabel;
        private MetroFramework.Controls.MetroLabel NewUserForm_ApellidoLabel;
        private MetroFramework.Controls.MetroLabel NewUserForm_EmailLabel;
        private MetroFramework.Controls.MetroLabel NewUserForm_CargoLabel;
        private MetroFramework.Controls.MetroLabel NewUserForm_DniLabel;
        private MetroFramework.Controls.MetroLabel NewUserForm_EdadLabel;
        private MetroFramework.Controls.MetroDateTime NewUserForm_BornDateCalendar;
        private MetroFramework.Controls.MetroTextBox NewUserForm_NombreTextBox;
        private MetroFramework.Controls.MetroTextBox NewUserForm_ApellidoTextBox;
        private MetroFramework.Controls.MetroTextBox NewUserForm_EmailTextBox;
        private MetroFramework.Controls.MetroTextBox NewUserForm_DniTextBox;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTile NewUserForm_CreateUserButton;
        private MetroFramework.Controls.MetroTile NewUserForm_CancelButton;
        private MetroFramework.Controls.MetroLabel NewUserForm_PhotoLabel;
        private MetroFramework.Controls.MetroTile NewUserForm_PhotoBrowseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTextBox NewUserForm_PhotoPathTextBox;
        private System.Windows.Forms.PictureBox NewUserForm_PictureBox;
        private MetroFramework.Controls.MetroTextBox NewUserForm_PassTextBox1;
        private MetroFramework.Controls.MetroTextBox NewUserForm_PassTextBox2;
        private MetroFramework.Controls.MetroLabel NewUserForm_PasswordLabel1;
        private MetroFramework.Controls.MetroLabel NewUserForm_PasswordLabel2;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}