using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoClipper
{
    class Converter
    {

        public List<Nota> ProdutoConvertido(List<Nota> Notas)
        {
            Banco banco = new Banco();

            List<Nota> NotasConvertidas = new List<Nota>();

            foreach (Nota nota in Notas)
            {
                List<ProdutosDobanco> Produtosdobanco = banco.ProdutosDocnpj(nota.CNPJ.Remove(8));
                Verificar verificar = new Verificar();
                Nota Notaconvertida = new Nota();
                Notaconvertida.CNPJ = nota.CNPJ;
                Notaconvertida.Data = nota.Data;
                Notaconvertida.Nome = nota.Nome;
                Notaconvertida.NumeroNota = nota.NumeroNota;
               

                    List<Produto> ListaDeProdutosConvertidos = new List<Produto>();
                    foreach (Produto produto in nota.Produtos)
                    {
                        Produto produtoconvertido = new Produto();

                        foreach (ProdutosDobanco produtosDobanco in Produtosdobanco)
                        {
                            if ((Produtosdobanco.Count != 0) && produto.Codigo == produtosDobanco.CodCliente && produto.Descricao == produtosDobanco.DescricaoCliente)
                            {

                                produtoconvertido.Quantidade = produto.Quantidade;
                                produtoconvertido.Unidade = produto.Unidade;
                                produtoconvertido.Valor = produto.Valor;
                                produtoconvertido.Codigo = produtosDobanco.CodJfc;
                                produtoconvertido.Descricao = produtosDobanco.DescricaoJfc;
                                produtoconvertido.Kilagem = produtosDobanco.Kilagem;
                                produtoconvertido.Imposto = produto.Imposto;
                                ListaDeProdutosConvertidos.Add(produtoconvertido);
                                break;
                            }
                        }

                    }
                    if (ListaDeProdutosConvertidos.Count == nota.Produtos.Count)
                    {
                        Notaconvertida.Produtos = ListaDeProdutosConvertidos;
                        NotasConvertidas.Add(Notaconvertida);
                    }
                

            }
            return NotasConvertidas;
        }
        public List<Nota> CnpjConvertido(List<Nota> Notas)
        {
            Banco banco = new Banco();
            for (int i = 0; i < Notas.Count; i++)
                Notas[i].CodigoJFcPareciro = banco.ClientePorCNPJ(Notas[i].CNPJ).CodJfc;
            return Notas;
        }

    }
}

