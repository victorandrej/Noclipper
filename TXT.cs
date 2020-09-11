using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace NoClipper
{
    class TXT
    {
        public TXT() { }

        public void CriarTxtFormatoJFc(List<Nota> notas, string caminho, Usuario usuario)
        {
            Banco banco = new Banco();

            using (StreamWriter streamWriter = new StreamWriter(caminho))
            {
                Logs logs = new Logs();
                logs.usuario = usuario;
                logs.data = DateTime.Now.ToShortDateString();

                foreach (Nota nota in notas)
                {
                    foreach (Produto produto in nota.Produtos)
                    {
                        if (produto.Unidade == "KG")
                        {
                            if (Convert.ToInt32((Convert.ToDouble(produto.Quantidade, new CultureInfo("en-US")) / Convert.ToDouble(produto.Kilagem, new CultureInfo("pt-br")))) == 0)
                            {
                                produto.Quantidade = 1.ToString();
                            }
                            else
                            {
                                produto.Quantidade = Convert.ToInt32((Convert.ToDouble(produto.Quantidade, new CultureInfo("en-US")) / Convert.ToDouble(produto.Kilagem, new CultureInfo("pt-br")))).ToString(); ;
                            }

                            produto.Unidade = "UN";
                        }
                        streamWriter.WriteLine(nota.Data.ToString("yyyymmdd") + "01" + String.Format("{0,3:000}", Convert.ToInt32(produto.Codigo))
                            + String.Format("{0,6:000000}", Convert.ToInt32(nota.CodigoJFcPareciro)) + " 5202" + String.Format("{0,6:000000}", Convert.ToInt32(Convert.ToDouble(produto.Quantidade, new CultureInfo("en-US")))) +
                            "               50115001001   5020210   20100  " + String.Format(new CultureInfo("en-US"), "{0,12:000000000.00}", Convert.ToDouble(produto.Valor, new CultureInfo("en-US"))) + "                                        " +
                           "000000000." + String.Format("{0:000000000}", Convert.ToInt32(nota.NumeroNota)));
                    }
                    logs.Evento = $"Nota {nota.NumeroNota} de serie {nota.Serie} da data {nota.Data.ToShortDateString()} do cliente {nota.CNPJ}  exportada";

                    banco.logsgenericos(logs);
                }





            }



        }
    }
}
