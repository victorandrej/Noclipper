using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace NoClipper
{
    class Banco
    {


        public Banco()
        {


        }

        private MySqlConnection Conexaosql()
        {
            Servidor servidor = new Servidor();
            string conexao = $"server={servidor.Endereco};Database={servidor.BancoDeDados};port={servidor.PortaServidor};uid={servidor.Usuario};pwd={servidor.SenhaUsuario}";
            MySqlConnection sqlConnection = new MySqlConnection(conexao);
            return sqlConnection;
        }

        public Usuario Usuario(string usuario)
        {
            MySqlConnection Conexao = Conexaosql();


            string Comando = $"Select * from usuarios where usuario = '{usuario}'";
            using (MySqlCommand ComandoSql = new MySqlCommand(Comando, Conexao))
            {
                Conexao.Open();
                MySqlDataReader sqlDataReader = ComandoSql.ExecuteReader();
                Usuario usuario1 = new Usuario();
                sqlDataReader.Read();
                try
                {
                    usuario1.root = Convert.ToBoolean(sqlDataReader["root"]);
                    usuario1.CadastrarClientes = Convert.ToBoolean(sqlDataReader["CadastrarClientes"]);
                    usuario1.CadastrarProdutosJfc = Convert.ToBoolean(sqlDataReader["CadastrarProdutosJfc"]);
                    usuario1.CadastrarProdutosMatriz = Convert.ToBoolean(sqlDataReader["CadastrarProdutosMatriz"]);
                    usuario1.CadastroClienteRapido = Convert.ToBoolean(sqlDataReader["CadastroClienteRapido"]);
                    usuario1.CriarUsuarios = Convert.ToBoolean(sqlDataReader["CriarUsuarios"]);
                    usuario1.ExportarArquivos = Convert.ToBoolean(sqlDataReader["ExportarArquivos"]);
                    usuario1.ModificarServidor = Convert.ToBoolean(sqlDataReader["ModificarServidor"]);
                    usuario1.Senha = sqlDataReader["senha"].ToString();
                    usuario1.Nome = usuario;
                    ;
                    return usuario1;
                }
                catch
                {
                    return usuario1;
                }

            }


        }
        public void ApagarUsuario(string usuario, Usuario usuariologado)
        {
            string data = DateTime.Now.ToShortDateString();
            Logs logs = new Logs();
            logs.usuario = usuariologado;
            logs.data = data;
            logs.Evento = $"Usuario {usuario} excluido";

            using (MySqlConnection Conexao = Conexaosql())
            {


                string Comando = $"Delete from usuarios where usuario = @usuario";
                using (MySqlCommand ComandoSql = new MySqlCommand(Comando, Conexao))
                {
                    ComandoSql.Parameters.AddWithValue("usuario", usuario);
                    Conexao.Open();
                    ComandoSql.ExecuteNonQuery();
                    logsgenericos(logs);
                    
                }
            }

        }
        public void EditarUsuario(Usuario usuario, Usuario usuariologado)
        {
            MySqlConnection Conexao = Conexaosql();

            string data = DateTime.Now.ToShortDateString();
            Logs logs = new Logs();
            logs.usuario = usuariologado;
            logs.data = data;
            logs.Evento = $"Usuario {usuario.Nome} editado";
            string comando = "update  usuarios set " +
                " senha = @senha, CadastrarProdutosMatriz = @CadastrarProdutosMatriz, " +
                "CadastrarProdutosJfc = @CadastrarProdutosJfc, CadastrarClientes = @CadastrarClientes, " +
                "CadastroClienteRapido =  @CadastroClienteRapido, CriarUsuarios = @CriarUsuarios," +
                " ExportarArquivos = @ExportarArquivos where usuario = @usuario";
            using (MySqlCommand mySqlCommand = new MySqlCommand(comando, Conexao))
            {
                mySqlCommand.Parameters.AddWithValue("senha", usuario.Senha);
                mySqlCommand.Parameters.AddWithValue("usuario", usuario.Nome);
                mySqlCommand.Parameters.AddWithValue("CadastrarProdutosMatriz", usuario.CadastrarProdutosMatriz);
                mySqlCommand.Parameters.AddWithValue("CadastrarProdutosJfc", usuario.CadastrarProdutosJfc);
                mySqlCommand.Parameters.AddWithValue("CadastrarClientes", usuario.CadastrarClientes);
                mySqlCommand.Parameters.AddWithValue("CadastroClienteRapido", usuario.CadastroClienteRapido);
                mySqlCommand.Parameters.AddWithValue("CriarUsuarios", usuario.CriarUsuarios);
                mySqlCommand.Parameters.AddWithValue("ExportarArquivos", usuario.ExportarArquivos);
                Conexao.Open();
                mySqlCommand.ExecuteNonQuery();
                logsgenericos(logs);
             
            }


        }
        public List<Usuario> Usuario()
        {
            MySqlConnection Conexao = Conexaosql();


            string Comando = $"Select * from usuarios";
            using (MySqlCommand ComandoSql = new MySqlCommand(Comando, Conexao))
            {
                Conexao.Open();
                MySqlDataReader sqlDataReader = ComandoSql.ExecuteReader();

                List<Usuario> usuarios = new List<Usuario>();


                while (sqlDataReader.Read())
                {
                    Usuario usuario1 = new Usuario();
                    usuario1.CadastrarClientes = Convert.ToBoolean(sqlDataReader["CadastrarClientes"]);
                    usuario1.CadastrarProdutosJfc = Convert.ToBoolean(sqlDataReader["CadastrarProdutosJfc"]);
                    usuario1.CadastrarProdutosMatriz = Convert.ToBoolean(sqlDataReader["CadastrarProdutosMatriz"]);
                    usuario1.CadastroClienteRapido = Convert.ToBoolean(sqlDataReader["CadastroClienteRapido"]);
                    usuario1.CriarUsuarios = Convert.ToBoolean(sqlDataReader["CriarUsuarios"]);
                    usuario1.ExportarArquivos = Convert.ToBoolean(sqlDataReader["ExportarArquivos"]);
                    usuario1.ModificarServidor = Convert.ToBoolean(sqlDataReader["ModificarServidor"]);
                    usuario1.Senha = sqlDataReader["senha"].ToString();
                    usuario1.Nome = sqlDataReader["usuario"].ToString();
                    usuario1.root = Convert.ToBoolean(sqlDataReader["root"]);
                    usuarios.Add(usuario1);
                }

                return usuarios;


            }


        }
        public List<ProdutosDobanco> ProdutosDocnpj(string cnpj)
        {
            List<ProdutosDobanco> produtosDobancos = new List<ProdutosDobanco>();
            MySqlConnection MySqlConnection = Conexaosql();
            string ComandoSql = "select  CodProdMatriz, DescricaoProdCliente, CodProdJfc, DescricaoProdJfc, kilagem from produtosdasmatrizes where matriz = @cnpj";

            using (MySqlCommand mySqlCommand = new MySqlCommand(ComandoSql, MySqlConnection))
            {
                mySqlCommand.Parameters.AddWithValue("cnpj", cnpj);
                MySqlConnection.Open();
                using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                {

                    while (mySqlDataReader.Read())
                    {
                        ProdutosDobanco produto = new ProdutosDobanco();
                        produto.CodCliente = mySqlDataReader["CodProdMatriz"].ToString();
                        produto.CodJfc = mySqlDataReader["CodProdJfc"].ToString();
                        produto.DescricaoCliente = mySqlDataReader["DescricaoProdCliente"].ToString();
                        produto.DescricaoJfc = mySqlDataReader["DescricaoProdJfc"].ToString();
                        produto.Kilagem = mySqlDataReader["kilagem"].ToString();
                        produtosDobancos.Add(produto);
                    }
                }
            }
            MySqlConnection.Close();
            return produtosDobancos;

        }
        public bool AdicionarProdutoJfc(string Codigo, string Descricao, string kilagem, Usuario usuario)
        {
            if (Convert.ToDouble(kilagem) <= 0)
                kilagem = "1";
            MySqlConnection conexao = Conexaosql();
            string comando = "insert into produtosjfc (Codigojfc, Descricao, kilagem) values (@CodigoJfc, @Descricao, @Kilagem)";
            using (MySqlCommand mysqlcomando = new MySqlCommand(comando, conexao))
            {
                string data = DateTime.Now.ToShortDateString();
                mysqlcomando.Parameters.AddWithValue("CodigoJfc", Codigo);
                mysqlcomando.Parameters.AddWithValue("Descricao", Descricao);
                mysqlcomando.Parameters.AddWithValue("Kilagem", kilagem);
                conexao.Open();
                try
                {
                    mysqlcomando.ExecuteNonQuery();
                    Logs logs = new Logs();
                    logs.data = data;
                    logs.usuario = usuario;
                    logs.Evento = $"Produto JFC {Codigo + "|" + Descricao} adicionado ";
                    logsgenericos(logs);
                    return true;
                }
                catch { return false; }
            }

        }
        public void AdicionarProdutosMatrizes(ProdutosDobanco produto, Usuario usuariologado)
        {
            string data = DateTime.Now.ToShortDateString();
            Logs logs = new Logs();
            logs.usuario = usuariologado;
            logs.data = data;


            MySqlConnection connection = Conexaosql();
            string comando = "insert into produtosdasmatrizes(matriz,CodProdMatriz,DescricaoProdCliente,CodProdJfc,DescricaoProdJfc, kilagem)" +
                " values(@matriz, @codProdMatriz, @DescricaoProdCliente, @codProdjfc , @DescricaoProdJfc, @kilagem)";

            using (MySqlCommand comandosql = new MySqlCommand(comando, connection))
            {

                connection.Open();
                comandosql.Parameters.AddWithValue("matriz", produto.Matriz);
                comandosql.Parameters.AddWithValue("codProdMatriz", produto.CodCliente);
                comandosql.Parameters.AddWithValue("DescricaoProdCliente", produto.DescricaoCliente);
                comandosql.Parameters.AddWithValue("codProdjfc", produto.CodJfc);
                comandosql.Parameters.AddWithValue("DescricaoProdJfc", produto.DescricaoJfc);
                comandosql.Parameters.AddWithValue("kilagem", produto.Kilagem);
                logs.Evento = $"ProdutoMatriz {produto.CodCliente + "|" + produto.DescricaoCliente} da matriz {produto.Matriz}  adicionado";
                logsgenericos(logs);
                comandosql.ExecuteNonQuery();



            }




        }

        public List<ProdutosDobanco> ProdutosCadastradosjfc()
        {

            MySqlConnection conexao = Conexaosql();
            string ComandoSql = "Select * from produtosjfc";
            using (MySqlCommand Comando = new MySqlCommand(ComandoSql, conexao))
            {
                conexao.Open();
                MySqlDataReader mySqlDataReader = Comando.ExecuteReader();
                List<ProdutosDobanco> produtos = new List<ProdutosDobanco>();

                while (mySqlDataReader.Read())
                {
                    ProdutosDobanco produtosDobanco = new ProdutosDobanco();
                    produtosDobanco.CodJfc = mySqlDataReader["CodigoJfc"].ToString();
                    produtosDobanco.DescricaoJfc = mySqlDataReader["Descricao"].ToString();
                    produtosDobanco.Kilagem = mySqlDataReader["Kilagem"].ToString();

                    produtos.Add(produtosDobanco);


                }
                return produtos;


            }
        }
        public bool EditarProdutosJFc(string NovoCodigo, string NOVODescricao, String NOVOKilagem, string Codigo, string Descricao, string Kilagem, Usuario usuario)
        {
            string data = DateTime.Now.ToShortDateString();
            Logs logs = new Logs();
            logs.usuario = usuario;
            logs.data = data;
            logs.Evento = $"Produto Jfc {Codigo} editado por {usuario.Nome}";
            if (Convert.ToDouble(NOVOKilagem) <= 0)
                NOVOKilagem = "1";
            string comando = "update produtosjfc set CodigoJfc = @Novocodigo , Descricao = @NovoDescricao, Kilagem = @NovoKilagem where CodigoJfc = @VelhoCodigo and Descricao  = @VelhaDescricao and Kilagem = @velhaKilagem";
            MySqlConnection mySqlConnection = Conexaosql();
            using (MySqlCommand mySqlCommand = new MySqlCommand(comando, mySqlConnection))
            {
                mySqlCommand.Parameters.AddWithValue("Novocodigo", NovoCodigo);
                mySqlCommand.Parameters.AddWithValue("NovoDescricao", NOVODescricao);
                mySqlCommand.Parameters.AddWithValue("NovoKilagem", NOVOKilagem);
                mySqlCommand.Parameters.AddWithValue("VelhoCodigo", Codigo);
                mySqlCommand.Parameters.AddWithValue("VelhaDescricao", Descricao);
                mySqlCommand.Parameters.AddWithValue("velhaKilagem", Kilagem);
                mySqlConnection.Open();
                try
                {
                    mySqlCommand.ExecuteNonQuery();
                    logsgenericos(logs);
                    return true;
                }
                catch { return false; }

            }




        }
        public bool ExcluirProdutosJfc(string Codigo, Usuario usuario)
        {
            string data = DateTime.Now.ToShortDateString();
            Logs logs = new Logs();
            logs.usuario = usuario;
            logs.data = data;
            logs.Evento = $"Produto Jfc {Codigo} apagado por {usuario.Nome}";
            MySqlConnection connection = Conexaosql();
            String comando = "delete from produtosjfc where Codigojfc =  @codigo";
            using (MySqlCommand mySqlCommand = new MySqlCommand(comando, connection))
            {
                connection.Open();
                mySqlCommand.Parameters.AddWithValue("codigo", Codigo);
                try
                {
                    mySqlCommand.ExecuteNonQuery();
                    logsgenericos(logs);
                    return true;
                }
                catch
                {
                    return false;
                }
            }


        }
        public List<ProdutosDobanco> ProdutosDasMatrizes()
        {

            using (MySqlConnection connection = Conexaosql())
            {
                string comando = "select * from produtosdasmatrizes";
                using (MySqlCommand mySqlCommand = new MySqlCommand(comando, connection))
                {

                    connection.Open();
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    List<ProdutosDobanco> produtosDobancos = new List<ProdutosDobanco>();
                    while (mySqlDataReader.Read())
                    {
                        ProdutosDobanco produtosDobanco = new ProdutosDobanco();
                        produtosDobanco.CodCliente = mySqlDataReader["CodProdMatriz"].ToString();
                        produtosDobanco.DescricaoCliente = mySqlDataReader["DescricaoProdCliente"].ToString();
                        produtosDobanco.CodJfc = mySqlDataReader["CodProdJfc"].ToString();
                        produtosDobanco.DescricaoJfc = mySqlDataReader["DescricaoProdJfc"].ToString();
                        produtosDobanco.Matriz = mySqlDataReader["matriz"].ToString();
                        produtosDobancos.Add(produtosDobanco);
                    }
                    return produtosDobancos;



                }
            }




        }
        public void EditarProdutosMatrizes(List<ProdutosDobanco> ProdutosEditados, Usuario usuario)
        {
            string data = DateTime.Now.ToShortDateString();
            MySqlConnection mySqlConnection = Conexaosql();
            string comando = "update produtosdasmatrizes set CodProdJfc = @CodigoJfc , DescricaoProdJfc = @DescricaoProJfc" +
                    " where matriz = @Matriz and CodProdMatriz = @CodProdmatriz and DescricaoProdCliente = @DescricaoProdCliente";
            {

                mySqlConnection.Open();
                foreach (ProdutosDobanco produtos in ProdutosEditados)
                {
                    using (MySqlCommand mySqlCommand = new MySqlCommand(comando, mySqlConnection))
                    {
                        mySqlCommand.Parameters.AddWithValue("DescricaoProdCliente", produtos.DescricaoCliente);
                        mySqlCommand.Parameters.AddWithValue("CodigoJfc", produtos.CodJfc);
                        mySqlCommand.Parameters.AddWithValue("DescricaoProJfc", produtos.DescricaoJfc);
                        mySqlCommand.Parameters.AddWithValue("Matriz", produtos.Matriz);
                        mySqlCommand.Parameters.AddWithValue("CodProdmatriz", produtos.CodCliente);
                        mySqlCommand.ExecuteNonQuery();
                        Logs logs = new Logs();
                        logs.data = data;
                        logs.usuario = usuario;
                        logs.Evento = $"Produto {produtos.CodCliente + "|" + produtos.DescricaoCliente} Editado da matriz {produtos.Matriz} ";
                        logsgenericos(logs);
                    }
                }
                mySqlConnection.Close();
              
            }

        }
        public void ApagarProdutosMatrizes(List<ProdutosDobanco> Produtosapagados, Usuario usuario)
        {
            string data = DateTime.Now.ToShortDateString();
            MySqlConnection mySqlConnection = Conexaosql();
            string comando = "delete from produtosdasmatrizes " +
                    " where matriz = @Matriz and CodProdMatriz = @CodProdmatriz and DescricaoProdCliente = @DescricaoProdMatriz";


            mySqlConnection.Open();
            foreach (ProdutosDobanco produtos in Produtosapagados)
            {
                using (MySqlCommand mySqlCommand = new MySqlCommand(comando, mySqlConnection))
                {
                    mySqlCommand.Parameters.AddWithValue("DescricaoProdMatriz", produtos.DescricaoCliente);
                    mySqlCommand.Parameters.AddWithValue("Matriz", produtos.Matriz);
                    mySqlCommand.Parameters.AddWithValue("CodProdmatriz", produtos.CodCliente);
                    Logs logs = new Logs();
                    logs.data = data;
                    logs.usuario = usuario;
                    logs.Evento = $"Produto {produtos.CodCliente + "|" + produtos.DescricaoCliente} Apagado da matriz {produtos.Matriz} ";
                    logsgenericos(logs);
                    mySqlCommand.ExecuteNonQuery();
                }
            }
            mySqlConnection.Close();
            
        }
        public void AdicionarClientes(string Cnpj, string CodJFc, Usuario usuario)
        {
            string data = DateTime.Now.ToShortDateString();
            Logs logs = new Logs();
            logs.usuario = usuario;
            logs.data = data;
            logs.Evento = $"Cliente {Cnpj} de codigigo JFC {CodJFc} adicionado";
            MySqlConnection connection = Conexaosql();
            string comando = "insert into clientes(Cnpj, codigojfc) values(@cnpj, @Codigojfc)";
            using (MySqlCommand mySqlCommand = new MySqlCommand(comando, connection))
            {
                connection.Open();
                mySqlCommand.Parameters.AddWithValue("cnpj", Cnpj);
                mySqlCommand.Parameters.AddWithValue("Codigojfc", CodJFc);
                mySqlCommand.ExecuteNonQuery();
                logsgenericos(logs);
               
            }

        }
        public void ApagarClientes(string Cnpj, string CodJFc, Usuario usuario)
        {
            string data = DateTime.Now.ToShortDateString();
            Logs logs = new Logs();
            logs.usuario = usuario;
            logs.data = data;
            logs.Evento = $"Cliente {Cnpj} de codigigo JFC {CodJFc} apagado";
            MySqlConnection connection = Conexaosql();
            string comando = "delete from clientes where  Cnpj = @cnpj and codigojfc =  @Codigojfc";
            using (MySqlCommand mySqlCommand = new MySqlCommand(comando, connection))
            {
                connection.Open();
                mySqlCommand.Parameters.AddWithValue("cnpj", Cnpj);
                mySqlCommand.Parameters.AddWithValue("Codigojfc", CodJFc);
                mySqlCommand.ExecuteNonQuery();
                logsgenericos(logs);
                
            }

        }
        public List<Cliente> Clientes()
        {
            MySqlConnection connection = Conexaosql();
            string comando = "select * from clientes";
            using (MySqlCommand mySqlCommand = new MySqlCommand(comando, connection))
            {
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                while (mySqlDataReader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Cnpj = mySqlDataReader["Cnpj"].ToString();
                    cliente.CodJfc = mySqlDataReader["codigojfc"].ToString();
                    clientes.Add(cliente);
                }

                return clientes;
            }



        }
        public Cliente ClientePorCNPJ(string cnpj)

        {
            Cliente cliente = new Cliente();
            using (MySqlConnection connection = Conexaosql())
            {

                connection.Open();
                string comando = "select * from clientes where Cnpj = @cnpj";
                using (MySqlCommand mySqlCommand = new MySqlCommand(comando, connection))
                {

                    mySqlCommand.Parameters.AddWithValue("cnpj", cnpj);
                    using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                    {

                        while (mySqlDataReader.Read())
                        {
                            cliente.Cnpj = mySqlDataReader["Cnpj"].ToString();
                            cliente.CodJfc = mySqlDataReader["codigojfc"].ToString();
                        }


                    }
                    return cliente;
                }

            }

        }
        public void TestarConexao()
        {


            using (MySqlConnection connection = Conexaosql())
                connection.Open();



        }
        public void Adicionarusuario(Usuario usuario, Usuario usuariologado)
        {
            string data = DateTime.Now.ToShortDateString();
            Logs logs = new Logs();
            logs.usuario = usuariologado;
            logs.data = data;
            logs.Evento = $"Usuario {usuario.Nome} adicionado";
            MySqlConnection connection = Conexaosql();
            string comando = "insert into usuarios(`usuario`, `senha`, `CadastrarProdutosMatriz`, `CadastrarProdutosJfc`, `CadastrarClientes`, `CadastroClienteRapido`, `CriarUsuarios`, `ExportarArquivos` , ModificarServidor,root)" +
                " values(@usuario,@senha,@CadastrarProdutosMatriz,@CadastrarProdutosJfc,@CadastrarClientes,@CadastroClienteRapido,@CriarUsuarios,@ExportarArquivos,0,0)";
            using (MySqlCommand mySqlCommand = new MySqlCommand(comando, connection))
            {
                connection.Open();
                mySqlCommand.Parameters.AddWithValue("senha", usuario.Senha);
                mySqlCommand.Parameters.AddWithValue("usuario", usuario.Nome);
                mySqlCommand.Parameters.AddWithValue("CadastrarProdutosMatriz", usuario.CadastrarProdutosMatriz);
                mySqlCommand.Parameters.AddWithValue("CadastrarProdutosJfc", usuario.CadastrarProdutosJfc);
                mySqlCommand.Parameters.AddWithValue("CadastrarClientes", usuario.CadastrarClientes);
                mySqlCommand.Parameters.AddWithValue("CadastroClienteRapido", usuario.CadastroClienteRapido);
                mySqlCommand.Parameters.AddWithValue("CriarUsuarios", usuario.CriarUsuarios);
                mySqlCommand.Parameters.AddWithValue("ExportarArquivos", usuario.ExportarArquivos);
                mySqlCommand.ExecuteNonQuery();
                logsgenericos(logs);
                
            }

        }
        public void SalvarNotasNoBanco(List<Nota> notas, Usuario usuario)
        {
            string data = DateTime.Now.ToShortDateString();
            using (MySqlConnection mySqlConnection = Conexaosql())
            {
                mySqlConnection.Open();
                foreach (Nota nota in notas)
                {
                    string salvarNota = "insert into notasexportadas(`NumeroNota`, `cnpj`, `Datadanota`, `Serie`, `usuario`, `Pendente`)" +
                    $" values('{nota.NumeroNota}', '{nota.CNPJ}', '{nota.Data.ToShortDateString()}', '{nota.Serie}','{usuario.Nome}', 1)";
                    using (MySqlCommand SalvarNota = new MySqlCommand())
                    {
                        SalvarNota.Connection = mySqlConnection;
                        SalvarNota.CommandText = salvarNota;
                        Logs logs = new Logs();
                        logs.data = data;
                        logs.usuario = usuario;
                        logs.Evento = $"Nota {nota.NumeroNota} de serie {nota.Serie} da data {nota.Data.ToShortDateString()} do cliente {nota.CNPJ} importada";
                        logsgenericos(logs);
                        SalvarNota.ExecuteNonQuery();
                        foreach (Produto produto in nota.Produtos)
                        {
                            string SalvarProdutos = "insert into notasexportadasproduto(`Cnpj`, `NumeroDeNota`, `DataDaNota`, `Usuario`, `CodigoProduto`, `DescricaoProduto`, `Pendente`, Serie, `Quantidade`, `Unidade`, `Preco`)" +
               $" values('{nota.CNPJ}', '{nota.NumeroNota}', '{nota.Data.ToShortDateString()}', '{usuario.Nome}', '{produto.Codigo}', '{produto.Descricao}', '1', '{nota.Serie}', '{produto.Quantidade}', '{produto.Unidade}', '{produto.Valor}')";
                            SalvarNota.CommandText = SalvarProdutos;
                            SalvarNota.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        public List<Nota> NotasExistentesNoBanco(List<Nota> notas)
        {
            MySqlConnection connection = Conexaosql();
            string NumeroNotas = "";
            string Series = "";
            string CNPjs = "";

            for (int i = 0; i < notas.Count; i++)
            {
                if (i < notas.Count - 1)
                {
                    NumeroNotas = NumeroNotas + notas[i].NumeroNota + ",";
                    Series = Series + notas[i].Serie + ",";
                    CNPjs = CNPjs + notas[i].CNPJ + ",";
                }
                else
                {
                    NumeroNotas = NumeroNotas + notas[i].NumeroNota;
                    Series = Series + notas[i].Serie;
                    CNPjs = CNPjs + notas[i].CNPJ;
                }
            }
            string comando = $"select * from notasexportadas where NumeroNota in({NumeroNotas}) and Serie in({Series}) and cnpj in ({CNPjs})";
            using (MySqlCommand mySqlCommand = new MySqlCommand(comando, connection))
            {
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                List<Nota> Notasnosistema = new List<Nota>();
                while (mySqlDataReader.Read())
                {
                    Nota nota = new Nota();
                    nota.NumeroNota = mySqlDataReader["NumeroNota"].ToString();
                    nota.Serie = mySqlDataReader["Serie"].ToString();
                    nota.CNPJ = mySqlDataReader["cnpj"].ToString();
                    Notasnosistema.Add(nota);
                }
                return Notasnosistema;
            }

        }
        public bool ExisteExportacao()
        {
            MySqlConnection connection = Conexaosql();
            string comando = "select Pendente First from notasexportadas where Pendente = 1";
            using (MySqlCommand command = new MySqlCommand(comando, connection))
            {
                connection.Open();
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    return true;
                }
                return false;
            }

        }
        public List<Nota> NotasPendentes()
        {
            List<Nota> notas = new List<Nota>();
            using (MySqlConnection connection = Conexaosql())
            {

                string Notascomando = "select * from `notasexportadas` where `Pendente` = true";

                using (MySqlCommand mySqlCommand = new MySqlCommand(Notascomando, connection))
                {
                    connection.Open();
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        Nota nota = new Nota();
                        nota.Serie = mySqlDataReader["Serie"].ToString();
                        nota.CNPJ = mySqlDataReader["cnpj"].ToString();
                        nota.Data = Convert.ToDateTime(mySqlDataReader["Datadanota"]);
                        nota.NumeroNota = mySqlDataReader["NumeroNota"].ToString();

                        string ProdutosComando = $"select * from `notasexportadasproduto` where `NumeroDeNota` = {nota.NumeroNota} " +
                    $"and `Serie` = {nota.Serie} and `Cnpj` = {nota.CNPJ}";
                        using (MySqlConnection connection2 = Conexaosql())
                        {
                            MySqlCommand mySqlCommand2 = new MySqlCommand(ProdutosComando, connection2);
                            connection2.Open();
                            MySqlDataReader mySqlDataReaderProduto = mySqlCommand2.ExecuteReader();
                            while (mySqlDataReaderProduto.Read())
                            {
                                Produto produto = new Produto();
                                produto.Codigo = mySqlDataReaderProduto["CodigoProduto"].ToString();
                                produto.Descricao = mySqlDataReaderProduto["DescricaoProduto"].ToString();
                                produto.Quantidade = mySqlDataReaderProduto["Quantidade"].ToString();
                                produto.Unidade = mySqlDataReaderProduto["Unidade"].ToString();
                                produto.Valor = mySqlDataReaderProduto["Preco"].ToString();
                                nota.Produtos.Add(produto);
                            }
                        }

                        notas.Add(nota);

                    }
                }
                return notas;




            }



        }
        public void TirarPendencia()
        {
            using (MySqlConnection mySqlConnection = Conexaosql())
            {
                string comando = "update `notasexportadas` set `Pendente` = false where `Pendente` = true; update `notasexportadasproduto` set `Pendente` = false where `Pendente` = true";

                using (MySqlCommand mySqlCommand = new MySqlCommand(comando, mySqlConnection))
                {
                    mySqlConnection.Open();
                    mySqlCommand.ExecuteNonQuery();

                }
            }

        }
        public void logsgenericos(Logs logs)
        {

            using (MySqlConnection mySqlConnection = Conexaosql())
            {
                string comando = "insert into Logs(usuario,evento,data) values(@usuario,@evento,@data)";

                using (MySqlCommand mySqlCommand = new MySqlCommand(comando, mySqlConnection))
                {
                    mySqlCommand.Parameters.AddWithValue("usuario", logs.usuario.Nome);
                    mySqlCommand.Parameters.AddWithValue("evento", logs.Evento);
                    mySqlCommand.Parameters.AddWithValue("data", logs.data);
                    mySqlConnection.Open();
                    mySqlCommand.ExecuteNonQuery();

                }
            }
        }
        public void AlterarSenha(Usuario usuarioNovo)
        {
            using (MySqlConnection connection = Conexaosql())
            {
                string comando = "update `usuarios` set senha = @senha where usuario = @usuario";
                connection.Open();
                using (MySqlCommand comandosql = new MySqlCommand(comando, connection))
                {
                    comandosql.Parameters.AddWithValue("senha", usuarioNovo.Senha);
                    comandosql.Parameters.AddWithValue("usuario", usuarioNovo.Nome);

                    comandosql.ExecuteNonQuery();




                }



            }



        }
        public void AdicionarCFOP(string CFOP, string Descricao)
        {

            using (MySqlConnection connection = Conexaosql())
            {

                string comando = "insert into CFOp(Cfop,descricao) values(@Cfop,@descricao)";
                connection.Open();
                using (MySqlCommand comandosql = new MySqlCommand(comando, connection))
                {
                    comandosql.Parameters.AddWithValue("Cfop", CFOP);
                    comandosql.Parameters.AddWithValue("descricao", Descricao);
                    comandosql.ExecuteNonQuery();
                }



            }

        }
        public void ApagarCFOP(string CFOP)
        {

            using (MySqlConnection connection = Conexaosql())
            {

                string comando = "delete from CFOp  where cfop = @cfop";
                connection.Open();
                using (MySqlCommand comandosql = new MySqlCommand(comando, connection))
                {
                    comandosql.Parameters.AddWithValue("cfop", CFOP);
                    comandosql.ExecuteNonQuery();
                }



            }


        }

        public List<CfopObjeto> Cfops()
        {

            using (MySqlConnection connection = Conexaosql())
            {

                string comando = "select * from cfop";
                connection.Open();
                using (MySqlCommand comandosql = new MySqlCommand(comando, connection))
                {
                    MySqlDataReader mySqlDataReader = comandosql.ExecuteReader();
                    List<CfopObjeto> cfopObjetos = new List<CfopObjeto>();
                    while (mySqlDataReader.Read())
                    {
                        CfopObjeto cfopObjeto = new CfopObjeto();
                        cfopObjeto.Cfop = mySqlDataReader["cfop"].ToString();
                        cfopObjeto.Descricao = mySqlDataReader["descricao"].ToString();
                        cfopObjetos.Add(cfopObjeto);
                    }
                    return cfopObjetos;
                }



            }


        }
    }

}


