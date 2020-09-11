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
    public partial class AlterarSenha : Form
    {
        Usuario _usuario;
        public AlterarSenha(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
        }

        private void BT_salvarSenha_Click(object sender, EventArgs e)
        {
            if (TB_senhaAntiga.Text == _usuario.Senha && TB_senhaNova.Text != "")
            {
                Usuario usuario = new Usuario();
                usuario.Senha = TB_senhaNova.Text;
                usuario.Nome = _usuario.Nome;
                Banco banco = new Banco();
                banco.AlterarSenha(usuario);
                TB_senhaAntiga.Text = "";
                TB_senhaNova.Text = "";
                MessageBox.Show("Senha alterada com sucesso", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (TB_senhaNova.Text == "")
            {
                MessageBox.Show("Senha nova não pode estar vazia", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Senha antiga incorreta", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlterarSenha_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
