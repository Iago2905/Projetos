using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaProjeto;

namespace ProjetoLoja.Dados
{
    internal class ClienteBd
    {
        // Caminho de conexão com o banco de dados 
        string Conexao = Properties.Settings.Default.Conexao;

        public Cliente Obter(int codigo)
        {
            // 1) Conexão com o banco de dados

            SqlConnection sqlConexao = new SqlConnection(Conexao);

            // 2) Definir o comando SQL do banco de dados

            string sql = "Select *from tbCliente where CliCodigo = @codigo";

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

                Cliente objCliente = new Cliente();

                // Passar os dados da tabela para o pbjeto

                while (tabela.Read())  // Lendo os dados da tabela em memória 
                {
                    // Passar os dados lidos para o  objeto

                    objCliente.CliCodigo = Convert.ToInt32(tabela["CliCodigo"]);
                    objCliente.CliNome = tabela["CliNome"].ToString();
                    objCliente.CliEndereco = tabela["CliEndereco"].ToString();
                    objCliente.CliNumero = Convert.ToInt32(tabela["CliNumero"]);
                    objCliente.CliEmail = tabela["CliEmail"].ToString();
                    objCliente.CliTelefone = tabela["CliTelefone"].ToString();

                }

                // Retorna com os dados 
                return objCliente;

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

            string sql = "Select *from tbCliente";

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

                adaptador.Fill(dsTabela, "Clientes");

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

            string sql = "Select *from tbCliente where CliNome like '%'+@pesquisa+'%'; ";

            // 3) Definir o comando do banco de dados

            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexao;                              // configura a conexão 
            sqlComando.CommandType = CommandType.Text;                       // tipo do comando 
            sqlComando.CommandText = sql;                                    // comando SQL 
            sqlComando.Parameters.AddWithValue("@pesquisa", pesquisa);       // configurando a pesquisa

            try
            {
                // 4) Conectar no banco de dados

                sqlConexao.Open();

                // 5) Criar o adaptador para executar o comando SQL

                SqlDataAdapter adaptador = new SqlDataAdapter(sqlComando);

                // 6) Criar a tabela temporária

                DataSet dsTabela = new DataSet();

                // 7) Preencher a tabela ao executar o adaptador

                adaptador.Fill(dsTabela, "Clientes");

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

        public void Alterar(Cliente objCliente)
        {
            //1) Definir a conexao com o banco de dados
            SqlConnection sqlConexao = new SqlConnection(Conexao);

            //2) Definir o comando SQL do banco de dados
            string sql = "Update tbCliente Set CliNome=@nome, CliEndereco=@endereco, CliNumero=@numero, " +
                "CliEmail=@email, CliTelefone=@telefone Where CliCodigo=@codigo";

            //3) Definir o camando do banco de dados
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexao; //configura a conexao
            sqlComando.CommandType = CommandType.Text; //tipo de comando
            sqlComando.CommandText = sql; //comando SQL

            //4) Adicionar os parametros (variaveis) do comando SQL

            sqlComando.Parameters.AddWithValue("@nome", objCliente.CliNome);
            sqlComando.Parameters.AddWithValue("@codigo", objCliente.CliCodigo);
            sqlComando.Parameters.AddWithValue("@endereco", objCliente.CliEndereco);
            sqlComando.Parameters.AddWithValue("@numero", objCliente.CliNumero);
            sqlComando.Parameters.AddWithValue("@email", objCliente.CliEmail);
            sqlComando.Parameters.AddWithValue("@telefone", objCliente.CliTelefone);

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

        public void Incluir(Cliente objCliente)
        {
            // 1) Conexão com o banco de dados

            SqlConnection sqlConexao = new SqlConnection(Conexao);

            // 2) Definir o comando SQL do banco de dados

            string sql = "Insert into tbCliente (CliNome, CliEndereco, CliNumero, CliEmail, CliTelefone) " +
                "values(@nome, @endereco, @numero, @email, @telefone)";

            // 3) Definir o comando do banco de dados

            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexao;             // configura a conexão 
            sqlComando.CommandType = CommandType.Text;      // tipo do comando 
            sqlComando.CommandText = sql;                   // comando SQL

            // 4) Adicionar os parâmetros (variáveis) do comando SQL

            sqlComando.Parameters.AddWithValue("@nome", objCliente.CliNome);
            sqlComando.Parameters.AddWithValue("@endereco", objCliente.CliEndereco);
            sqlComando.Parameters.AddWithValue("@numero", objCliente.CliNumero);
            sqlComando.Parameters.AddWithValue("@email", objCliente.CliEmail);
            sqlComando.Parameters.AddWithValue("@telefone", objCliente.CliTelefone);

            // 5) Executar o comando

            try
            {
                // 6) Conectar o banco de dados

                sqlConexao.Open();

                // 7) Executar o comando no banco de dados

                sqlComando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                // 8) Obter mensagem de erro do banco de dados 
                throw new Exception(erro.Message);
            }
            finally
            {
                // 9) Desconectar do banco de dados 
                sqlConexao.Close();
            }

        }

        public void Excluir(int codigo)
        {
            //1) Definir a conexao com o banco de dados
            SqlConnection sqlConexao = new SqlConnection(Conexao);

            //2) Definir o comando SQL do banco de dados
            string sql = "Delete From tbCliente Where CliCodigo=@codigo";

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
