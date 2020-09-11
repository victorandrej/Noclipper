using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoClipper
{
    public partial class Locais : Form
    {
        public Locais()
        {
            InitializeComponent();
        }
        public string LocalDoTxt { get; set; }

        public string LocalDosxmls { get; set; }


        private void Locais_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Caminhoxml_Click(object sender, EventArgs e)
        {
            if (FB_CaminhoXml.ShowDialog() == DialogResult.OK)
            {
                Tb_CaminhoXml.Text = FB_CaminhoXml.SelectedPath;
            }

        }

        private void BT_Caminhotxt_Click(object sender, EventArgs e)
        {
        }

        private void Bt_Ok_Click(object sender, EventArgs e)
        {
            if (Tb_CaminhoXml.Text != "" )
            {
                
                LocalDosxmls = Tb_CaminhoXml.Text;
                DialogResult = DialogResult.OK;


            }
        }
    }
}
