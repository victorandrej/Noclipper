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
    public partial class CadastroUsuarios : Form
    {
        private List<Usuario> _usuarios;
        private Usuario _usuarioatual;
        private bool editar = false;
        public CadastroUsuarios(Usuario usuario)
        {
            _usuarioatual = usuario;
            InitializeComponent();
            Banco banco = new Banco();
            _usuarios = banco.Usuario();
            AdicionarUsuariosAoListBOx(_usuarios);
        }
        private void AdicionarUsuariosAoListBOx(List<Usuario> usuarios)
        {
            LB_usuarios.Items.Clear();
            foreach (Usuario usuario in usuarios)
            {
                if (!usuario.root)
                    LB_usuarios.Items.Add(usuario.Nome);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                if (TB_usuario.Text.Length != 0 && TB_senha.Text.Length != 0)
                {
                    Usuario usuario = new Usuario();
                    usuario.CadastrarClientes = CB_CadastrarClientes.Checked;
                    usuario.CadastrarProdutosJfc = CB_CadastrarProdutosJfc.Checked;
                    usuario.CadastrarProdutosMatriz = CB_CadastrarprodutosMatriz.Checked;
                    usuario.CadastroClienteRapido = CB_CadastroClienteRapido.Checked;
                    usuario.CriarUsuarios = CB_CriarUsuarios.Checked;
                    usuario.ExportarArquivos = CB_ExportarArquivos.Checked;
                    usuario.Nome = TB_usuario.Text;
                    usuario.Senha = TB_senha.Text;
                    if (LB_usuarios.Items.Contains(usuario.Nome))
                    {
                        MessageBox.Show("Usuario Ja existente", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Banco banco = new Banco();
                        banco.Adicionarusuario(usuario,_usuarioatual);
                        MessageBox.Show("USUARIO Adicionado Com sucesso", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bt_Salvar.Text = "Salvar";
                        TB_usuario.Text = "";
                        TB_usuario.Enabled = true;
                        CB_CadastrarClientes.Checked = false;
                        CB_CadastrarProdutosJfc.Checked = false;
                        CB_CadastrarprodutosMatriz.Checked = false;
                        CB_CadastroClienteRapido.Checked = false;
                        CB_CriarUsuarios.Checked = false;
                        CB_ExportarArquivos.Checked = false;
                        TB_senha.Text = "";
                        _usuarios = banco.Usuario();
                        AdicionarUsuariosAoListBOx(_usuarios);
                    }
                }
                else
                {
                    MessageBox.Show("Senha ou usuario não definidos", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BT_apagar.Visible = true;
                bt_Salvar.Text = "Salvar";
                TB_usuario.Text = "";
                TB_usuario.Enabled = true;
                CB_CadastrarClientes.Checked = false;
                CB_CadastrarProdutosJfc.Checked = false;
                CB_CadastrarprodutosMatriz.Checked = false;
                CB_CadastroClienteRapido.Checked = false;
                CB_CriarUsuarios.Checked = false;
                CB_ExportarArquivos.Checked = false;
                editar = false;
            }
        }

        private void BT_apagar_Click(object sender, EventArgs e)
        {
            
            if (!LB_usuarios.Items.Contains(_usuarioatual.Nome))
            {
                Banco banco = new Banco();
                if (LB_usuarios.SelectedItem?.ToString() != "" && LB_usuarios.SelectedItem != null)
                {
                    banco.ApagarUsuario(LB_usuarios.SelectedItem?.ToString(),_usuarioatual);
                    LB_usuarios.Items.Remove(LB_usuarios.SelectedItem);
                    MessageBox.Show("USUARIO EXCLUIDO COM SUCESSO", "ATENCAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Não e possivel se apagar", "ATENCAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }


        private void BT_editar_Click(object sender, EventArgs e)
        {
            if (TB_usuario.Text.Length != 0 && LB_usuarios.Items.Contains(TB_usuario.Text))
            {
               
                Usuario usuario = new Usuario();
                usuario.CadastrarClientes = CB_CadastrarClientes.Checked;
                usuario.CadastrarProdutosJfc = CB_CadastrarProdutosJfc.Checked;
                usuario.CadastrarProdutosMatriz = CB_CadastrarprodutosMatriz.Checked;
                usuario.CadastroClienteRapido = CB_CadastroClienteRapido.Checked;
                usuario.CriarUsuarios = CB_CriarUsuarios.Checked;
                usuario.ExportarArquivos = CB_ExportarArquivos.Checked;
                usuario.Nome = TB_usuario.Text;
                if (TB_senha.Text.Length != 0)
                    usuario.Senha = TB_senha.Text;
                else { usuario.Senha = _usuarios.Find(a => a.Nome == TB_usuario.Text).Senha; }
                Banco banco = new Banco();
                banco.EditarUsuario(usuario,_usuarioatual);
                _usuarios = banco.Usuario();
                MessageBox.Show("Usuario Editado", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("USUARIO INEXISTENTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LB_usuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LB_usuarios?.SelectedItem != null)
            {
                BT_apagar.Visible = false;
                TB_usuario.Enabled = false;
                TB_usuario.Text = LB_usuarios.SelectedItem.ToString();
                CB_CadastrarClientes.Checked = _usuarios.Find(a => a.Nome == LB_usuarios.SelectedItem.ToString()).CadastrarClientes;
                CB_CadastrarProdutosJfc.Checked = _usuarios.Find(a => a.Nome == LB_usuarios.SelectedItem.ToString()).CadastrarProdutosJfc;
                CB_CadastrarprodutosMatriz.Checked = _usuarios.Find(a => a.Nome == LB_usuarios.SelectedItem.ToString()).CadastrarProdutosMatriz;
                CB_CadastroClienteRapido.Checked = _usuarios.Find(a => a.Nome == LB_usuarios.SelectedItem.ToString()).CadastroClienteRapido;
                CB_CriarUsuarios.Checked = _usuarios.Find(a => a.Nome == LB_usuarios.SelectedItem.ToString()).CriarUsuarios;
                CB_ExportarArquivos.Checked = _usuarios.Find(a => a.Nome == LB_usuarios.SelectedItem.ToString()).ExportarArquivos;
                bt_Salvar.Text = "Cancelar";
                editar = true;
            }
        }
    }
}
