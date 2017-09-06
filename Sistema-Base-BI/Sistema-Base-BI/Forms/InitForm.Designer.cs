namespace Sistema_Base_BI.Forms
{
    partial class InitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitForm));
            this.InitForm_ObsLabel = new System.Windows.Forms.Label();
            this.InitForm_ObsLogo = new System.Windows.Forms.PictureBox();
            this.InitForm_AppVerLabel = new System.Windows.Forms.Label();
            this.InitForm_LicenciaLabel = new System.Windows.Forms.Label();
            this.InitForm_CopyrighLabel = new System.Windows.Forms.Label();
            this.InitForm_YearLabel = new System.Windows.Forms.Label();
            this.InitForm_ExpireDate = new System.Windows.Forms.Label();
            this.InitForm_WelcomeLabel = new System.Windows.Forms.Label();
            this.fadingInTimer = new System.Windows.Forms.Timer(this.components);
            this.fadingOutTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InitForm_ObsLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // InitForm_ObsLabel
            // 
            this.InitForm_ObsLabel.AutoSize = true;
            this.InitForm_ObsLabel.BackColor = System.Drawing.Color.Transparent;
            this.InitForm_ObsLabel.Font = new System.Drawing.Font("Eras Demi ITC", 11.5F);
            this.InitForm_ObsLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.InitForm_ObsLabel.Location = new System.Drawing.Point(65, 200);
            this.InitForm_ObsLabel.Name = "InitForm_ObsLabel";
            this.InitForm_ObsLabel.Size = new System.Drawing.Size(185, 19);
            this.InitForm_ObsLabel.TabIndex = 0;
            this.InitForm_ObsLabel.Text = "Obsydian Technologies";
            this.InitForm_ObsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InitForm_ObsLogo
            // 
            this.InitForm_ObsLogo.BackColor = System.Drawing.Color.Transparent;
            this.InitForm_ObsLogo.Location = new System.Drawing.Point(60, 12);
            this.InitForm_ObsLogo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.InitForm_ObsLogo.Name = "InitForm_ObsLogo";
            this.InitForm_ObsLogo.Size = new System.Drawing.Size(195, 188);
            this.InitForm_ObsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InitForm_ObsLogo.TabIndex = 1;
            this.InitForm_ObsLogo.TabStop = false;
            // 
            // InitForm_AppVerLabel
            // 
            this.InitForm_AppVerLabel.AutoSize = true;
            this.InitForm_AppVerLabel.BackColor = System.Drawing.Color.Transparent;
            this.InitForm_AppVerLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitForm_AppVerLabel.ForeColor = System.Drawing.Color.Gray;
            this.InitForm_AppVerLabel.Location = new System.Drawing.Point(252, 3);
            this.InitForm_AppVerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.InitForm_AppVerLabel.Name = "InitForm_AppVerLabel";
            this.InitForm_AppVerLabel.Size = new System.Drawing.Size(60, 15);
            this.InitForm_AppVerLabel.TabIndex = 2;
            this.InitForm_AppVerLabel.Text = "Ver 0.2.9";
            // 
            // InitForm_LicenciaLabel
            // 
            this.InitForm_LicenciaLabel.AutoSize = true;
            this.InitForm_LicenciaLabel.BackColor = System.Drawing.Color.Transparent;
            this.InitForm_LicenciaLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitForm_LicenciaLabel.ForeColor = System.Drawing.Color.Gray;
            this.InitForm_LicenciaLabel.Location = new System.Drawing.Point(46, 263);
            this.InitForm_LicenciaLabel.Margin = new System.Windows.Forms.Padding(0);
            this.InitForm_LicenciaLabel.Name = "InitForm_LicenciaLabel";
            this.InitForm_LicenciaLabel.Size = new System.Drawing.Size(225, 15);
            this.InitForm_LicenciaLabel.TabIndex = 3;
            this.InitForm_LicenciaLabel.Text = "Cedido bajo licencia a : Ecco Logística";
            // 
            // InitForm_CopyrighLabel
            // 
            this.InitForm_CopyrighLabel.AutoSize = true;
            this.InitForm_CopyrighLabel.BackColor = System.Drawing.Color.Transparent;
            this.InitForm_CopyrighLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitForm_CopyrighLabel.ForeColor = System.Drawing.Color.Gray;
            this.InitForm_CopyrighLabel.Location = new System.Drawing.Point(66, 219);
            this.InitForm_CopyrighLabel.Margin = new System.Windows.Forms.Padding(0);
            this.InitForm_CopyrighLabel.Name = "InitForm_CopyrighLabel";
            this.InitForm_CopyrighLabel.Size = new System.Drawing.Size(189, 15);
            this.InitForm_CopyrighLabel.TabIndex = 4;
            this.InitForm_CopyrighLabel.Text = "Todos los derechos reservados.";
            // 
            // InitForm_YearLabel
            // 
            this.InitForm_YearLabel.AutoSize = true;
            this.InitForm_YearLabel.BackColor = System.Drawing.Color.Transparent;
            this.InitForm_YearLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitForm_YearLabel.ForeColor = System.Drawing.Color.Gray;
            this.InitForm_YearLabel.Location = new System.Drawing.Point(271, 18);
            this.InitForm_YearLabel.Margin = new System.Windows.Forms.Padding(0);
            this.InitForm_YearLabel.Name = "InitForm_YearLabel";
            this.InitForm_YearLabel.Size = new System.Drawing.Size(35, 15);
            this.InitForm_YearLabel.TabIndex = 5;
            this.InitForm_YearLabel.Text = "2017";
            // 
            // InitForm_ExpireDate
            // 
            this.InitForm_ExpireDate.AutoSize = true;
            this.InitForm_ExpireDate.BackColor = System.Drawing.Color.Transparent;
            this.InitForm_ExpireDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitForm_ExpireDate.ForeColor = System.Drawing.Color.Gray;
            this.InitForm_ExpireDate.Location = new System.Drawing.Point(78, 295);
            this.InitForm_ExpireDate.Margin = new System.Windows.Forms.Padding(0);
            this.InitForm_ExpireDate.Name = "InitForm_ExpireDate";
            this.InitForm_ExpireDate.Size = new System.Drawing.Size(158, 15);
            this.InitForm_ExpireDate.TabIndex = 6;
            this.InitForm_ExpireDate.Text = "Vencimiento : Licencia Full";
            // 
            // InitForm_WelcomeLabel
            // 
            this.InitForm_WelcomeLabel.AutoSize = true;
            this.InitForm_WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.InitForm_WelcomeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitForm_WelcomeLabel.ForeColor = System.Drawing.Color.Gray;
            this.InitForm_WelcomeLabel.Location = new System.Drawing.Point(118, 324);
            this.InitForm_WelcomeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.InitForm_WelcomeLabel.Name = "InitForm_WelcomeLabel";
            this.InitForm_WelcomeLabel.Size = new System.Drawing.Size(70, 15);
            this.InitForm_WelcomeLabel.TabIndex = 7;
            this.InitForm_WelcomeLabel.Text = "Bienvenido";
            // 
            // fadingInTimer
            // 
            this.fadingInTimer.Interval = 10;
            this.fadingInTimer.Tick += new System.EventHandler(this.FadingIn_Tick);
            // 
            // fadingOutTimer
            // 
            this.fadingOutTimer.Interval = 10;
            this.fadingOutTimer.Tick += new System.EventHandler(this.FadingOut_Tick);
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 361);
            this.ControlBox = false;
            this.Controls.Add(this.InitForm_WelcomeLabel);
            this.Controls.Add(this.InitForm_ExpireDate);
            this.Controls.Add(this.InitForm_YearLabel);
            this.Controls.Add(this.InitForm_CopyrighLabel);
            this.Controls.Add(this.InitForm_LicenciaLabel);
            this.Controls.Add(this.InitForm_AppVerLabel);
            this.Controls.Add(this.InitForm_ObsLogo);
            this.Controls.Add(this.InitForm_ObsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(315, 361);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(315, 361);
            this.Name = "InitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.InitForm_ObsLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InitForm_ObsLabel;
        private System.Windows.Forms.PictureBox InitForm_ObsLogo;
        private System.Windows.Forms.Label InitForm_AppVerLabel;
        private System.Windows.Forms.Label InitForm_LicenciaLabel;
        private System.Windows.Forms.Label InitForm_CopyrighLabel;
        private System.Windows.Forms.Label InitForm_YearLabel;
        private System.Windows.Forms.Label InitForm_ExpireDate;
        private System.Windows.Forms.Label InitForm_WelcomeLabel;
        private System.Windows.Forms.Timer fadingInTimer;
        private System.Windows.Forms.Timer fadingOutTimer;
    }
}