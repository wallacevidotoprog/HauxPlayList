using HauxPlayList.Forms.subForms;
using HauxPlayList.SAVE;
using Id3;
using Id3.Frames;
using NAudio.Wave;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace HauxPlayList
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        public bool iCreat = false;
        public bool iSave = false;
        public bool iUp = false;

        private AudioFileReader audioInfo;
        private Bitmap imgPlayList;
        private ImageList imageList;
        public bool FULL = false;
        private StreamReader reader;
        private XmlSerializer deserializer;
        public static Configs XmlDataConfigs { get; set; }
        public static preProcess PPS;

        public MainWindow()
        {
            InitializeComponent();
            imageList = new ImageList();
            imageList.Images.Add("F", Properties.Resources.folders);
            imageList.Images.Add("M", Properties.Resources._mp3);
            LoadGets();
            treeView_ListMusic.ImageList = imageList;
        }

        private void LoadGets()
        {

            reader = new StreamReader("configs.xml");

            deserializer = new XmlSerializer(typeof(Configs));
            object obj = deserializer.Deserialize(reader);
            XmlDataConfigs = (Configs)obj;
            reader.Close();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            treeView_ListMusic.Nodes.Clear();

            if (XmlDataConfigs!=null)
            {
                if (XmlDataConfigs.PastaBase != null)
                {
                    if (Directory.Exists(XmlDataConfigs.PastaBase))
                    {
                        LoadDirectory(XmlDataConfigs.PastaBase);
                    }
                    
                }
                
            }
            
        }

        private void metroButton_criarSalvar_Click(object sender, EventArgs e)
        {
           
            if (iCreat == false && iSave == false)
            {
                iCreat = true;
                iSave = true;
                metroGrid_playList.Rows.Clear();
                metroButton_criarSalvar.Text = "&Salvar";
                metroLabel_totalM.Text = "Total Músicas PlayList: 000";
                metroLabel_duracaoM.Text = "Duração da PlayList: 00:00:00";
                LoadAddPL(true);
            }
            else if (iCreat == true && iSave == true)
            {
                Selecionar selecionar = new Selecionar();
                selecionar.ShowDialog();
                bool finalizadoOk = false;
                Exception Err = null;
                if (selecionar.PSS != null)
                {
                    switch (selecionar.PSS)
                    {
                        case "100":
                            PPS = null;
                            PPS = new preProcess(metroTextBox_NamePL.Text, metroTextBox_DescPL.Text, pictureBox_FotoPlayList.Image, metroGrid_playList, 0, out  finalizadoOk, Err);
                            break;
                        case "010":
                            PPS = null;
                            PPS = new preProcess(metroTextBox_NamePL.Text, metroTextBox_DescPL.Text, pictureBox_FotoPlayList.Image, metroGrid_playList, 1, out  finalizadoOk, Err);
                            break;
                        case "001":
                            PPS = null;
                            PPS = new preProcess(metroTextBox_NamePL.Text, metroTextBox_DescPL.Text, pictureBox_FotoPlayList.Image, metroGrid_playList, 2, out  finalizadoOk, Err);
                            break;
                        default:
                            break;
                    }
                    
                    if (finalizadoOk)
                    {

                        metroGrid_playList.Rows.Clear();
                        iCreat = false; iSave = false;
                        metroButton_criarSalvar.Text = "&Criar";
                        LoadAddPL(false);
                    }
                    else
                    {
                        MessageBox.Show(Err.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }



                }

               
               
            }
           
            
        }

        private void treeView_ListMusic_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag.ToString().ToUpper().EndsWith("MP3"))
            {
                if (File.Exists(e.Node.Tag.ToString()))
                {
                    axWindowsMediaPlayer1.URL = e.Node.Tag.ToString();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }

            }
        }

        private void pictureBox_addFM_Click(object sender, EventArgs e)
        {
            if (iCreat||iUp)
            {
                if (treeView_ListMusic.SelectedNode.Tag.ToString().ToUpper().EndsWith("MP3"))
                {
                    var c =  treeView_ListMusic.SelectedNode.Tag.ToString();
                    audioInfo = new AudioFileReader(c);

                    string Duracao = audioInfo.TotalTime.Hours.ToString("00") + ":" + audioInfo.TotalTime.Minutes.ToString("00") + ":" + audioInfo.TotalTime.Seconds.ToString("00");

                    string Nome = treeView_ListMusic.SelectedNode.Text.Replace(Path.GetExtension(treeView_ListMusic.SelectedNode.Text), null);
                    metroGrid_playList.Rows.Add(new object[] { "", Nome, Duracao, c });
                    OrderByPlayList();

                }

            }
            else
            {
                MessageBox.Show("Mono criação ou edição inativo.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void OrderByPlayList()
        {
            var TimeTotal = new TimeSpan(0, 0, 0);
            for (int i = 0; i < metroGrid_playList.Rows.Count; i++)
            {
                metroGrid_playList.Rows[i].Cells[0].Value = (i+1).ToString("000");

                var TimeCont = new TimeSpan(
                    int.Parse(metroGrid_playList.Rows[i].Cells[2].Value.ToString().Split(':')[0].ToString()),
                    int.Parse(metroGrid_playList.Rows[i].Cells[2].Value.ToString().Split(':')[1].ToString()),
                    int.Parse(metroGrid_playList.Rows[i].Cells[2].Value.ToString().Split(':')[2].ToString())
                    );
                TimeTotal += TimeCont;


            }
            metroLabel_totalM.Text = $"Total Músicas PlayList: {metroGrid_playList.Rows.Count.ToString("000")}";
            metroLabel_duracaoM.Text = $"Duração da PlayList: {TimeTotal.ToString()}";

        }

        private void LoadAddPL(bool x)
        {
            if (x)
            {
                groupBox3.Visible = true;
                pictureBox_AddFoto.Visible = true;

                metroTextBox_NamePL.Enabled = true;
                metroTextBox_DescPL.Enabled = true;

                metroTextBox_NamePL.Text = "Nova PlayList";
                metroTextBox_DescPL.Text = "A Melhor PlayList";
            }
            else
            {
                groupBox3.Visible = false;
                pictureBox_AddFoto.Visible = false;

                metroTextBox_NamePL.Enabled = false;
                metroTextBox_DescPL.Enabled = false;

                metroTextBox_NamePL.Clear();
                metroTextBox_DescPL.Clear();
            }
            

        }

        private void pictureBox_AddFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                
                openFileDialog.Filter = "IMAGEM|*.jpg;*.jpeg;*.png;";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imgPlayList = new Bitmap(openFileDialog.FileName);
                    pictureBox_FotoPlayList.Image=imgPlayList;

                }
            }
        }


        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            TreeNode tds = treeView_ListMusic.Nodes.Add(di.Name.ToUpper());
            tds.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }
        private void LoadSubDirectories(string dir, TreeNode td)
        {           
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
           
            foreach (string subdirectory in subdirectoryEntries)
            {

                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(null,di.Name.ToUpper(), "F");
                tds.StateImageIndex = 0;
                tds.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
                

            }
        }
        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");
                       
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(null,fi.Name,"M");
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
                

            }
        }

        private void treeView_ListMusic_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode Node = e.Node;
            Node.SelectedImageKey = Node.ImageKey;
        }



        #region GridDrag
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        

        private void metroGrid_playList_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = metroGrid_playList.DoDragDrop(
                    metroGrid_playList.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void metroGrid_playList_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = metroGrid_playList.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
            {
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
            }

            if (metroGrid_playList.SelectedRows.Count==1)
            {
                try
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = metroGrid_playList.HitTest(e.X, e.Y);
                        metroGrid_playList.ClearSelection();
                        metroGrid_playList.Rows[hti.RowIndex].Selected = true;


                    }
                }
                catch (Exception)
                {


                }
            }
            

        }

        private void metroGrid_playList_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void metroGrid_playList_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = metroGrid_playList.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                metroGrid_playList.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;
                metroGrid_playList.Rows.RemoveAt(rowIndexFromMouseDown);
                metroGrid_playList.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);

            }
            OrderByPlayList();
        }
        #endregion

        private void dELETARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar essa música da PlayList ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedRows = metroGrid_playList.SelectedRows
                 .OfType<DataGridViewRow>()
                 .Where(row => !row.IsNewRow)
                 .ToArray();

                foreach (var row in selectedRows)
                    metroGrid_playList.Rows.Remove(row);

                metroGrid_playList.ClearSelection();

                OrderByPlayList();
            }
        }

        private void pictureBox_fullTree_Click(object sender, EventArgs e)
        {
           
           
            if (FULL)
            {
                treeView_ListMusic.CollapseAll();
                FULL = false;
            }
            else
            {
                treeView_ListMusic.ExpandAll();
                FULL = true;
            }
        }

        private void tOCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < metroGrid_playList.SelectedRows.Count; i++)
            //{
                string caminhos = metroGrid_playList.Rows[metroGrid_playList.SelectedRows[0].Index].Cells[metroGrid_playList.ColumnCount - 1].Value.ToString();
                if (File.Exists(caminhos))
                {
                    axWindowsMediaPlayer1.URL = caminhos;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            //}
            
        }

        private void toolStripButton_configs_Click(object sender, EventArgs e)
        {
            (new Forms.form_configs()).ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var tfile = TagLib.File.Create(@"C:\Users\LOFT261\Desktop\Nova pasta\musica.mp3");

            //tfile.Tag.Pictures = TagLib.File.Create(@"C:\My picture.jpg");


            tfile.Tag.Title = "NANO";


            tfile.Save();
        }
    }



}
