using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoClipper
{
   public class Usuario
    {
        public string Nome { get; set; }
        public bool CadastrarProdutosMatriz { get; set; }
        public bool CadastrarProdutosJfc { get; set; }
        public bool CadastrarClientes { get; set; }
        public bool ModificarServidor { get; set; }
        public bool CadastroClienteRapido { get; set; }
        public bool CriarUsuarios { get; set; }
        public bool ExportarArquivos { get; set; }
        public string Senha { get; set; }
        public bool root { get; set; }
    }
}
