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
    public partial class Login : Form
    {
        public Usuario usuario;
        public Login()
        {
            InitializeComponent();
        }

        private void BtLogar_Click(object sender, EventArgs e)
        {
            Banco Banco = new Banco();
            Usuario usuariobanco = new Usuario();
            usuariobanco = Banco.Usuario(TxbUsuario.Text);

            if (usuariobanco.Senha == TxbSenha.Text)
            {
                usuario = usuariobanco;
                DialogResult = DialogResult.Yes;

            }
            else {
                MessageBox.Show("Usuario ou senha incorretos", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

