using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace NoClipper
{
    class xml
    {
        private string[] Caminhos;
        public xml(string[] caminhos) { Caminhos = caminhos; }
        public xml(string caminho) { Caminhos[0] = caminho; }
        public List<Nota> Notas()
        {
            /*
             Se você souber Pfv Melhore este codigo!!
             Se você souber Pfv Melhore este codigo!!
             */
            Verificar verificar = new Verificar();

            List<Nota> ListaDeNota = new List<Nota>();
            foreach (string Caminho in Caminhos)
            {
                XmlDocument Documentoxml = new XmlDocument();
                Documentoxml.Load(Caminho);
                Nota Nota = new Nota();

                Nota.NomeDoarquivo = Path.GetFileName(Caminho);
                Nota.Nome = Documentoxml.GetElementsByTagName("xNome").Item(0).InnerText;
                Nota.CNPJ = Documentoxml.GetElementsByTagName("CNPJ").Item(0).InnerText;
                Nota.Data = Convert.ToDateTime(Documentoxml.GetElementsByTagName("dhEmi").Item(0).InnerText).Date;
                Nota.NumeroNota = Documentoxml.GetElementsByTagName("nNF").Item(0).InnerText;
                Nota.Serie = Documentoxml.GetElementsByTagName("serie").Item(0).InnerText;
                List<Produto> produtos = new List<Produto>();
                XmlNodeList CodProduto = Documentoxml.GetElementsByTagName("cProd");
                for (int i = 0; i < CodProduto.Count; i++)
                {
                    Produto produto = new Produto();
                    produto.Codigo = CodProduto[i].InnerText;
                    produto.Descricao = Documentoxml.GetElementsByTagName("xProd")[i].InnerText;
                    produto.Imposto = Documentoxml.GetElementsByTagName("CFOP")[i].InnerText;
                    produto.Quantidade = Documentoxml.GetElementsByTagName("qCom")[i].InnerText;
                    produto.Unidade = Documentoxml.GetElementsByTagName("uCom")[i].InnerText;
                    produto.Valor = Documentoxml.GetElementsByTagName("vUnCom")[i].InnerText;

                    produtos.Add(produto);
                }
                Nota.Produtos = produtos;
                if (verificar.Devolucao(Nota))
                {
                    ListaDeNota.Add(Nota);
                }

            }
            return ListaDeNota;
        }

    }
}
