namespace Sistema_Base_BI.Forms.Admin_Forms.Management
{
    partial class LicenciaForm
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
            this.LicenciaForm_LicenciaHastaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.LicenciaForm_CancelButton = new MetroFramework.Controls.MetroTile();
            this.LicenciaForm_TerminosCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.LicenciaForm_TerminosLink = new MetroFramework.Controls.MetroLink();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // LicenciaForm_LicenciaHastaLabel
            // 
            this.LicenciaForm_LicenciaHastaLabel.AutoSize = true;
            this.LicenciaForm_LicenciaHastaLabel.BackColor = System.Drawing.Color.Transparent;
            this.LicenciaForm_LicenciaHastaLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenciaForm_LicenciaHastaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LicenciaForm_LicenciaHastaLabel.Location = new System.Drawing.Point(23, 75);
            this.LicenciaForm_LicenciaHastaLabel.Name = "LicenciaForm_LicenciaHastaLabel";
            this.LicenciaForm_LicenciaHastaLabel.Size = new System.Drawing.Size(259, 20);
            this.LicenciaForm_LicenciaHastaLabel.TabIndex = 0;
            this.LicenciaForm_LicenciaHastaLabel.Text = "Su licencia se encuentra activa hasta : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(227, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por favor ingrese su nuevo número de serie para renovar su licencia :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(155, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 27);
            this.textBox1.TabIndex = 2;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(454, 296);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(221, 64);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Registrar Licencia";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // LicenciaForm_CancelButton
            // 
            this.LicenciaForm_CancelButton.ActiveControl = null;
            this.LicenciaForm_CancelButton.Location = new System.Drawing.Point(190, 296);
            this.LicenciaForm_CancelButton.Name = "LicenciaForm_CancelButton";
            this.LicenciaForm_CancelButton.Size = new System.Drawing.Size(221, 64);
            this.LicenciaForm_CancelButton.Style = MetroFramework.MetroColorStyle.Green;
            this.LicenciaForm_CancelButton.TabIndex = 4;
            this.LicenciaForm_CancelButton.Text = "Cancelar";
            this.LicenciaForm_CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LicenciaForm_CancelButton.UseSelectable = true;
            this.LicenciaForm_CancelButton.Click += new System.EventHandler(this.LicenciaForm_CancelButton_Click);
            // 
            // LicenciaForm_TerminosCheckBox
            // 
            this.LicenciaForm_TerminosCheckBox.AutoSize = true;
            this.LicenciaForm_TerminosCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.LicenciaForm_TerminosCheckBox.Location = new System.Drawing.Point(256, 224);
            this.LicenciaForm_TerminosCheckBox.Name = "LicenciaForm_TerminosCheckBox";
            this.LicenciaForm_TerminosCheckBox.Size = new System.Drawing.Size(350, 15);
            this.LicenciaForm_TerminosCheckBox.TabIndex = 5;
            this.LicenciaForm_TerminosCheckBox.Text = "Acepto los términos y condiciones de Obsydian Technologies.";
            this.LicenciaForm_TerminosCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LicenciaForm_TerminosCheckBox.UseSelectable = true;
            // 
            // LicenciaForm_TerminosLink
            // 
            this.LicenciaForm_TerminosLink.BackColor = System.Drawing.Color.Transparent;
            this.LicenciaForm_TerminosLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LicenciaForm_TerminosLink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LicenciaForm_TerminosLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LicenciaForm_TerminosLink.Location = new System.Drawing.Point(352, 245);
            this.LicenciaForm_TerminosLink.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.LicenciaForm_TerminosLink.Name = "LicenciaForm_TerminosLink";
            this.LicenciaForm_TerminosLink.Size = new System.Drawing.Size(172, 23);
            this.LicenciaForm_TerminosLink.Style = MetroFramework.MetroColorStyle.Blue;
            this.LicenciaForm_TerminosLink.TabIndex = 6;
            this.LicenciaForm_TerminosLink.Text = "Ver términos y condiciones";
            this.LicenciaForm_TerminosLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LicenciaForm_TerminosLink.UseCustomBackColor = true;
            this.LicenciaForm_TerminosLink.UseCustomForeColor = true;
            this.LicenciaForm_TerminosLink.UseSelectable = true;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Enabled = false;
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(288, 70);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 7;
            this.metroDateTime1.Value = new System.DateTime(2017, 11, 30, 0, 0, 0, 0);
            // 
            // LicenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 388);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.LicenciaForm_TerminosLink);
            this.Controls.Add(this.LicenciaForm_TerminosCheckBox);
            this.Controls.Add(this.LicenciaForm_CancelButton);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LicenciaForm_LicenciaHastaLabel);
            this.Name = "LicenciaForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Registrar Producto";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LicenciaForm_LicenciaHastaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile LicenciaForm_CancelButton;
        private MetroFramework.Controls.MetroCheckBox LicenciaForm_TerminosCheckBox;
        private MetroFramework.Controls.MetroLink LicenciaForm_TerminosLink;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
    }
}