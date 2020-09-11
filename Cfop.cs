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
    public partial class Cfop : Form
    {
        List<CfopObjeto> _cfops = new List<CfopObjeto>();
        public Cfop()
        {
            Banco banco = new Banco();
            _cfops = banco.Cfops();
            
            InitializeComponent();
            adicionarnoData(_cfops);
        }
        void adicionarnoData(List<CfopObjeto> _cfops)
        {
            foreach (CfopObjeto cfop in _cfops)
            {
                Dg_cfops.Rows.Add(cfop.Cfop, cfop.Descricao);
            }


        }

        private void TB_CFOP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }
        }

        private void BT_adicionar_Click(object sender, EventArgs e)
        {
            if (!_cfops.Exists(a => a.Cfop == TB_CFOP.Text))
            {
                Banco banco = new Banco();
                banco.AdicionarCFOP(TB_CFOP.Text, TB_Descricao.Text);
                _cfops = banco.Cfops();
                Dg_cfops.Rows.Clear();
                adicionarnoData(_cfops);
            }
            else { MessageBox.Show("CFOP Ja Cadastrado", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BT_apagar_Click(object sender, EventArgs e)
        {
            if (Dg_cfops.SelectedCells[0]?.Value != null) {
                Dg_cfops.Rows.Clear();
                Banco banco = new Banco();
                banco.ApagarCFOP(Dg_cfops.SelectedCells[0]?.Value.ToString());
                _cfops.Remove(_cfops.Find(a => a.Cfop == Dg_cfops[0, Dg_cfops.CurrentRow.Index].Value.ToString()));
                adicionarnoData(_cfops);
            
            
            }
        }
    }
}
