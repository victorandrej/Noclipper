using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ubiety.Dns.Core.Records.General;

namespace NoClipper
{
    public partial class CadastroDeProdutosDoCliente : Form
    {
        private List<Nota> _notascomproblema;
        private List<ProdutosDobanco> produtosDobancos;
        //public List<Nota> notasProblemasresolvidos = new List<Nota>();
        Usuario _usuario;
        public CadastroDeProdutosDoCliente(List<Nota> NotasComProblema, Usuario usuario)
        {


            _usuario = usuario;
            InitializeComponent();
            _notascomproblema = NotasComProblema;
            foreach (Nota nota in NotasComProblema)
            {
                bool existe = false;

                for (int i = 0; i < DGV_parceiro.Rows.Count; i++)
                {
                    if (DGV_parceiro[1, i].Value.ToString() == nota.CNPJ.Remove(8))
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    DGV_parceiro.Rows.Add(nota.Nome, nota.CNPJ.Remove(8));
                }
                
            }
            Banco banco = new Banco();
            produtosDobancos = banco.ProdutosCadastradosjfc();


        }

        private void BT_salvar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            int i = 0;

            while (i < DGV_Itens.Rows.Count)
            {
                Produto produtosemproblema = new Produto();
                if (DGV_Itens[1, i].Value?.ToString() != null && produtosDobancos.Exists(a => a.DescricaoJfc.ToLower() == DGV_Itens[1, i].Value?.ToString().ToLower()))
                {
                    ProdutosDobanco produtosDobanco = new ProdutosDobanco();
                    produtosDobanco.Matriz = DGV_parceiro.SelectedCells[1].Value.ToString();
                    produtosDobanco.CodCliente = _notascomproblema.Find((a) => a.CNPJ.Remove(8) == produtosDobanco.Matriz).Produtos.Find(a => a.Descricao == DGV_Itens[0, i].Value.ToString()).Codigo;
                    produtosDobanco.DescricaoCliente = DGV_Itens[0, i].Value.ToString();
                    produtosDobanco.DescricaoJfc = DGV_Itens[1, i].Value.ToString();
                    produtosDobanco.CodJfc = produtosDobancos.Find(a => a.DescricaoJfc == DGV_Itens[1, i].Value.ToString()).CodJfc;
                    produtosDobanco.Kilagem = produtosDobancos.Find(a => a.DescricaoJfc == DGV_Itens[1, i].Value.ToString()).Kilagem;
                    banco.AdicionarProdutosMatrizes(produtosDobanco, _usuario);
                    produtosemproblema.Descricao = DGV_Itens[0, i].Value.ToString();
                    produtosemproblema.Codigo = _notascomproblema.Find((a) => a.CNPJ.Remove(8) == produtosDobanco.Matriz).Produtos.Find(a => a.Descricao == DGV_Itens[0, i].Value.ToString()).Codigo;

                    _notascomproblema.Find((a) => a.CNPJ.Remove(8) == produtosDobanco.Matriz).Produtos.Remove(_notascomproblema.Find((a) => a.CNPJ.Remove(8) == produtosDobanco.Matriz).Produtos.Find(a => a.Descricao == DGV_Itens[0, i].Value.ToString()));
                    DGV_Itens.Rows.RemoveAt(i);
                    continue;

                }

                i++;
            }
            if (DGV_Itens.Rows.Count == 0)
            {

                DGV_parceiro.Rows.RemoveAt(DGV_parceiro.SelectedCells[1].RowIndex);
            }
        }

        private void CadastroDeProdutosDoCliente_Load(object sender, EventArgs e)
        {

        }

        private void DGV_parceiro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //DataGridViewComboBoxColumn combobox = new DataGridViewComboBoxColumn();
        //combobox.HeaderText ="aa";
        //combobox.Items.Add("adaw");
        //combobox.Items.Add("ww");
        //DGV_Itens.Columns.Add(combobox);


        private void DGV_parceiro_SelectionChanged(object sender, EventArgs e)
        {
            Banco banco = new Banco();

            DGV_Itens.Rows.Clear();
            foreach (Nota nota in _notascomproblema)
            {
                List<ProdutosDobanco> ProdutodobancoMatriz = banco.ProdutosDocnpj(nota.CNPJ);

                if (DGV_parceiro.Rows.Count != 0 && nota.CNPJ.Remove(8) == DGV_parceiro.SelectedCells[1].Value.ToString())
                {
                    foreach (Produto produto in nota.Produtos)
                    {
                        if (!ProdutodobancoMatriz.Exists(a => a.CodCliente == produto.Codigo && a.DescricaoCliente == produto.Descricao))
                        {
                            bool existe = false;
                            for (int i = 0; i < DGV_Itens.Rows.Count; i++)
                            {

                                if ((DGV_Itens[0, i].Value.ToString() == produto.Descricao))
                                {
                                    existe = true;
                                    break;
                                }

                            }
                            if (!existe)
                            {

                                DGV_Itens.Rows.Add(produto.Descricao);

                            }

                        }
                    }

                }
            }
        }

        private void CadastroDeProdutosDoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void DGV_Itens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != CodigoJfc.Index)
                return;

            DGV_Itens.BeginEdit(false);
            if (DGV_Itens.EditingControl != null)
                ((DataGridViewComboBoxEditingControl)DGV_Itens.EditingControl).DroppedDown = true;
        }

        private void DGV_Itens_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (e.ColumnIndex == CodigoJfc.DisplayIndex)

            //{

            //    if (!this.CodigoJfc.Items.Contains(e.FormattedValue))

            //    {

            //        this.CodigoJfc.Items.Add(e.FormattedValue);

            //    }

            //}
        }

        private void DGV_Itens_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.DGV_Itens.CurrentCellAddress.X == CodigoJfc.DisplayIndex)

            {

                ComboBox cb = e.Control as ComboBox;

                if (cb != null)

                {
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                }

            }
        }

        private void DGV_Itens_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DGV_Itens_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_Itens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                SelecionarProdutoJfc selecionarProdutoJfc = new SelecionarProdutoJfc(produtosDobancos);
                if (selecionarProdutoJfc.ShowDialog() == DialogResult.OK)
                {
                    DGV_Itens.SelectedCells[1].Value = selecionarProdutoJfc.descicaoSelecionada;


                }
            }
        }
    }
}
