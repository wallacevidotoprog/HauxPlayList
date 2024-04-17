namespace HauxPlayList
{
    partial class MainWindow
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nó1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nó0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nó0", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nó1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nó2");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip_Menu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_configs = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage_pasta = new MetroFramework.Controls.MetroTabPage();
            this.treeView_ListMusic = new System.Windows.Forms.TreeView();
            this.metroTabPage_XML = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage_mwv = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox_fullTree = new System.Windows.Forms.PictureBox();
            this.pictureBox_addFM = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl_mane = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage_createPL = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroGrid_playList = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_girdPL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tOCARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dELETARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel_totalM = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_duracaoM = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_DescPL = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_NamePL = new MetroFramework.Controls.MetroTextBox();
            this.metroButton_criarSalvar = new MetroFramework.Controls.MetroButton();
            this.pictureBox_FotoPlayList = new System.Windows.Forms.PictureBox();
            this.pictureBox_AddFoto = new System.Windows.Forms.PictureBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage_pasta.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fullTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_addFM)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl_mane.SuspendLayout();
            this.metroTabPage_createPL.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_playList)).BeginInit();
            this.contextMenuStrip_girdPL.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FotoPlayList)).BeginInit();
            this.pictureBox_FotoPlayList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AddFoto)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip_Menu
            // 
            this.toolStrip_Menu.AllowItemReorder = true;
            this.toolStrip_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.toolStrip_Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_configs,
            this.toolStripButton1});
            this.toolStrip_Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip_Menu.Location = new System.Drawing.Point(20, 60);
            this.toolStrip_Menu.Name = "toolStrip_Menu";
            this.toolStrip_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip_Menu.ShowItemToolTips = false;
            this.toolStrip_Menu.Size = new System.Drawing.Size(1171, 39);
            this.toolStrip_Menu.TabIndex = 0;
            this.toolStrip_Menu.Text = "toolStrip1";
            // 
            // toolStripButton_configs
            // 
            this.toolStripButton_configs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_configs.Image = global::HauxPlayList.Properties.Resources.icons8_ferramentas_administrativas_48;
            this.toolStripButton_configs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_configs.Name = "toolStripButton_configs";
            this.toolStripButton_configs.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton_configs.Text = "toolStripButton1";
            this.toolStripButton_configs.ToolTipText = "Configurações";
            this.toolStripButton_configs.Click += new System.EventHandler(this.toolStripButton_configs_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 99);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroTabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.metroPanel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.metroPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1171, 531);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 1;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage_pasta);
            this.metroTabControl1.Controls.Add(this.metroTabPage_XML);
            this.metroTabControl1.Controls.Add(this.metroTabPage_mwv);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(206, 492);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage_pasta
            // 
            this.metroTabPage_pasta.BackColor = System.Drawing.Color.Black;
            this.metroTabPage_pasta.Controls.Add(this.treeView_ListMusic);
            this.metroTabPage_pasta.HorizontalScrollbarBarColor = true;
            this.metroTabPage_pasta.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_pasta.HorizontalScrollbarSize = 10;
            this.metroTabPage_pasta.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage_pasta.Name = "metroTabPage_pasta";
            this.metroTabPage_pasta.Size = new System.Drawing.Size(198, 444);
            this.metroTabPage_pasta.TabIndex = 0;
            this.metroTabPage_pasta.Text = "PASTA";
            this.metroTabPage_pasta.VerticalScrollbarBarColor = true;
            this.metroTabPage_pasta.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_pasta.VerticalScrollbarSize = 10;
            // 
            // treeView_ListMusic
            // 
            this.treeView_ListMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_ListMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView_ListMusic.HideSelection = false;
            this.treeView_ListMusic.ItemHeight = 20;
            this.treeView_ListMusic.LineColor = System.Drawing.Color.DarkGreen;
            this.treeView_ListMusic.Location = new System.Drawing.Point(3, 3);
            this.treeView_ListMusic.Name = "treeView_ListMusic";
            treeNode1.Name = "Nó1";
            treeNode1.Text = "Nó1";
            treeNode2.Name = "Nó0";
            treeNode2.Text = "Nó0";
            treeNode3.Name = "Nó0";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode3.Text = "Nó0";
            treeNode4.Name = "Nó1";
            treeNode4.Text = "Nó1";
            treeNode5.Name = "Nó2";
            treeNode5.Text = "Nó2";
            this.treeView_ListMusic.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeView_ListMusic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView_ListMusic.Size = new System.Drawing.Size(192, 438);
            this.treeView_ListMusic.TabIndex = 0;
            this.treeView_ListMusic.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_ListMusic_AfterSelect);
            this.treeView_ListMusic.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_ListMusic_NodeMouseDoubleClick);
            // 
            // metroTabPage_XML
            // 
            this.metroTabPage_XML.HorizontalScrollbarBarColor = true;
            this.metroTabPage_XML.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_XML.HorizontalScrollbarSize = 10;
            this.metroTabPage_XML.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage_XML.Name = "metroTabPage_XML";
            this.metroTabPage_XML.Size = new System.Drawing.Size(198, 444);
            this.metroTabPage_XML.TabIndex = 1;
            this.metroTabPage_XML.Text = "XML";
            this.metroTabPage_XML.VerticalScrollbarBarColor = true;
            this.metroTabPage_XML.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_XML.VerticalScrollbarSize = 10;
            // 
            // metroTabPage_mwv
            // 
            this.metroTabPage_mwv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTabPage_mwv.HorizontalScrollbarBarColor = true;
            this.metroTabPage_mwv.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_mwv.HorizontalScrollbarSize = 10;
            this.metroTabPage_mwv.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage_mwv.Name = "metroTabPage_mwv";
            this.metroTabPage_mwv.Size = new System.Drawing.Size(198, 444);
            this.metroTabPage_mwv.TabIndex = 2;
            this.metroTabPage_mwv.Text = "MWV";
            this.metroTabPage_mwv.VerticalScrollbarBarColor = true;
            this.metroTabPage_mwv.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_mwv.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.pictureBox_fullTree);
            this.metroPanel3.Controls.Add(this.pictureBox_addFM);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 492);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(206, 39);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // pictureBox_fullTree
            // 
            this.pictureBox_fullTree.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_fullTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_fullTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_fullTree.Image = global::HauxPlayList.Properties.Resources.icons8_árvore_de_pastas_48;
            this.pictureBox_fullTree.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_fullTree.Name = "pictureBox_fullTree";
            this.pictureBox_fullTree.Size = new System.Drawing.Size(39, 39);
            this.pictureBox_fullTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_fullTree.TabIndex = 3;
            this.pictureBox_fullTree.TabStop = false;
            this.pictureBox_fullTree.Click += new System.EventHandler(this.pictureBox_fullTree_Click);
            // 
            // pictureBox_addFM
            // 
            this.pictureBox_addFM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_addFM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_addFM.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_addFM.Image = global::HauxPlayList.Properties.Resources.addM;
            this.pictureBox_addFM.Location = new System.Drawing.Point(167, 0);
            this.pictureBox_addFM.Name = "pictureBox_addFM";
            this.pictureBox_addFM.Size = new System.Drawing.Size(39, 39);
            this.pictureBox_addFM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_addFM.TabIndex = 2;
            this.pictureBox_addFM.TabStop = false;
            this.pictureBox_addFM.Click += new System.EventHandler(this.pictureBox_addFM_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTabControl_mane);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(961, 531);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTabControl_mane
            // 
            this.metroTabControl_mane.Controls.Add(this.metroTabPage_createPL);
            this.metroTabControl_mane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl_mane.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl_mane.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl_mane.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl_mane.Name = "metroTabControl_mane";
            this.metroTabControl_mane.SelectedIndex = 0;
            this.metroTabControl_mane.Size = new System.Drawing.Size(961, 455);
            this.metroTabControl_mane.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl_mane.TabIndex = 3;
            this.metroTabControl_mane.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl_mane.UseSelectable = true;
            // 
            // metroTabPage_createPL
            // 
            this.metroTabPage_createPL.BackColor = System.Drawing.Color.Black;
            this.metroTabPage_createPL.Controls.Add(this.groupBox2);
            this.metroTabPage_createPL.Controls.Add(this.groupBox1);
            this.metroTabPage_createPL.HorizontalScrollbarBarColor = true;
            this.metroTabPage_createPL.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_createPL.HorizontalScrollbarSize = 10;
            this.metroTabPage_createPL.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage_createPL.Name = "metroTabPage_createPL";
            this.metroTabPage_createPL.Size = new System.Drawing.Size(953, 407);
            this.metroTabPage_createPL.TabIndex = 0;
            this.metroTabPage_createPL.Text = "Criar PlayList";
            this.metroTabPage_createPL.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage_createPL.VerticalScrollbarBarColor = true;
            this.metroTabPage_createPL.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_createPL.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.metroGrid_playList);
            this.groupBox2.Location = new System.Drawing.Point(3, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(947, 252);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aquivos";
            // 
            // metroGrid_playList
            // 
            this.metroGrid_playList.AllowDrop = true;
            this.metroGrid_playList.AllowUserToAddRows = false;
            this.metroGrid_playList.AllowUserToDeleteRows = false;
            this.metroGrid_playList.AllowUserToResizeColumns = false;
            this.metroGrid_playList.AllowUserToResizeRows = false;
            this.metroGrid_playList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid_playList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid_playList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_playList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_playList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_playList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid_playList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid_playList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.file});
            this.metroGrid_playList.ContextMenuStrip = this.contextMenuStrip_girdPL;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_playList.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid_playList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid_playList.EnableHeadersVisualStyles = false;
            this.metroGrid_playList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_playList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid_playList.Location = new System.Drawing.Point(3, 16);
            this.metroGrid_playList.Name = "metroGrid_playList";
            this.metroGrid_playList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_playList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid_playList.RowHeadersVisible = false;
            this.metroGrid_playList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_playList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGrid_playList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_playList.Size = new System.Drawing.Size(941, 233);
            this.metroGrid_playList.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGrid_playList.TabIndex = 0;
            this.metroGrid_playList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid_playList.DragDrop += new System.Windows.Forms.DragEventHandler(this.metroGrid_playList_DragDrop);
            this.metroGrid_playList.DragOver += new System.Windows.Forms.DragEventHandler(this.metroGrid_playList_DragOver);
            this.metroGrid_playList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroGrid_playList_MouseDown);
            this.metroGrid_playList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroGrid_playList_MouseMove);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 5F;
            this.Column1.HeaderText = "N°";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 20F;
            this.Column3.HeaderText = "Duração";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // file
            // 
            this.file.DataPropertyName = "file";
            this.file.HeaderText = "file";
            this.file.Name = "file";
            this.file.ReadOnly = true;
            this.file.Visible = false;
            // 
            // contextMenuStrip_girdPL
            // 
            this.contextMenuStrip_girdPL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tOCARToolStripMenuItem,
            this.toolStripSeparator1,
            this.dELETARToolStripMenuItem});
            this.contextMenuStrip_girdPL.Name = "contextMenuStrip_girdPL";
            this.contextMenuStrip_girdPL.Size = new System.Drawing.Size(121, 54);
            // 
            // tOCARToolStripMenuItem
            // 
            this.tOCARToolStripMenuItem.Image = global::HauxPlayList.Properties.Resources.exec;
            this.tOCARToolStripMenuItem.Name = "tOCARToolStripMenuItem";
            this.tOCARToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.tOCARToolStripMenuItem.Text = "TOCAR";
            this.tOCARToolStripMenuItem.Click += new System.EventHandler(this.tOCARToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // dELETARToolStripMenuItem
            // 
            this.dELETARToolStripMenuItem.Image = global::HauxPlayList.Properties.Resources.icons8_fechar_janela_48;
            this.dELETARToolStripMenuItem.Name = "dELETARToolStripMenuItem";
            this.dELETARToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.dELETARToolStripMenuItem.Text = "DELETAR";
            this.dELETARToolStripMenuItem.Click += new System.EventHandler(this.dELETARToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroTextBox_DescPL);
            this.groupBox1.Controls.Add(this.metroTextBox_NamePL);
            this.groupBox1.Controls.Add(this.metroButton_criarSalvar);
            this.groupBox1.Controls.Add(this.pictureBox_FotoPlayList);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerenciamento";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.metroLabel_totalM);
            this.groupBox3.Controls.Add(this.metroLabel_duracaoM);
            this.groupBox3.Location = new System.Drawing.Point(723, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 66);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações";
            this.groupBox3.Visible = false;
            // 
            // metroLabel_totalM
            // 
            this.metroLabel_totalM.AutoSize = true;
            this.metroLabel_totalM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroLabel_totalM.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel_totalM.ForeColor = System.Drawing.Color.Green;
            this.metroLabel_totalM.Location = new System.Drawing.Point(17, 21);
            this.metroLabel_totalM.Name = "metroLabel_totalM";
            this.metroLabel_totalM.Size = new System.Drawing.Size(185, 19);
            this.metroLabel_totalM.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel_totalM.TabIndex = 3;
            this.metroLabel_totalM.Text = "Total Músicas PlayList: 000";
            this.metroLabel_totalM.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel_totalM.UseCustomForeColor = true;
            // 
            // metroLabel_duracaoM
            // 
            this.metroLabel_duracaoM.AutoSize = true;
            this.metroLabel_duracaoM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroLabel_duracaoM.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel_duracaoM.ForeColor = System.Drawing.Color.Green;
            this.metroLabel_duracaoM.Location = new System.Drawing.Point(7, 40);
            this.metroLabel_duracaoM.Name = "metroLabel_duracaoM";
            this.metroLabel_duracaoM.Size = new System.Drawing.Size(205, 19);
            this.metroLabel_duracaoM.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel_duracaoM.TabIndex = 3;
            this.metroLabel_duracaoM.Text = "Duração da PlayList: 00:00:00";
            this.metroLabel_duracaoM.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel_duracaoM.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(142, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Descrição:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(142, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Titulo da PlayList:";
            // 
            // metroTextBox_DescPL
            // 
            // 
            // 
            // 
            this.metroTextBox_DescPL.CustomButton.Image = null;
            this.metroTextBox_DescPL.CustomButton.Location = new System.Drawing.Point(229, 2);
            this.metroTextBox_DescPL.CustomButton.Name = "";
            this.metroTextBox_DescPL.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.metroTextBox_DescPL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_DescPL.CustomButton.TabIndex = 1;
            this.metroTextBox_DescPL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_DescPL.CustomButton.UseSelectable = true;
            this.metroTextBox_DescPL.CustomButton.Visible = false;
            this.metroTextBox_DescPL.Enabled = false;
            this.metroTextBox_DescPL.Lines = new string[0];
            this.metroTextBox_DescPL.Location = new System.Drawing.Point(142, 86);
            this.metroTextBox_DescPL.MaxLength = 32767;
            this.metroTextBox_DescPL.Multiline = true;
            this.metroTextBox_DescPL.Name = "metroTextBox_DescPL";
            this.metroTextBox_DescPL.PasswordChar = '\0';
            this.metroTextBox_DescPL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_DescPL.SelectedText = "";
            this.metroTextBox_DescPL.SelectionLength = 0;
            this.metroTextBox_DescPL.SelectionStart = 0;
            this.metroTextBox_DescPL.ShortcutsEnabled = true;
            this.metroTextBox_DescPL.Size = new System.Drawing.Size(287, 60);
            this.metroTextBox_DescPL.TabIndex = 2;
            this.metroTextBox_DescPL.UseSelectable = true;
            this.metroTextBox_DescPL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_DescPL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox_NamePL
            // 
            // 
            // 
            // 
            this.metroTextBox_NamePL.CustomButton.Image = null;
            this.metroTextBox_NamePL.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.metroTextBox_NamePL.CustomButton.Name = "";
            this.metroTextBox_NamePL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_NamePL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_NamePL.CustomButton.TabIndex = 1;
            this.metroTextBox_NamePL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_NamePL.CustomButton.UseSelectable = true;
            this.metroTextBox_NamePL.CustomButton.Visible = false;
            this.metroTextBox_NamePL.Enabled = false;
            this.metroTextBox_NamePL.Lines = new string[0];
            this.metroTextBox_NamePL.Location = new System.Drawing.Point(142, 38);
            this.metroTextBox_NamePL.MaxLength = 32767;
            this.metroTextBox_NamePL.Name = "metroTextBox_NamePL";
            this.metroTextBox_NamePL.PasswordChar = '\0';
            this.metroTextBox_NamePL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_NamePL.SelectedText = "";
            this.metroTextBox_NamePL.SelectionLength = 0;
            this.metroTextBox_NamePL.SelectionStart = 0;
            this.metroTextBox_NamePL.ShortcutsEnabled = true;
            this.metroTextBox_NamePL.Size = new System.Drawing.Size(287, 23);
            this.metroTextBox_NamePL.TabIndex = 2;
            this.metroTextBox_NamePL.UseSelectable = true;
            this.metroTextBox_NamePL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_NamePL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton_criarSalvar
            // 
            this.metroButton_criarSalvar.Location = new System.Drawing.Point(435, 123);
            this.metroButton_criarSalvar.Name = "metroButton_criarSalvar";
            this.metroButton_criarSalvar.Size = new System.Drawing.Size(75, 23);
            this.metroButton_criarSalvar.TabIndex = 1;
            this.metroButton_criarSalvar.Text = "&Criar";
            this.metroButton_criarSalvar.UseSelectable = true;
            this.metroButton_criarSalvar.Click += new System.EventHandler(this.metroButton_criarSalvar_Click);
            // 
            // pictureBox_FotoPlayList
            // 
            this.pictureBox_FotoPlayList.BackColor = System.Drawing.Color.Black;
            this.pictureBox_FotoPlayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_FotoPlayList.Controls.Add(this.pictureBox_AddFoto);
            this.pictureBox_FotoPlayList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_FotoPlayList.Image = global::HauxPlayList.Properties.Resources.Simage;
            this.pictureBox_FotoPlayList.Location = new System.Drawing.Point(3, 16);
            this.pictureBox_FotoPlayList.Name = "pictureBox_FotoPlayList";
            this.pictureBox_FotoPlayList.Size = new System.Drawing.Size(133, 133);
            this.pictureBox_FotoPlayList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_FotoPlayList.TabIndex = 0;
            this.pictureBox_FotoPlayList.TabStop = false;
            // 
            // pictureBox_AddFoto
            // 
            this.pictureBox_AddFoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_AddFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_AddFoto.Image = global::HauxPlayList.Properties.Resources.addIMG;
            this.pictureBox_AddFoto.Location = new System.Drawing.Point(97, 98);
            this.pictureBox_AddFoto.Name = "pictureBox_AddFoto";
            this.pictureBox_AddFoto.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_AddFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_AddFoto.TabIndex = 5;
            this.pictureBox_AddFoto.TabStop = false;
            this.pictureBox_AddFoto.Visible = false;
            this.pictureBox_AddFoto.Click += new System.EventHandler(this.pictureBox_AddFoto_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 455);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(961, 76);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(961, 76);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.UseWaitCursor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1211, 650);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip_Menu);
            this.Name = "MainWindow";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Main";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.toolStrip_Menu.ResumeLayout(false);
            this.toolStrip_Menu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage_pasta.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fullTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_addFM)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroTabControl_mane.ResumeLayout(false);
            this.metroTabPage_createPL.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_playList)).EndInit();
            this.contextMenuStrip_girdPL.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FotoPlayList)).EndInit();
            this.pictureBox_FotoPlayList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AddFoto)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_Menu;
        private System.Windows.Forms.ToolStripButton toolStripButton_configs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TreeView treeView_ListMusic;
        private MetroFramework.Controls.MetroTabControl metroTabControl_mane;
        private MetroFramework.Controls.MetroTabPage metroTabPage_createPL;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_DescPL;
        private MetroFramework.Controls.MetroTextBox metroTextBox_NamePL;
        private MetroFramework.Controls.MetroButton metroButton_criarSalvar;
        private System.Windows.Forms.PictureBox pictureBox_FotoPlayList;
        private MetroFramework.Controls.MetroGrid metroGrid_playList;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.PictureBox pictureBox_addFM;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel_totalM;
        private MetroFramework.Controls.MetroLabel metroLabel_duracaoM;
        private System.Windows.Forms.PictureBox pictureBox_fullTree;
        private System.Windows.Forms.PictureBox pictureBox_AddFoto;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_girdPL;
        private System.Windows.Forms.ToolStripMenuItem dELETARToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn file;
        private System.Windows.Forms.ToolStripMenuItem tOCARToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage_pasta;
        private MetroFramework.Controls.MetroTabPage metroTabPage_XML;
        private MetroFramework.Controls.MetroTabPage metroTabPage_mwv;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

