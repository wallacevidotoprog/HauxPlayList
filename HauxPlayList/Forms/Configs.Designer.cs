namespace HauxPlayList.Forms
{
    partial class form_configs
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage_pasta = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton_savePata = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_SubPasstaRaiz = new MetroFramework.Controls.MetroTextBox();
            this.metroButton_buscarPastaRaiz = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_PastaRaiz = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage_pasta.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage_pasta);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(677, 403);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage_pasta
            // 
            this.metroTabPage_pasta.Controls.Add(this.metroLabel2);
            this.metroTabPage_pasta.Controls.Add(this.metroLabel1);
            this.metroTabPage_pasta.Controls.Add(this.metroButton1);
            this.metroTabPage_pasta.Controls.Add(this.metroButton_savePata);
            this.metroTabPage_pasta.Controls.Add(this.metroTextBox_SubPasstaRaiz);
            this.metroTabPage_pasta.Controls.Add(this.metroButton_buscarPastaRaiz);
            this.metroTabPage_pasta.Controls.Add(this.metroTextBox_PastaRaiz);
            this.metroTabPage_pasta.HorizontalScrollbarBarColor = true;
            this.metroTabPage_pasta.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_pasta.HorizontalScrollbarSize = 10;
            this.metroTabPage_pasta.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage_pasta.Name = "metroTabPage_pasta";
            this.metroTabPage_pasta.Size = new System.Drawing.Size(669, 361);
            this.metroTabPage_pasta.TabIndex = 0;
            this.metroTabPage_pasta.Text = "Pastas";
            this.metroTabPage_pasta.VerticalScrollbarBarColor = true;
            this.metroTabPage_pasta.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_pasta.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(165, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "SubPasta Raiz das Músicas:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(143, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Pasta Raiz das Músicas:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(430, 80);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "&Buscar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton_savePata
            // 
            this.metroButton_savePata.Location = new System.Drawing.Point(591, 335);
            this.metroButton_savePata.Name = "metroButton_savePata";
            this.metroButton_savePata.Size = new System.Drawing.Size(75, 23);
            this.metroButton_savePata.TabIndex = 3;
            this.metroButton_savePata.Text = "&Salvar";
            this.metroButton_savePata.UseSelectable = true;
            this.metroButton_savePata.Click += new System.EventHandler(this.metroButton_savePata_Click);
            // 
            // metroTextBox_SubPasstaRaiz
            // 
            // 
            // 
            // 
            this.metroTextBox_SubPasstaRaiz.CustomButton.Image = null;
            this.metroTextBox_SubPasstaRaiz.CustomButton.Location = new System.Drawing.Point(399, 1);
            this.metroTextBox_SubPasstaRaiz.CustomButton.Name = "";
            this.metroTextBox_SubPasstaRaiz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_SubPasstaRaiz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_SubPasstaRaiz.CustomButton.TabIndex = 1;
            this.metroTextBox_SubPasstaRaiz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_SubPasstaRaiz.CustomButton.UseSelectable = true;
            this.metroTextBox_SubPasstaRaiz.CustomButton.Visible = false;
            this.metroTextBox_SubPasstaRaiz.Icon = global::HauxPlayList.Properties.Resources.AbriC;
            this.metroTextBox_SubPasstaRaiz.Lines = new string[0];
            this.metroTextBox_SubPasstaRaiz.Location = new System.Drawing.Point(3, 80);
            this.metroTextBox_SubPasstaRaiz.MaxLength = 32767;
            this.metroTextBox_SubPasstaRaiz.Name = "metroTextBox_SubPasstaRaiz";
            this.metroTextBox_SubPasstaRaiz.PasswordChar = '\0';
            this.metroTextBox_SubPasstaRaiz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_SubPasstaRaiz.SelectedText = "";
            this.metroTextBox_SubPasstaRaiz.SelectionLength = 0;
            this.metroTextBox_SubPasstaRaiz.SelectionStart = 0;
            this.metroTextBox_SubPasstaRaiz.ShortcutsEnabled = true;
            this.metroTextBox_SubPasstaRaiz.Size = new System.Drawing.Size(421, 23);
            this.metroTextBox_SubPasstaRaiz.TabIndex = 2;
            this.metroTextBox_SubPasstaRaiz.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_SubPasstaRaiz.UseSelectable = true;
            this.metroTextBox_SubPasstaRaiz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_SubPasstaRaiz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton_buscarPastaRaiz
            // 
            this.metroButton_buscarPastaRaiz.Location = new System.Drawing.Point(430, 32);
            this.metroButton_buscarPastaRaiz.Name = "metroButton_buscarPastaRaiz";
            this.metroButton_buscarPastaRaiz.Size = new System.Drawing.Size(75, 23);
            this.metroButton_buscarPastaRaiz.TabIndex = 3;
            this.metroButton_buscarPastaRaiz.Text = "&Buscar";
            this.metroButton_buscarPastaRaiz.UseSelectable = true;
            this.metroButton_buscarPastaRaiz.Click += new System.EventHandler(this.metroButton_buscarPastaRaiz_Click);
            // 
            // metroTextBox_PastaRaiz
            // 
            // 
            // 
            // 
            this.metroTextBox_PastaRaiz.CustomButton.Image = null;
            this.metroTextBox_PastaRaiz.CustomButton.Location = new System.Drawing.Point(399, 1);
            this.metroTextBox_PastaRaiz.CustomButton.Name = "";
            this.metroTextBox_PastaRaiz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_PastaRaiz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_PastaRaiz.CustomButton.TabIndex = 1;
            this.metroTextBox_PastaRaiz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_PastaRaiz.CustomButton.UseSelectable = true;
            this.metroTextBox_PastaRaiz.CustomButton.Visible = false;
            this.metroTextBox_PastaRaiz.Icon = global::HauxPlayList.Properties.Resources.AbriC;
            this.metroTextBox_PastaRaiz.Lines = new string[0];
            this.metroTextBox_PastaRaiz.Location = new System.Drawing.Point(3, 32);
            this.metroTextBox_PastaRaiz.MaxLength = 32767;
            this.metroTextBox_PastaRaiz.Name = "metroTextBox_PastaRaiz";
            this.metroTextBox_PastaRaiz.PasswordChar = '\0';
            this.metroTextBox_PastaRaiz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_PastaRaiz.SelectedText = "";
            this.metroTextBox_PastaRaiz.SelectionLength = 0;
            this.metroTextBox_PastaRaiz.SelectionStart = 0;
            this.metroTextBox_PastaRaiz.ShortcutsEnabled = true;
            this.metroTextBox_PastaRaiz.Size = new System.Drawing.Size(421, 23);
            this.metroTextBox_PastaRaiz.TabIndex = 2;
            this.metroTextBox_PastaRaiz.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_PastaRaiz.UseSelectable = true;
            this.metroTextBox_PastaRaiz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_PastaRaiz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(669, 361);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // form_configs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 483);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_configs";
            this.ShowInTaskbar = false;
            this.Text = "Configuração";
            this.Load += new System.EventHandler(this.form_configs_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage_pasta.ResumeLayout(false);
            this.metroTabPage_pasta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage_pasta;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton_buscarPastaRaiz;
        private MetroFramework.Controls.MetroTextBox metroTextBox_PastaRaiz;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButton_savePata;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_SubPasstaRaiz;
    }
}