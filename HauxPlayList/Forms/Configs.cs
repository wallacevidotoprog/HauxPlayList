using HauxPlayList.SAVE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HauxPlayList.Forms
{
    public partial class form_configs : MetroFramework.Forms.MetroForm
    {
        private StreamReader reader;
        private XmlSerializer deserializer;
        public Configs XmlDataConfigs { get; private set; }

        public form_configs()
        {
            InitializeComponent();
            reader = new StreamReader("configs.xml");
            deserializer = new XmlSerializer(typeof(Configs));
            object obj = deserializer.Deserialize(reader);
            XmlDataConfigs = (Configs)obj;
            reader.Close();
        }

        private void form_configs_Load(object sender, EventArgs e)
        {
            metroTextBox_PastaRaiz.Text = XmlDataConfigs.PastaBase?.ToString();
            metroTextBox_SubPasstaRaiz.Text = XmlDataConfigs.SubPastaBase?.ToString();
        }

        #region Pasta
        private void metroButton_buscarPastaRaiz_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    metroTextBox_PastaRaiz.Text = fbd.SelectedPath;
                    XmlDataConfigs.PastaBase = fbd.SelectedPath;
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    metroTextBox_SubPasstaRaiz.Text = fbd.SelectedPath;
                    XmlDataConfigs.SubPastaBase = fbd.SelectedPath;
                }
            }
        }

        private void metroButton_savePata_Click(object sender, EventArgs e)
        {
            using (var writer = new StringWriter())
            {
                new XmlSerializer(XmlDataConfigs.GetType()).Serialize(writer, XmlDataConfigs);
                File.Delete("configs.xml");
                StreamWriter sw = new StreamWriter("configs.xml", true, Encoding.UTF8);
                sw.Write(writer.ToString());
                sw.Close();
            }

        }
        #endregion

    }
}
