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
    public partial class ErroCadastroClientes : Form
    {
        public ErroCadastroClientes(List<Cliente> clientes)
        {
            InitializeComponent();
         
            foreach (Cliente cliente in clientes) {
                LB_CnpjNaoCadastrado.Items.Add(cliente.Cnpj);
            }
        }
    }
}
