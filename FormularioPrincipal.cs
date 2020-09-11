using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NoClipper
{
    public partial class FormularioPrincipal : Form
    {
        private Usuario Usuario;
        string Caminhoxml;
        private List<Nota> ListadeNotas;
        private List<Nota> NotasComErros = new List<Nota>();
        private List<Nota> NotasConvertidas = new List<Nota>();
        public FormularioPrincipal(Usuario user)
        {
            Usuario = user;
            InitializeComponent();
            DesabilitarOpcoes(Usuario);
            Banco banco = new Banco();
            exportarToolStripMenuItem.Enabled = banco.ExisteExportacao();



        }
        private void DesabilitarOpcoes(Usuario usuario)
        {

            if (!usuario.CadastrarClientes && !usuario.CadastrarProdutosJfc && !usuario.CadastrarProdutosMatriz)
                cadastroToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem.Visible = usuario.CadastrarClientes;
            produtosJFCToolStripMenuItem.Visible = usuario.CadastrarProdutosJfc;
            produtosDasMatrizesToolStripMenuItem.Visible = usuario.CadastrarProdutosMatriz;
            BT_cadastrarErro.Visible = usuario.CadastrarProdutosMatriz;
            servidorToolStripMenuItem.Visible = usuario.ModificarServidor;
            exportarToolStripMenuItem.Visible = usuario.ExportarArquivos;
            usuariosToolStripMenuItem.Visible = usuario.CriarUsuarios;

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void TxbCnpj_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void BT_Selecionar_Click(object sender, EventArgs e)
        {


            Lb_ProdutosNota.Items.Clear();
            LB_ClienteNota.Items.Clear();
            FolderBrowserDialog local = new FolderBrowserDialog();
            if (local.ShowDialog() == DialogResult.OK)
            {

                Caminhoxml = local.SelectedPath;
                Arquivo Arquivo = new Arquivo(Caminhoxml);
                xml Xml = new xml(Arquivo.Xmls());
                ListadeNotas = Xml.Notas();
                foreach (Nota nota in ListadeNotas)
                {
                    Verificar verificar = new Verificar();
                    if (verificar.Devolucao(nota) == true)
                    {
                        LB_ClienteNota.Items.Add(nota.NomeDoarquivo);
                    }
                }
            }
        }
        private void LB_ClienteNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_ClienteNota.SelectedIndex != -1)
            {
                Nota nota = ListadeNotas[LB_ClienteNota.SelectedIndex];
                Lb_ProdutosNota.Items.Clear();
                TxbCnpj.Text = nota.CNPJ.ToString();
                TxbData.Text = nota.Data.ToShortDateString();
                foreach (Produto produto in nota.Produtos)
                {
                    Lb_ProdutosNota.Items.Add(produto.Descricao);
                }
            }
        }
        private void BT_converter(object sender, EventArgs e)

        {
            Banco banco = new Banco();
            Verificar verificar = new Verificar();
            Converter converter = new Converter();
            if (ListadeNotas?.Count != null)
            {
                NotasConvertidas = converter.ProdutoConvertido(ListadeNotas);
                NotasComErros = verificar.NotasComErroDeProduto(ListadeNotas, NotasConvertidas);
                if (NotasComErros.Count > 0)
                {
                    LB_ErroNotas.Items.Clear();
                    foreach (Nota nota in NotasComErros)
                    {
                        bool ClienteExistente = false;
                        foreach (string cliente in LB_ErroNotas.Items)
                        {
                            if (cliente == nota.CNPJ.Remove(8))
                            {
                                ClienteExistente = true;
                            }
                        }
                        if (!ClienteExistente)
                        {
                            LB_ErroNotas.Items.Add(nota.CNPJ.Remove(8));
                        }
                    }
                    TP_Conversor.SelectedTab = TB_Erro;
                }
                else
                {
                    List<Cliente> ClientesComErro = verificar.NotasComErroDeCodigoDeParceiro(NotasConvertidas);
                    NotasConvertidas = converter.CnpjConvertido(NotasConvertidas);
                    if (ClientesComErro.Count == 0)

                    {
                        List<Nota> NotasNaoCadastradas = verificar.NotasNaoCadastradas(ListadeNotas);
                        if (NotasNaoCadastradas.Count == 0)
                        {
                            MessageBox.Show("NOTAS JA SALVAS", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (NotasNaoCadastradas.Count != ListadeNotas.Count)
                        {

                            try
                            {
                                banco.SalvarNotasNoBanco(NotasNaoCadastradas, Usuario);

                                MessageBox.Show("NOTAS SALVAS COM SUCESSO, ALGUMAS JA FORAM EXPORTADAS", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                exportarToolStripMenuItem.Enabled = true;
                            }
                            catch
                            {
                                MessageBox.Show("NÃO FOI POSSIVEL SALVAR AS NOTAS", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            try
                            {
                                banco.SalvarNotasNoBanco(NotasNaoCadastradas, Usuario);

                                MessageBox.Show("NOTAS SALVAS COM SUCESSO", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                exportarToolStripMenuItem.Enabled = true;
                            }
                            catch
                            {
                                MessageBox.Show("NÃO FOI POSSIVEL SALVAR AS NOTAS", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    else
                    {
                        if (Usuario.CadastroClienteRapido)
                        {
                            if (MessageBox.Show("Ha Clientes não cadastrados Deseja Cadastralos?", "atencao!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                foreach (Cliente cliente in ClientesComErro)
                                {
                                    CadastroDeClientesRapido cadastroDeClientes = new CadastroDeClientesRapido(cliente.Cnpj, Usuario);
                                    cadastroDeClientes.ShowDialog();
                                }

                            }
                            else
                            {
                                ErroCadastroClientes erroCadastroClientes = new ErroCadastroClientes(ClientesComErro);
                                erroCadastroClientes.ShowDialog();
                            }
                        }
                        else
                        {
                            ErroCadastroClientes erroCadastroClientes = new ErroCadastroClientes(ClientesComErro);
                            erroCadastroClientes.ShowDialog();
                        }
                    }


                }
            }

        }

        private void LB_ErroNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_ErroProduto.Items.Clear();
            if (LB_ErroNotas.SelectedIndex != -1)
            {
                foreach (Nota nota in NotasComErros)
                {
                    if (nota.CNPJ.Contains(LB_ErroNotas.SelectedItem.ToString()))
                    {
                        foreach (Produto produto in nota.Produtos)
                        {
                            bool ProdutoExiste = false;
                            if (LB_ErroProduto.Items.Count != 0)
                            {
                                foreach (string Produtomatrizes in LB_ErroProduto.Items)
                                {
                                    if (Produtomatrizes == produto.Descricao)
                                    {
                                        ProdutoExiste = true;
                                    }

                                }
                                if (ProdutoExiste != true)
                                {
                                    LB_ErroProduto.Items.Add(produto.Descricao);
                                }
                            }
                            else
                            {
                                LB_ErroProduto.Items.Add(produto.Descricao);
                            }

                        }
                    }
                }
            }
        }

        private void BT_cadastrarErro_Click(object sender, EventArgs e)
        {
            if (LB_ErroNotas.Items.Count > 0)
            {
                List<Nota> NotascomErroscadastral = new List<Nota>();

                foreach (string nota in LB_ErroNotas.Items)
                {
                    Nota clientecomerro = new Nota();
                    clientecomerro.CNPJ = nota;
                    Produto produto = new Produto();
                    foreach (Nota nota1 in NotasComErros)
                    {
                        if (nota == nota1.CNPJ.Remove(8) && NotascomErroscadastral.Exists(a => a.CNPJ.Remove(8) == nota))
                        {
                            foreach (Produto produto1 in nota1.Produtos)
                            {
                                if (!NotascomErroscadastral.Find(a => a.CNPJ.Remove(8) == nota).Produtos.Exists(a => a.Codigo == produto1.Codigo && a.Descricao == produto1.Descricao))
                                {
                                    NotascomErroscadastral.Find(a => a.CNPJ.Remove(8) == nota1.CNPJ.Remove(8)).Produtos.Add(produto1);
                                }

                            }

                        }
                        else { NotascomErroscadastral.Add(nota1); }


                    }

                }

                CadastroDeProdutosDoCliente cadastroDeProdutosDoCliente = new CadastroDeProdutosDoCliente(NotascomErroscadastral, Usuario);
                if (cadastroDeProdutosDoCliente.ShowDialog() == DialogResult.OK)
                {
                    LB_ErroNotas.Items.Clear();
                    LB_ErroProduto.Items.Clear();
                    TP_Conversor.SelectedIndex = 0;

                }
            }
        }

        private void Configuracoesadministrativas_Click(object sender, EventArgs e)
        {
        }

        private void TP_Conversor_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void editarProdutosDaMatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdicaoProdutoMatrizes editarProdutoMatrizes = new EdicaoProdutoMatrizes(Usuario);
            editarProdutoMatrizes.ShowDialog();
        }

        private void cadastrarProdutosJfcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeItensjfc cadastroDeItensjfc = new CadastroDeItensjfc(Usuario);
            cadastroDeItensjfc.ShowDialog();
        }

        private void produtosJFCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeItensjfc cadastroDeItensjfc = new CadastroDeItensjfc(Usuario);
            cadastroDeItensjfc.ShowDialog();
        }

        private void produtosDasMatrizesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdicaoProdutoMatrizes edicaoProdutoMatrizes = new EdicaoProdutoMatrizes(Usuario);
            edicaoProdutoMatrizes.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeClientes cadastroDeClientes = new CadastroDeClientes(Usuario);
            cadastroDeClientes.ShowDialog();
        }

        private void servidorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarServidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeBancoDeDados cadastroDeBancoDeDados = new CadastroDeBancoDeDados();
            cadastroDeBancoDeDados.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuarios cadastroUsuarios = new CadastroUsuarios(Usuario);
            cadastroUsuarios.ShowDialog();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "|.txt";
            Converter Converter = new Converter();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Banco banco = new Banco();
                TXT txt = new TXT();

                List<Nota> notasSemerro = Converter.CnpjConvertido(Converter.ProdutoConvertido(banco.NotasPendentes()));
                txt.CriarTxtFormatoJFc(notasSemerro, saveFileDialog.FileName, Usuario);
                banco.TirarPendencia();
                MessageBox.Show("Notas Convertidas e salvas em: " + saveFileDialog.FileName, "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                exportarToolStripMenuItem.Enabled = false;
            }
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            AlterarSenha alterar = new AlterarSenha(Usuario);
            if (alterar.ShowDialog() == DialogResult.OK)
            {

                Usuario = banco.Usuario(Usuario.Nome);

            }
        }

        private void cfopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cfop cfop = new Cfop();
            cfop.ShowDialog();
        }
    }
}
