namespace HauxPlayList.Forms.subForms
{
    partial class Selecionar
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox_Pasta = new System.Windows.Forms.PictureBox();
            this.pictureBox_XML = new System.Windows.Forms.PictureBox();
            this.pictureBox_BIN = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_XML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BIN)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox_Pasta);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox_XML);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox_BIN);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(633, 200);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox_Pasta
            // 
            this.pictureBox_Pasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Pasta.Image = global::HauxPlayList.Properties.Resources.pasta;
            this.pictureBox_Pasta.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Pasta.Name = "pictureBox_Pasta";
            this.pictureBox_Pasta.Size = new System.Drawing.Size(204, 194);
            this.pictureBox_Pasta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Pasta.TabIndex = 0;
            this.pictureBox_Pasta.TabStop = false;
            this.pictureBox_Pasta.Click += new System.EventHandler(this.pictureBox_Pasta_Click);
            // 
            // pictureBox_XML
            // 
            this.pictureBox_XML.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox_XML.Enabled = false;
            this.pictureBox_XML.Image = global::HauxPlayList.Properties.Resources.XML;
            this.pictureBox_XML.Location = new System.Drawing.Point(213, 3);
            this.pictureBox_XML.Name = "pictureBox_XML";
            this.pictureBox_XML.Size = new System.Drawing.Size(204, 194);
            this.pictureBox_XML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_XML.TabIndex = 1;
            this.pictureBox_XML.TabStop = false;
            this.pictureBox_XML.Click += new System.EventHandler(this.pictureBox_XML_Click);
            // 
            // pictureBox_BIN
            // 
            this.pictureBox_BIN.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox_BIN.Enabled = false;
            this.pictureBox_BIN.Image = global::HauxPlayList.Properties.Resources.icons8_binary_60;
            this.pictureBox_BIN.Location = new System.Drawing.Point(423, 3);
            this.pictureBox_BIN.Name = "pictureBox_BIN";
            this.pictureBox_BIN.Size = new System.Drawing.Size(204, 194);
            this.pictureBox_BIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_BIN.TabIndex = 2;
            this.pictureBox_BIN.TabStop = false;
            this.pictureBox_BIN.Click += new System.EventHandler(this.pictureBox_BIN_Click);
            // 
            // Selecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 280);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Selecionar";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Selecionar";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_XML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BIN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox_Pasta;
        private System.Windows.Forms.PictureBox pictureBox_XML;
        private System.Windows.Forms.PictureBox pictureBox_BIN;
    }
}