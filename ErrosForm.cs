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
    public partial class ErrosForm : Form
    {
        public ErrosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.adicionar();
            
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
