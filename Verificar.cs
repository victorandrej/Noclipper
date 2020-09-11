using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoClipper
{
    class Verificar
    {


        public bool Devolucao(Nota nota)
        {
            foreach (Produto produto in nota.Produtos)
            {
                switch (produto.Imposto)
                {
                    case ("5202"):
                        return true;
                    case ("5201"):
                        return true;
                    case ("6202"):
                        return true;
                    case ("6201"):
                        return true;
                    default:
                        return false;
                }

            }
            return false;

        }
        public Produto ProdutoCorreto(Produto produto, List<Produto> produtobanco)
        {

            Comparado Comparado = new Comparado();
            List<Comparado> Comparadolist = Comparado.Comparar(produto.Descricao, produtobanco);
            Comparadolist.Sort((a, b) => b.PorcentagemDeAcerto.CompareTo(a.PorcentagemDeAcerto));

            Produto ProdutoFinal = new Produto();
            try
            {
                ProdutoFinal.Codigo = Convert.ToString(Comparadolist[0].Codigo);
                ProdutoFinal.Descricao = Comparadolist[0].Descricao;
            }
            catch { }
            return ProdutoFinal;
        }
        public List<Nota> NotasComErroDeProduto(List<Nota> Notas, List<Nota> NotasConvertidas)
        {
            List<Nota> NotasComErros = new List<Nota>();
            foreach (Nota nota in Notas)
            {
               
                if (!NotasConvertidas.Exists(a => a.CNPJ == nota.CNPJ && a.Data == nota.Data && a.NumeroNota == nota.NumeroNota))
                    NotasComErros.Add(nota);


            }
            return NotasComErros;
        }
        public List<Cliente> NotasComErroDeCodigoDeParceiro(List<Nota> notas)
        {
            Banco banco = new Banco();
            List<Cliente> Clientes = banco.Clientes();
            List<Cliente> ClientesNaoduplicados = new List<Cliente>();
            List<Cliente> ClientesInexistentes = new List<Cliente>();
            foreach (Nota nota in notas)
            {
                Cliente cliente = new Cliente();
                cliente.Cnpj = nota.CNPJ;
                if (!ClientesNaoduplicados.Exists(a => a.Cnpj == nota.CNPJ))
                    ClientesNaoduplicados.Add(cliente);
            }
            foreach (Cliente cliente1  in ClientesNaoduplicados) {
                Cliente cliente = new Cliente();
                cliente.Cnpj = cliente1.Cnpj;
                if (!Clientes.Exists(a => a.Cnpj == cliente1.Cnpj))
                    ClientesInexistentes.Add(cliente);
            }
            return ClientesInexistentes;


        }
        public List<Nota> NotasNaoCadastradas(List<Nota> notas) {
            Banco banco = new Banco();
            List<Nota> NotasNobanco = banco.NotasExistentesNoBanco(notas);
            List<Nota> NotasNaoCadastradas = new List<Nota>();
            foreach (Nota nota in notas) {
                
                if (!NotasNobanco.Exists(a => a.CNPJ == nota.CNPJ && a.Serie == nota.Serie && a.NumeroNota == nota.NumeroNota)){
                    NotasNaoCadastradas.Add(nota);
                }
            }
            return NotasNaoCadastradas;





        }
       
    }

}


