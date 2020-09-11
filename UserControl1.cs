using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoClipper
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void adicionar() {
            TextBox textBox = new TextBox();
            textBox.Width = this.ClientSize.Width;
            textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;            

            int ultimaposicao = 0;

            if (Controls.Count > 0) {
                ultimaposicao = Controls[Controls.Count - 1].Location.Y + Controls[Controls.Count - 1].Height + 5;
            }
            textBox.Location = new Point(0, ultimaposicao);
            this.Controls.Add(textBox);

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {

        }
    }
}
