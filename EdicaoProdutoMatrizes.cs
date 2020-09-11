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
    public partial class EdicaoProdutoMatrizes : Form
    {
        List<ProdutosDobanco> ProdutosDobancoMatrizes;
        List<ProdutosDobanco> ProdutosDobancoJFC;
        Usuario _Usuario;
        public EdicaoProdutoMatrizes(Usuario usuario)
        {
            _Usuario = usuario;
            InitializeComponent();
            Banco banco = new Banco();
            ProdutosDobancoMatrizes = banco.ProdutosDasMatrizes();
            ProdutosDobancoJFC = banco.ProdutosCadastradosjfc();
            AdicionarProdutosaoDTGV_SemModificacao(ProdutosDobancoMatrizes);
            AdicionarProdutosAoComboBoXDoDGV_modificacao(ProdutosDobancoJFC);

        }
        private void AdicionarProdutosaoDTGV_SemModificacao(List<ProdutosDobanco> produtosDobancos)
        {
            DTGV_SemModificacao.Rows.Clear();
            foreach (ProdutosDobanco produtos in produtosDobancos)
            {
                bool existe = false;
                for (int i = 0; i < DTgv_ComModificacao.Rows.Count; i++)
                {
                    if (DTgv_ComModificacao[4, i].Value.ToString() == produtos.Matriz && DTgv_ComModificacao[0, i].Value.ToString() == produtos.CodCliente && DTgv_ComModificacao[1, i].Value.ToString() == produtos.DescricaoCliente)
                        existe = true;

                }
                if (!existe)
                    DTGV_SemModificacao.Rows.Add(produtos.CodCliente, produtos.DescricaoCliente, produtos.CodJfc, produtos.DescricaoJfc, produtos.Matriz);


            }


        }
        private void AdicionarProdutosAoComboBoXDoDGV_modificacao(List<ProdutosDobanco> produtosDobancosjfc)
        {
            foreach (ProdutosDobanco produtosDobanco in produtosDobancosjfc)
            {

                DGV_Coluna_Edicao_CodigoJfc.Items.Add(produtosDobanco.DescricaoJfc);
            }
        }
        private void EditarProdutoMatrizes_Load(object sender, EventArgs e)
        {

        }

        private void BT_MoverParaEdicao_Click(object sender, EventArgs e)
        {


            if (DTGV_SemModificacao.Rows.Count > 0)
            {
                DTgv_ComModificacao.Rows.Add(DTGV_SemModificacao.SelectedCells[0].Value, DTGV_SemModificacao.SelectedCells[1].Value, "", DTGV_SemModificacao.SelectedCells[3].Value, DTGV_SemModificacao.SelectedCells[4].Value);
                DTGV_SemModificacao.Rows.Remove(DTGV_SemModificacao.SelectedRows[0]);
            }

        }

        private void DTgv_ComModificacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != DGV_Coluna_Edicao_CodigoJfc.Index)
                return;

            DTgv_ComModificacao.BeginEdit(false);
            if (DTgv_ComModificacao?.EditingControl != null)
                ((DataGridViewComboBoxEditingControl)DTgv_ComModificacao.EditingControl).DroppedDown = true;
        }

        private void DTgv_ComModificacao_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void BT_removerDaEdicao_Click(object sender, EventArgs e)
        {
            if (DTgv_ComModificacao.Rows.Count > 0)
            {
                DTGV_SemModificacao.Rows.Add(DTgv_ComModificacao.SelectedCells[0].Value, DTgv_ComModificacao.SelectedCells[1].Value, ProdutosDobancoMatrizes.Find(a => a.CodCliente == DTgv_ComModificacao.SelectedCells[0].Value.ToString() && a.DescricaoCliente == DTgv_ComModificacao.SelectedCells[1].Value.ToString() && a.Matriz == DTgv_ComModificacao.SelectedCells[4].Value.ToString()).CodJfc, DTgv_ComModificacao.SelectedCells[3].Value, DTgv_ComModificacao.SelectedCells[4].Value);
                DTgv_ComModificacao.Rows.Remove(DTgv_ComModificacao.SelectedRows[0]);
            }
        }

        private void BT_Editar_Click(object sender, EventArgs e)
        {
            if (DTgv_ComModificacao.Rows.Count > 0 && MessageBox.Show("Deseja realmente editar esses itens?", "Atencao!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<ProdutosDobanco> ListaprodutosDobanco = new List<ProdutosDobanco>();
                int i = 0;
                while (i < DTgv_ComModificacao.Rows.Count)
                {
                    ProdutosDobanco produtosDobanco = new ProdutosDobanco();
                    if (DTgv_ComModificacao[2, i].Value.ToString() != "")
                    {
                        produtosDobanco.CodJfc = ProdutosDobancoJFC.Find(a => a.DescricaoJfc == DTgv_ComModificacao[2, i].Value.ToString()).CodJfc;
                        produtosDobanco.DescricaoJfc = DTgv_ComModificacao[2, i].Value.ToString();
                        produtosDobanco.Matriz = DTgv_ComModificacao[4, i].Value.ToString();
                        produtosDobanco.CodCliente = DTgv_ComModificacao[0, i].Value.ToString();
                        produtosDobanco.DescricaoCliente = DTgv_ComModificacao[1, i].Value.ToString();
                        DTgv_ComModificacao.Rows.RemoveAt(i);
                        ListaprodutosDobanco.Add(produtosDobanco);
                        continue;

                    }
                    i++;
                }

                Banco banco = new Banco();
                banco.EditarProdutosMatrizes(ListaprodutosDobanco, _Usuario);
                ProdutosDobancoMatrizes = banco.ProdutosDasMatrizes();
                AdicionarProdutosaoDTGV_SemModificacao(ProdutosDobancoMatrizes);

                MessageBox.Show("Itens editado com sucesso!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void BT_Apagar_Click(object sender, EventArgs e)
        {
            if (DTgv_ComModificacao.Rows.Count > 0 && MessageBox.Show("Deseja realmente apagar estes itens?", "atencao!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                List<ProdutosDobanco> ListaprodutosDobanco = new List<ProdutosDobanco>();
                for (int i = 0; i < DTgv_ComModificacao.Rows.Count; i = 0)
                {
                    ProdutosDobanco produtosDobanco = new ProdutosDobanco();

                    produtosDobanco.DescricaoCliente = DTgv_ComModificacao[1, i].Value.ToString();
                    produtosDobanco.DescricaoJfc = DTgv_ComModificacao[2, i].Value.ToString();
                    produtosDobanco.Matriz = DTgv_ComModificacao[4, i].Value.ToString();
                    produtosDobanco.CodCliente = DTgv_ComModificacao[0, i].Value.ToString();
                    DTgv_ComModificacao.Rows.RemoveAt(i);
                    ListaprodutosDobanco.Add(produtosDobanco);

                }
                Banco banco = new Banco();
                banco.ApagarProdutosMatrizes(ListaprodutosDobanco, _Usuario);
                ProdutosDobancoMatrizes = banco.ProdutosDasMatrizes();
                AdicionarProdutosaoDTGV_SemModificacao(ProdutosDobancoMatrizes);
                MessageBox.Show("Itens apagados com sucesso!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TXB_Filtro_TextChanged(object sender, EventArgs e)
        {
            DTGV_SemModificacao.Rows.Clear();
            foreach (ProdutosDobanco produtosDobanco in ProdutosDobancoMatrizes)
            {
                bool produtoexistente = false;
                for (int i = 0; i < DTgv_ComModificacao.Rows.Count; i++)
                {

                    if (DTgv_ComModificacao[4, i].Value.ToString() == produtosDobanco.Matriz && DTgv_ComModificacao[0, i].Value.ToString() == produtosDobanco.CodCliente && DTgv_ComModificacao[1, i].Value.ToString() == produtosDobanco.DescricaoCliente)
                        produtoexistente = true;
                }
                if (!produtoexistente && (produtosDobanco.CodCliente.ToLower().Contains(TXB_Filtro.Text.ToLower()) || produtosDobanco.CodJfc.ToLower().Contains(TXB_Filtro.Text.ToLower()) || produtosDobanco.DescricaoCliente.ToLower().Contains(TXB_Filtro.Text.ToLower()) || produtosDobanco.DescricaoJfc.ToLower().Contains(TXB_Filtro.Text.ToLower()) || produtosDobanco.Matriz.ToLower().Contains(TXB_Filtro.Text.ToLower())))
                    DTGV_SemModificacao.Rows.Add(produtosDobanco.CodCliente, produtosDobanco.DescricaoCliente, produtosDobanco.CodJfc, produtosDobanco.DescricaoJfc, produtosDobanco.Matriz);
            }
        }
    }
}
