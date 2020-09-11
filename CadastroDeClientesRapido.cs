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
    public partial class CadastroDeClientesRapido : Form
    {
        Usuario _usuario;
        public CadastroDeClientesRapido(string CNPJ,Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            TB_cnpj.Text = CNPJ;
        }



        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Bt_salvar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
           
            if (MessageBox.Show("voce tem certeza que deseja salvar este cliente?", "atencao", MessageBoxButtons.YesNo) == DialogResult.Yes){
                banco.AdicionarClientes(TB_cnpj.Text, TB_CodJfc.Text,_usuario);
            }

        }
    }
}
