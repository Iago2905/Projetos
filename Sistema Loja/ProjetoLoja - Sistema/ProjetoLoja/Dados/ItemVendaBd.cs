using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLoja.Dados
{
    internal class ItemVendaBd
    {
        // Caminho de conexão com o banco de dados 
        string Conexao = Properties.Settings.Default.Conexao;

        public ItemVenda Obter(int codigo)
        {
            // 1) Conexão com o banco de dados

            SqlConnection sqlConexao = new SqlConnection(Conexao);

            // 2) Definir o comando SQL do banco de dados

            string sql = "Select *from tbItemVenda where ItemVenCodigo = @codigo";

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

                ItemVenda objItemVenda = new ItemVenda();

                // Passar os dados da tabela para o objeto

                while (tabela.Read())  // Lendo os dados da tabela em memória 
                {
                    // Passar os dados lidos para o objeto

                    objItemVenda.ItemVenCodigo = Convert.ToInt32(tabela["ItemVenCodigo"]);
                    objItemVenda.VenCodigo = Convert.ToInt32(tabela["VenCodigo"]);
                    objItemVenda.ProVenQuantidade = Convert.ToInt32(tabela["ProVenQuantidade"]);
                    objItemVenda.ProPrecoV = tabela["ProPrecoV"].ToString();

                }

                // Retorna com os dados 
                return objItemVenda;

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

            string sql = "Select *from tbItemVenda";

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

                adaptador.Fill(dsTabela, "ItemVenda");

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

            string sql = "Select *from tbItemVenda where VenCodigo like '%'+@pesquisa+'%'; ";

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

                adaptador.Fill(dsTabela, "ItemVenda");

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

        public void Alterar(ItemVenda objItemVenda)
        {
            //1) Definir a conexao com o banco de dados
            SqlConnection sqlConexao = new SqlConnection(Conexao);

            //2) Definir o comando SQL do banco de dados
            string sql = "Update tbItemVenda Set VenCodigo=@codigoV, ProVenQuantidade=@provenquantidade, " +
                "ProPrecoV=@proprecov Where ItemVenCodigo=@codigoIV";

            //3) Definir o camando do banco de dados
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexao; //configura a conexao
            sqlComando.CommandType = CommandType.Text; //tipo de comando
            sqlComando.CommandText = sql; //comando SQL

            //4) Adicionar os parametros (variaveis) do comando SQL

            sqlComando.Parameters.AddWithValue("@codigoIV", objItemVenda.ItemVenCodigo);
            sqlComando.Parameters.AddWithValue("@codigoV", objItemVenda.VenCodigo);
            sqlComando.Parameters.AddWithValue("@provenquantidade", objItemVenda.ProVenQuantidade);
            sqlComando.Parameters.AddWithValue("@proprecov", objItemVenda.ProPrecoV);

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

        public void Incluir(ItemVenda objItemVenda)
        {

            // 1) Conexão com o banco de dados

            SqlConnection sqlConexao = new SqlConnection(Conexao);

            // 2) Definir o comando SQL do banco de dados

            string sql = "Insert into tbItemVenda (VenCodigo, ProVenQuantidade, ProPrecoV) values(@vencodigo,@provenquantidade,@proprecov)";

            // 3) Definir o comando do banco de dados

            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexao;             // configura a conexão 
            sqlComando.CommandType = CommandType.Text;      // tipo do comando 
            sqlComando.CommandText = sql;                   // comando SQL

            // 4) Adicionar os parâmetros (variáveis) do comando SQL

            sqlComando.Parameters.AddWithValue("@vencodigo", objItemVenda.VenCodigo);
            sqlComando.Parameters.AddWithValue("@provenquantidade", objItemVenda.ProVenQuantidade);
            sqlComando.Parameters.AddWithValue("@proprecov", objItemVenda.ProPrecoV);

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
            string sql = "Delete From tbItemVenda Where ItemVenCodigo=@codigo";

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
