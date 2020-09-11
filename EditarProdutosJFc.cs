using Renci.SshNet.Security;
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
    public partial class EditarProdutosJFc : Form
    {
        Usuario _usuario;
        public EditarProdutosJFc(string Codigo, string Descricao, string Kilagem,Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            Lb_codigo.Text = Codigo;
            Lb_Descricao.Text = Descricao;
            LB_Kilagem.Text = Kilagem;

        }

 

       
        private void BT_salvar_Click(object sender, EventArgs e)
        {
            if (TB_Codigo.Text.Length != 0 && TB_Descricao.Text.Length != 0 && TB_Kilagem.Text.Length != 0)
            {
                Banco banco = new Banco();
                if (banco.EditarProdutosJFc(TB_Codigo.Text, TB_Descricao.Text, TB_Kilagem.Text, Lb_codigo.Text, Lb_Descricao.Text, LB_Kilagem.Text,_usuario) == true)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Produto ja cadastrado, edite-o ou o exclua para fazer essa alteracao");
                }
            }
            else { MessageBox.Show("Todos os campos devem estar preenchidos!!"); }
        }

        private void TB_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TB_Kilagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != Convert.ToChar(","))
                    e.Handled = true;
            else if (e.KeyChar == Convert.ToChar(",") && TB_Kilagem.Text.Contains(","))
                    e.Handled = true;
            
        }

        private void TB_Kilagem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}