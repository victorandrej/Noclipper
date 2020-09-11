using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoClipper
{
    class Comparado
    {


        public double PorcentagemDeAcerto { get; set; }
        public string Descricao { get; set; }
        public int Codigo { get; set; }
      
        public List<Comparado> Comparar(string DescricaoComparador, List<Produto> produtos)
        {
            List<Comparado> ComparadoList = new List<Comparado>();
            foreach (Produto produto in produtos)
            {
                Comparado comparado = new Comparado();
                DescricaoComparador = DescricaoComparador.Replace(" ", "");
                produto.Descricao = produto.Descricao.Replace(" ", "");
                List<bool> Verdadeiros = new List<bool>();
                List<bool> Falsos = new List<bool>();

                
                    for (int i = 0; i < (produto.Descricao.Length ); i = i + 2)
                    {
                        string BlocoDeComparacao = "";

                        if (i < produto.Descricao.Length && i + 1 < produto.Descricao.Length && i + 2 < produto.Descricao.Length && i + 5 < produto.Descricao.Length)
                        {
                            BlocoDeComparacao = "" + produto.Descricao[i] + produto.Descricao[i + 1] + produto.Descricao[i + 2];
                        }
                        else if (i < produto.Descricao.Length && i + 1 < produto.Descricao.Length && i + 2 < produto.Descricao.Length && i + 4 < produto.Descricao.Length)
                        {

                            BlocoDeComparacao = "" + produto.Descricao[i] + produto.Descricao[i + 1] + produto.Descricao[i + 2] + produto.Descricao[i + 3] + produto.Descricao[i + 4];

                        }
                        else if (i < DescricaoComparador.Length && i + 1 < produto.Descricao.Length && i + 2 < produto.Descricao.Length && i + 3 < produto.Descricao.Length)
                        {

                            BlocoDeComparacao = "" + produto.Descricao[i] + produto.Descricao[i + 1] + produto.Descricao[i + 2] + produto.Descricao[i + 3];

                        }

                        if (DescricaoComparador.Contains(BlocoDeComparacao) == true)
                        {
                            Verdadeiros.Add(true);
                        }
                        else { Falsos.Add(false); }

                    }



                comparado.PorcentagemDeAcerto = (Convert.ToDouble(Verdadeiros.Count) / (Convert.ToDouble(Verdadeiros.Count) + Convert.ToDouble(Falsos.Count)));
                comparado.Descricao = produto.Descricao;
                comparado.Codigo = Convert.ToInt32(produto.Codigo);
                if(( comparado.Descricao.Length <= (produto.Descricao.Length + DescricaoComparador.Length) / 2 +2) && (comparado.Descricao.Length >= (produto.Descricao.Length + DescricaoComparador.Length) / 2 -2)) { 
                ComparadoList.Add(comparado);
                }
            }


            return ComparadoList;
        }


    }


}


