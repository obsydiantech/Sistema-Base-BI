namespace Sistema_Base_BI.Forms
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.StartForm_ObsLabel = new System.Windows.Forms.Label();
            this.StartForm_ObsLogo = new System.Windows.Forms.PictureBox();
            this.StartForm_AppVerLabel = new System.Windows.Forms.Label();
            this.StartForm_LicenciaLabel = new System.Windows.Forms.Label();
            this.StartForm_CopyrighLabel = new System.Windows.Forms.Label();
            this.StartForm_YearLabel = new System.Windows.Forms.Label();
            this.StartForm_ExpireDate = new System.Windows.Forms.Label();
            this.StartForm_WelcomeLabel = new System.Windows.Forms.Label();
            this.StartFormTimer1 = new System.Windows.Forms.Timer(this.components);
            this.StartFormTimer2 = new System.Windows.Forms.Timer(this.components);
            this.StartFormTimer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StartForm_ObsLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // StartForm_ObsLabel
            // 
            this.StartForm_ObsLabel.AutoSize = true;
            this.StartForm_ObsLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartForm_ObsLabel.Font = new System.Drawing.Font("Eras Demi ITC", 11.5F);
            this.StartForm_ObsLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.StartForm_ObsLabel.Location = new System.Drawing.Point(65, 200);
            this.StartForm_ObsLabel.Name = "StartForm_ObsLabel";
            this.StartForm_ObsLabel.Size = new System.Drawing.Size(185, 19);
            this.StartForm_ObsLabel.TabIndex = 0;
            this.StartForm_ObsLabel.Text = "Obsydian Technologies";
            this.StartForm_ObsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartForm_ObsLogo
            // 
            this.StartForm_ObsLogo.BackColor = System.Drawing.Color.Transparent;
            this.StartForm_ObsLogo.Image = ((System.Drawing.Image)(resources.GetObject("StartForm_ObsLogo.Image")));
            this.StartForm_ObsLogo.Location = new System.Drawing.Point(60, 12);
            this.StartForm_ObsLogo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.StartForm_ObsLogo.Name = "StartForm_ObsLogo";
            this.StartForm_ObsLogo.Size = new System.Drawing.Size(195, 188);
            this.StartForm_ObsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartForm_ObsLogo.TabIndex = 1;
            this.StartForm_ObsLogo.TabStop = false;
            // 
            // StartForm_AppVerLabel
            // 
            this.StartForm_AppVerLabel.AutoSize = true;
            this.StartForm_AppVerLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartForm_AppVerLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartForm_AppVerLabel.ForeColor = System.Drawing.Color.Gray;
            this.StartForm_AppVerLabel.Location = new System.Drawing.Point(252, 3);
            this.StartForm_AppVerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StartForm_AppVerLabel.Name = "StartForm_AppVerLabel";
            this.StartForm_AppVerLabel.Size = new System.Drawing.Size(60, 15);
            this.StartForm_AppVerLabel.TabIndex = 2;
            this.StartForm_AppVerLabel.Text = "Ver 0.2.9";
            // 
            // StartForm_LicenciaLabel
            // 
            this.StartForm_LicenciaLabel.AutoSize = true;
            this.StartForm_LicenciaLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartForm_LicenciaLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartForm_LicenciaLabel.ForeColor = System.Drawing.Color.Gray;
            this.StartForm_LicenciaLabel.Location = new System.Drawing.Point(46, 263);
            this.StartForm_LicenciaLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StartForm_LicenciaLabel.Name = "StartForm_LicenciaLabel";
            this.StartForm_LicenciaLabel.Size = new System.Drawing.Size(225, 15);
            this.StartForm_LicenciaLabel.TabIndex = 3;
            this.StartForm_LicenciaLabel.Text = "Cedido bajo licencia a : Ecco Logística";
            // 
            // StartForm_CopyrighLabel
            // 
            this.StartForm_CopyrighLabel.AutoSize = true;
            this.StartForm_CopyrighLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartForm_CopyrighLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartForm_CopyrighLabel.ForeColor = System.Drawing.Color.Gray;
            this.StartForm_CopyrighLabel.Location = new System.Drawing.Point(66, 219);
            this.StartForm_CopyrighLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StartForm_CopyrighLabel.Name = "StartForm_CopyrighLabel";
            this.StartForm_CopyrighLabel.Size = new System.Drawing.Size(189, 15);
            this.StartForm_CopyrighLabel.TabIndex = 4;
            this.StartForm_CopyrighLabel.Text = "Todos los derechos reservados.";
            // 
            // StartForm_YearLabel
            // 
            this.StartForm_YearLabel.AutoSize = true;
            this.StartForm_YearLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartForm_YearLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartForm_YearLabel.ForeColor = System.Drawing.Color.Gray;
            this.StartForm_YearLabel.Location = new System.Drawing.Point(271, 18);
            this.StartForm_YearLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StartForm_YearLabel.Name = "StartForm_YearLabel";
            this.StartForm_YearLabel.Size = new System.Drawing.Size(35, 15);
            this.StartForm_YearLabel.TabIndex = 5;
            this.StartForm_YearLabel.Text = "2017";
            // 
            // StartForm_ExpireDate
            // 
            this.StartForm_ExpireDate.AutoSize = true;
            this.StartForm_ExpireDate.BackColor = System.Drawing.Color.Transparent;
            this.StartForm_ExpireDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartForm_ExpireDate.ForeColor = System.Drawing.Color.Gray;
            this.StartForm_ExpireDate.Location = new System.Drawing.Point(78, 295);
            this.StartForm_ExpireDate.Margin = new System.Windows.Forms.Padding(0);
            this.StartForm_ExpireDate.Name = "StartForm_ExpireDate";
            this.StartForm_ExpireDate.Size = new System.Drawing.Size(158, 15);
            this.StartForm_ExpireDate.TabIndex = 6;
            this.StartForm_ExpireDate.Text = "Vencimiento : Licencia Full";
            // 
            // StartForm_WelcomeLabel
            // 
            this.StartForm_WelcomeLabel.AutoSize = true;
            this.StartForm_WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartForm_WelcomeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartForm_WelcomeLabel.ForeColor = System.Drawing.Color.Gray;
            this.StartForm_WelcomeLabel.Location = new System.Drawing.Point(118, 324);
            this.StartForm_WelcomeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StartForm_WelcomeLabel.Name = "StartForm_WelcomeLabel";
            this.StartForm_WelcomeLabel.Size = new System.Drawing.Size(70, 15);
            this.StartForm_WelcomeLabel.TabIndex = 7;
            this.StartForm_WelcomeLabel.Text = "Bienvenido";
            // 
            // StartFormTimer1
            // 
            this.StartFormTimer1.Interval = 10;
            this.StartFormTimer1.Tick += new System.EventHandler(this.StartFormTimer1_Tick);
            // 
            // StartFormTimer2
            // 
            this.StartFormTimer2.Interval = 1000;
            this.StartFormTimer2.Tick += new System.EventHandler(this.StartFormTimer2_Tick);
            // 
            // StartFormTimer3
            // 
            this.StartFormTimer3.Interval = 10;
            this.StartFormTimer3.Tick += new System.EventHandler(this.StartFormTimer3_Tick);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 361);
            this.ControlBox = false;
            this.Controls.Add(this.StartForm_WelcomeLabel);
            this.Controls.Add(this.StartForm_ExpireDate);
            this.Controls.Add(this.StartForm_YearLabel);
            this.Controls.Add(this.StartForm_CopyrighLabel);
            this.Controls.Add(this.StartForm_LicenciaLabel);
            this.Controls.Add(this.StartForm_AppVerLabel);
            this.Controls.Add(this.StartForm_ObsLogo);
            this.Controls.Add(this.StartForm_ObsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StartForm_ObsLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartForm_ObsLabel;
        private System.Windows.Forms.PictureBox StartForm_ObsLogo;
        private System.Windows.Forms.Label StartForm_AppVerLabel;
        private System.Windows.Forms.Label StartForm_LicenciaLabel;
        private System.Windows.Forms.Label StartForm_CopyrighLabel;
        private System.Windows.Forms.Label StartForm_YearLabel;
        private System.Windows.Forms.Label StartForm_ExpireDate;
        private System.Windows.Forms.Label StartForm_WelcomeLabel;
        private System.Windows.Forms.Timer StartFormTimer1;
        private System.Windows.Forms.Timer StartFormTimer2;
        private System.Windows.Forms.Timer StartFormTimer3;
    }
}