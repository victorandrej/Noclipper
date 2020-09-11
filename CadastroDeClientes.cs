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
    public partial class CadastroDeClientes : Form
    {
        List<Cliente> Clientes;
        Usuario _usuario;
        public CadastroDeClientes(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();

            AdicionarDGV();
        }

        private void AdicionarDGV()
        {
            DGV_Cliente.Rows.Clear();
            Banco banco = new Banco();
            Clientes = banco.Clientes();
            foreach (Cliente cliente in Clientes)
                DGV_Cliente.Rows.Add(cliente.Cnpj, cliente.CodJfc);




        }

        private void TB_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void TB_CODJFc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void BT_salvar_Click(object sender, EventArgs e)
        {
            if(TB_CNPJ.Text.Length != 14 && TB_CODJFc.Text.Length != 6) {
                MessageBox.Show("Codigo JFc Necessita ter 6 digitos, e  CNPJ 14", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TB_CNPJ.Text.Length != 14)
                MessageBox.Show("CNPJ Necessita ter 14 digitos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (TB_CODJFc.Text.Length != 6)
                MessageBox.Show("Codigo JFc Necessita ter 6 digitos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (Clientes.Exists(a => a.Cnpj == TB_CNPJ.Text || Convert.ToInt32(a.CodJfc) == Convert.ToInt32(TB_CODJFc.Text)))
                {
                    MessageBox.Show("Cliente Ja cadastrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Banco banco = new Banco();
                    banco.AdicionarClientes(TB_CNPJ.Text, TB_CODJFc.Text, _usuario);
                    AdicionarDGV();
                    TB_filtro.Text = "";
                    TB_CNPJ.Text = "";
                    TB_CODJFc.Text = "";
                }
            }

        }

        private void BT_apagar_Click(object sender, EventArgs e)
        {
            if (DGV_Cliente.SelectedRows.Count > 0)
                if (MessageBox.Show("deseja realmete apagar esse cliente", "atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Banco banco = new Banco();
                    banco.ApagarClientes(DGV_Cliente.SelectedCells[0].Value.ToString(), DGV_Cliente.SelectedCells[1].Value.ToString(), _usuario);
                    AdicionarDGV();
                    TB_filtro.Text = "";
                }
        }

        private void TB_filtro_TextChanged(object sender, EventArgs e)
        {
            if (Clientes.Count > 0)
            {
                DGV_Cliente.Rows.Clear(); 
                foreach (Cliente cliente in Clientes)
                    if (String.Format("{0,14:00000000000000}" , Convert.ToInt64(cliente.Cnpj)).Contains(TB_filtro.Text) || String.Format("{0,6:000000}", Convert.ToInt32(cliente.CodJfc)).Contains(TB_filtro.Text))
                        DGV_Cliente.Rows.Add(cliente.Cnpj, cliente.CodJfc);
            }

        }
    }


}
