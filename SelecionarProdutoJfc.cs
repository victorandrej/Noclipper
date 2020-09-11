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
   
    public partial class SelecionarProdutoJfc : Form
    {
        public string descicaoSelecionada;
        List<ProdutosDobanco> _produtosjfc;
        public  SelecionarProdutoJfc(List<ProdutosDobanco> produtosjfc)
        {
            _produtosjfc = produtosjfc;
            InitializeComponent();
            foreach (ProdutosDobanco produtosDobanco in _produtosjfc) {
                DataGrid.Rows.Add(produtosDobanco.CodJfc, produtosDobanco.DescricaoJfc);

            }
        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            descicaoSelecionada = DataGrid.SelectedCells[1].Value.ToString();
            DialogResult = DialogResult.OK;
        }

        private void DataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            foreach (ProdutosDobanco produtosDobanco in _produtosjfc)
            {

                if(produtosDobanco.CodJfc.ToLower().Contains(textBox1.Text.ToLower()) || produtosDobanco.DescricaoJfc.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    DataGrid.Rows.Add(produtosDobanco.CodJfc, produtosDobanco.DescricaoJfc);


                }

            }
               
        }
    }
}
