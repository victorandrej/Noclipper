using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;
namespace NoClipper
{
    public partial class CadastroDeItensjfc : Form
    {
        private List<TextBox> CadastrarProduto = new List<TextBox>();
        private List<ProdutosDobanco> produtosDobanco = new List<ProdutosDobanco>();
        Usuario _usuario;
        public CadastroDeItensjfc(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            CadastrarProduto.Add(TB_codigo);
            CadastrarProduto.Add(TB_Descricao);
            CadastrarProduto.Add(TB_kilagem);
            AdicionarProdutosNaDGV();



        }
        private void AdicionarProdutosNaDGV()
        {
            Banco banco = new Banco();
            produtosDobanco = banco.ProdutosCadastradosjfc();

            DGV_ProdutosCadastrados.Rows.Clear();
            foreach (ProdutosDobanco produtoDobanco in produtosDobanco)
            {
                DGV_ProdutosCadastrados.Rows.Add(produtoDobanco.CodJfc, produtoDobanco.DescricaoJfc, produtoDobanco.Kilagem);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void BT_maiscadastros_Click(object sender, EventArgs e)
        {
            if (CadastrarProduto.Count < 15)
            {
                TextBox textBoxCodigo = new TextBox();

                textBoxCodigo.Size = new Size(37, 20);
                textBoxCodigo.Location = new Point(14, CadastrarProduto[CadastrarProduto.Count - 3].Location.Y + 30);
                textBoxCodigo.MaxLength = 3;
                textBoxCodigo.KeyPress += TextBoxCodigo_KeyPress;

                TextBox textDescricao = new TextBox();
                textDescricao.Size = new Size(100, 20);
                textDescricao.Location = new Point(57, CadastrarProduto[CadastrarProduto.Count - 2].Location.Y + 30);


                TextBox textKilagem = new TextBox();
                textKilagem.Size = new Size(37, 20);
                textKilagem.Location = new Point(163, CadastrarProduto[CadastrarProduto.Count - 1].Location.Y + 30);
                textKilagem.MaxLength = 5;
                textKilagem.KeyPress += TextKilagem_KeyPress;
                // adiciona na lista  de textos
                CadastrarProduto.Add(textBoxCodigo);
                CadastrarProduto.Add(textDescricao);
                CadastrarProduto.Add(textKilagem);
                //adiciona na tela
                this.Controls.Add(CadastrarProduto[CadastrarProduto.Count - 3]);
                this.Controls.Add(CadastrarProduto[CadastrarProduto.Count - 2]);
                this.Controls.Add(CadastrarProduto[CadastrarProduto.Count - 1]);
                Bt_salvar.Location = new Point(Bt_salvar.Location.X, Bt_salvar.Location.Y + CadastrarProduto[CadastrarProduto.Count - 2].Size.Height + 10);
                BT_maiscadastros.Location = new Point(BT_maiscadastros.Location.X, CadastrarProduto[CadastrarProduto.Count - 1].Location.Y);
                if (CadastrarProduto.Count == 15) { BT_maiscadastros.Enabled = false; }
            }
            else { BT_maiscadastros.Enabled = false; }
        }

        private void TextBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void TextKilagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox aa = (TextBox)sender;


            //if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != ',')
            //    e.Handled = true;
            //else if (e.KeyChar == ',' && aa.Text.Contains(","))
            //    e.Handled = true;


            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && ((e.KeyChar != ',') || aa.Text.Contains(",")))
                e.Handled = true;

        }

        private void TextDescricao_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        private void Bt_salvar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            for (int i = 0; i < CadastrarProduto.Count; i += 3)
            {
                if (CadastrarProduto[i].Text != "" && CadastrarProduto[i + 1].Text != "" && CadastrarProduto[i + 2].Text != "")
                {
                    if (banco.AdicionarProdutoJfc(CadastrarProduto[i].Text, CadastrarProduto[i + 1].Text, Convert.ToDouble(CadastrarProduto[i + 2].Text).ToString(), _usuario))
                    {
                        CadastrarProduto[i].Text = "";
                        CadastrarProduto[i + 1].Text = "";
                        CadastrarProduto[i + 2].Text = "";
                    }
                    else { MessageBox.Show("item " + CadastrarProduto[i].Text + " ja cadastrado"); }
                }
            }
            AdicionarProdutosNaDGV();
        }

        private void BT_Editar_Click(object sender, EventArgs e)
        {
            if (DGV_ProdutosCadastrados.Rows.Count > 0)
            {


                EditarProdutosJFc editarProdutosJFc = new EditarProdutosJFc(DGV_ProdutosCadastrados.SelectedCells[0].Value.ToString(), DGV_ProdutosCadastrados.SelectedCells[1].Value.ToString(), DGV_ProdutosCadastrados.SelectedCells[2].Value.ToString(),_usuario);

                if (editarProdutosJFc.ShowDialog() == DialogResult.OK)
                {
                    AdicionarProdutosNaDGV();
                }
            }
        }

        private void BT_excluir_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            if (DGV_ProdutosCadastrados.SelectedCells.Count > 0)
            {
                banco.ExcluirProdutosJfc(DGV_ProdutosCadastrados.SelectedCells[0].Value.ToString(),_usuario);
                AdicionarProdutosNaDGV();
            }
        }

        private void CadastroDeItens_Load(object sender, EventArgs e)
        {

        }

        private void TB_kilagem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TB_kilagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && ((e.KeyChar != ',') || TB_kilagem.Text.Contains(",")))
                e.Handled = true;
        }
    }
}

