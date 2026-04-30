using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLoja.Dados
{
    internal class VendasBd
    {
        // Caminho de conexão com o banco de dados 
        string Conexao = Properties.Settings.Default.Conexao;

        public Vendas Obter(int codigo)
        {
            // 1) Conexão com o banco de dados 

            SqlConnection sqlConexao = new SqlConnection(Conexao);

            // 2) Definir o comando SQL do banco de dados 

            string sql = "Select *from tbVendas where VenCodigo = @codigo";

            // 3) Definir o comando do banco de dados 

            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexao;                     // configura a conexão 
            sqlComando.CommandType = CommandType.Text;              // tipo do comando 
            sqlComando.CommandText = sql;                           // comando SQL 
            sqlComando.Parameters.AddWithValue("@codigo", codigo);  // adicionando valor para o codigo

            // 4) Executar o comando e tratar o erro caso ocorra

            try
            {

                // Conectar no banco de dados 

                sqlConexao.Open();

                // Ler a tabela e armazenar os dados em memória 

                SqlDataReader tabela = sqlComando.ExecuteReader();

                // Armazenar os dados da tabela no objeto Especialidade 

                Vendas objVendas= new Vendas();

                // Passar os dados da tabela para o pbjeto 

                while (tabela.Read())  // Lendo os dados da tabela em memória 
                {
                    // Passar os dados lidos para o  objeto

                    objVendas.VenCodigo = Convert.ToInt32(tabela["VenCodigo"]);
                    objVendas.CliCodigo = Convert.ToInt32(tabela["CliCodigo"]);
                    objVendas.ProCodigo = Convert.ToInt32(tabela["ProCodigo"]);
                    objVendas.VenData = Convert.ToDateTime(tabela["VenData"]);

                }

                // Retorna com os dados 
                return objVendas;

            }
            catch (Exception erro)
            {
                // Obter a mensagem de erro do banco de dados 
                throw new Exception(erro.Message);
            }
            finally
            {
                // Desconectar do banco de dados 
                sqlConexao.Close();
            }
        }

        public DataSet Buscar()
        {
            // 1) Conexão com o banco de dados 

            SqlConnection sqlConexao = new SqlConnection(Conexao);

            // 2) Definir o comando SQL do banco de dados 

            string sql = "Select *from tbVendas";

            // 3) Definir o comando do banco de dados 

            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexao;             // configura a conexão 
            sqlComando.CommandType = CommandType.Text;      // tipo do comando 
            sqlComando.CommandText = sql;                   // comando SQL 

            try
            {
                // 4) Conectar no banco de dados 

                sqlConexao.Open();

                // 5) Criar o adaptador para executar o comando SQL 

                SqlDataAdapter adaptador = new SqlDataAdapter(sqlComando);

                // 6) Criar a tabela temporária

                DataSet dsTabela = new DataSet();

                // 7) Preencher a tabela ao executar o adaptador 

                adaptador.Fill(dsTabela, "Vendas");

                // 8) Retornar a tabela preenchida
                return dsTabela;

            }
            catch (Exception erro)
            {
                // 9) Obter a mensagem de erro caso ocorra 
                throw new Exception(erro.Message);
            }
            finally
            {
                // 10) Desconectar do banco de dados 
                sqlConexao.Close();
            }

        }

        public DataSet Buscar(string pesquisa)
        {
            // 1) Conexão com o banco de dados 

            SqlConnection sqlConexao = new SqlConnection(Conexao);

            // 2) Definir o comando SQL do banco de dados 

            string sql = "Select *from tbVendas where VenData between @datainicio and @datafim";

            // 3) Definir o comando do banco de dados 

            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexao;                              // configura a conexão 
            sqlComando.CommandType = CommandType.Text;                       // tipo do comando 
            sqlComando.CommandText = sql;                                    // comando SQL 
            sqlComando.Parameters.AddWithValue("@datainicio", pesquisa);       // configurando a pesquisa 
            sqlComando.Parameters.AddWithValue("@datafim", pesquisa);       // configurando a pesquisa 


            try
            {
                // 4) Conectar no banco de dados 

                sqlConexao.Open();

                // 5) Criar o adaptador para executar o comando SQL 

                SqlDataAdapter adaptador = new SqlDataAdapter(sqlComando);

                // 6) Criar a tabela temporária

                DataSet dsTabela = new DataSet();

                // 7) Preencher a tabela ao executar o adaptador 

                adaptador.Fill(dsTabela, "Vendas");

                // 8) Retornar a tabela preenchida
                return dsTabela;

            }
            catch (Exception erro)
            {
                // 9) Obter a mensagem de erro caso ocorra 
                throw new Exception(erro.Message);
            }
            finally
            {
                // 10) Desconectar do banco de dados 
                sqlConexao.Close();
            }

        }

        public void Alterar(Vendas objVendas)
        {
            //1) Definir a conexao com o banco de dados
            SqlConnection sqlConexao = new SqlConnection(Conexao);

            //2) Definir o comando SQL do banco de dados
            string sql = "Update tbVendas Set VenData=@data, CliCodigo=@clicodigo, ProCodigo=@procodigo Where VenCodigo=@vencodigo";

            //3) Definir o camando do banco de dados
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexao; //configura a conexao
            sqlComando.CommandType = CommandType.Text; //tipo de comando
            sqlComando.CommandText = sql; //comando SQL

            //4) Adicionar os parametros (variaveis) do comando SQL

            sqlComando.Parameters.AddWithValue("@data", objVendas.VenData);
            sqlComando.Parameters.AddWithValue("@clicodigo", objVendas.CliCodigo);
            sqlComando.Parameters.AddWithValue("@procodigo", objVendas.ProCodigo);
            sqlComando.Parameters.AddWithValue("@vencodigo", objVendas.VenCodigo);

            //5) Executar o comando
            try
            {
                //6) Conectar no banco de dados
                sqlConexao.Open();
                //7) Executar o comando no banco de dados
                sqlComando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                //8) Obter mensagem de erro do banco de dados
                throw new Exception(erro.Message);
            }
            finally
            {
                //9) Desconectar do banco de dados
                sqlConexao.Close();
            }
        }

        public int Incluir(Vendas objVendas)
        {
            int codigoGerado = 0;
            SqlConnection sqlConexao = new SqlConnection(Conexao);

            string sql = @"insert into tbVendas (CliCodigo, ProCodigo, VenData) output inserted.VenCodigo
                   values (@clicodigo, @procodigo, @data)";

            SqlCommand sqlComando = new SqlCommand(sql, sqlConexao);
            sqlComando.CommandType = CommandType.Text;

            sqlComando.Parameters.AddWithValue("@clicodigo", objVendas.CliCodigo);
            sqlComando.Parameters.AddWithValue("@procodigo", objVendas.ProCodigo);
            sqlComando.Parameters.AddWithValue("@data", objVendas.VenData);

            try
            {
                sqlConexao.Open();
                codigoGerado = (int)sqlComando.ExecuteScalar(); // Captura o VenCodigo
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                sqlConexao.Close();
            }

            return codigoGerado; // Retorna o ID gerado
        }

        public void Excluir(int codigo)
        {
            //1) Definir a conexao com o banco de dados
            SqlConnection sqlConexao = new SqlConnection(Conexao);

            //2) Definir o comando SQL do banco de dados
            string sql = "Delete From tbVendas Where VenCodigo=@codigo";

            //3) Definir o camando do banco de dados
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexao; //configura a conexao
            sqlComando.CommandType = CommandType.Text; //tipo de comando
            sqlComando.CommandText = sql; //comando SQL

            //4) Adicionar os parametros (variaveis) do comando SQL            
            sqlComando.Parameters.AddWithValue("@codigo", codigo);

            //5) Executar o comando
            try
            {
                //6) Conectar no banco de dados
                sqlConexao.Open();
                //7) Executar o comando no banco de dados
                sqlComando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                //8) Obter mensagem de erro do banco de dados
                throw new Exception(erro.Message);
            }
            finally
            {
                //9) Desconectar do banco de dados
                sqlConexao.Close();
            }
        }
    }
}
