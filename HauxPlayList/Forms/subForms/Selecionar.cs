using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HauxPlayList.Forms.subForms
{
    public partial class Selecionar :  MetroFramework.Forms.MetroForm
    {
        public Selecionar()
        {
            InitializeComponent();
        }
        public string PSS { get; set; }

        private void pictureBox_Pasta_Click(object sender, EventArgs e)
        {
            PSS = "100";
            Close();
        }

        private void pictureBox_XML_Click(object sender, EventArgs e)
        {
            PSS = "010";
            Close();
        }

        private void pictureBox_BIN_Click(object sender, EventArgs e)
        {
            PSS = "001";
            Close();
        }
    }
}
