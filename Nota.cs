using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoClipper
{
   public class Nota
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();
        public string NomeDoarquivo { get; set; }
        public string Nome { get; set; }
        public  string CNPJ { get; set; }
        public  DateTime Data { get; set; }
        public string NumeroNota { get; set; }
        public string Serie { get; set; }
        public string CodigoJFcPareciro { get; set; }
    }
}
