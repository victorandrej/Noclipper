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
    public partial class CadastroDeBancoDeDados : Form
    {
        public CadastroDeBancoDeDados()
        {
            InitializeComponent();
            Servidor servidor = new Servidor();
            TB_Endereco.Text = servidor.Endereco;
            TB_Porta.Text = servidor.PortaServidor;
            TB_Usuario.Text = servidor.Usuario;
            TB_NomeDoBanco.Text = servidor.BancoDeDados;
        }

        private void BT_limpar_Click(object sender, EventArgs e)
        {
            TB_Endereco.Text = "";
            TB_Porta.Text = "";
            TB_Usuario.Text = "";
            TB_NomeDoBanco.Text = "";
        }

        private void BT_salvar_Click(object sender, EventArgs e)
        {

            Banco banco = new Banco();
            if (TB_NomeDoBanco.Text.Length != 0 && TB_Usuario.Text.Length != 0 && TB_Endereco.Text.Length != 0 && TB_Porta.Text.Length != 0 && TB_Senha.Text.Length != 0)
            {
                Properties.Settings.Default.EnderecoServidor = TB_Endereco.Text;
                Properties.Settings.Default.PortaServidor = TB_Porta.Text;
                Properties.Settings.Default.UsuarioServidor = TB_Usuario.Text;
                Properties.Settings.Default.BancoDeDados = TB_NomeDoBanco.Text;
                Properties.Settings.Default.SenhaServidor = TB_Senha.Text;


                try
                {
                    banco.TestarConexao();
                    Properties.Settings.Default.Save();
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("ERRO DE CONEXAO, REVISE SEUS DADOS", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show("TODOS OS CAMPOS DEVEM ESTAR PREENCHIDOS", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
