using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LojaProjeto;
using ProjetoLoja.Dados;

namespace ProjetoLoja
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            // Buscar no banco de dados a tabela de cliente

            ClienteBd objCliente = new ClienteBd();

            // Verificar o tipo de busca

            string pesquisa = txtBuscaC.Text;
            DataSet tabelaCliente = new DataSet();

            if (string.IsNullOrWhiteSpace(pesquisa))
            {
                // Buscar todos 
                tabelaCliente = objCliente.Buscar();
            }
            else
            {
                // Buscar com pesquisa (like)
                tabelaCliente = objCliente.Buscar(pesquisa);
            }

            // Preencher o DGV com a tabela

            dgvCadastroC.DataSource = tabelaCliente;
            dgvCadastroC.DataMember = "Clientes";
        }

        private void btnSalvarC_Click(object sender, EventArgs e)
        {
            // Criar o objeto de cliente

            Cliente objCliente = new Cliente();

            // Preencher objeto com os dados do formulário

            objCliente.CliNome = txtNomeC.Text;
            objCliente.CliEndereco = txtEnderecoC.Text;
            objCliente.CliNumero = Convert.ToInt32(txtNumeroC.Text);
            objCliente.CliEmail = txtEmailC.Text;
            objCliente.CliTelefone = txtTelefoneC.Text;


            // Salvar no banco de dados

            ClienteBd objBd = new ClienteBd();

            // Verificar o tipo de operacao incluir ou alterar
            int codigo = 0;
            var valido = int.TryParse(txtCodigoC.Text, out codigo);
            if (!valido)
            {
                MessageBox.Show("Digite um código válido");
                txtCodigoC.Text = "0";
                txtCodigoC.Focus();
                return;
            }
            else if (codigo == 0)
            {
                objBd.Incluir(objCliente);
                MessageBox.Show("Registro incluído com sucesso");
            }
            else
            {
                objCliente.CliCodigo = codigo;
                objBd.Alterar(objCliente);
                MessageBox.Show("Registro alterado com sucesso");
            }

            // Iniciar os campos para uma nova operação
            txtCodigoC.Text = "0";
            txtNomeC.Text = "";
            BuscarCliente();
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btnFecharC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarC_Click_1(object sender, EventArgs e)
        {

            int codigo = 0;

            // Verificar se tem algum registro selecionado no DGV

            if (dgvCadastroC.SelectedRows.Count > 0)
            {
                codigo = Convert.ToInt32(dgvCadastroC.CurrentRow.Cells[0].Value);
                //MessageBox.Show("O código selecionado é:" + codigo);

                // Executa o comando para obter o cliente pelo codigo selecionado

                ClienteBd bd = new ClienteBd();
                var objCliente = bd.Obter(codigo);

                // verifica se encontrou o cliente pelo codigo

                if (objCliente != null)
                {
                    // Preencher os TextBox com os dados do cliente 
                    txtCodigoC.Text = objCliente.CliCodigo.ToString();
                    txtNomeC.Text = objCliente.CliNome.ToString();
                    txtEnderecoC.Text = objCliente.CliEndereco.ToString();
                    txtNumeroC.Text = objCliente.CliNumero.ToString();
                    txtEmailC.Text = objCliente.CliEmail.ToString();
                    txtTelefoneC.Text = objCliente.CliTelefone.ToString();

                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                }

            }
            else
            {
                MessageBox.Show("Selecione um registro da lista");
            }
        }

        private void btnExcluirC_Click(object sender, EventArgs e)
        {

            // Verificar se o código foi selecionado

            int codigo = 0;

            if (dgvCadastroC.SelectedRows.Count > 0)
            {
                codigo = Convert.ToInt32(dgvCadastroC.CurrentRow.Cells[0].Value);

                // Perguntar se deseja realmente excluir o registro

                var resposta = MessageBox.Show("Deseja excluir esse registro?", "Atenção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                // Verifica a resposta 
                if (resposta == DialogResult.Yes)
                {
                    // Faz a exclusão do registro no banco de dados

                    ClienteBd bd = new ClienteBd();
                    bd.Excluir(codigo);
                    MessageBox.Show("Registro excluído com sucesso!");
                    BuscarCliente();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro da lista");
            }
        }

        private void txtCodigoC_Validated(object sender, EventArgs e)
        {
            //verifica se digitou novo codigo correto
            int codigo;
            bool resultado = int.TryParse(txtCodigoC.Text, out codigo);

            //verifica se digitou um numero valido
            if (resultado)
            {
                ClienteBd bd = new ClienteBd();
                var objCliente = bd.Obter(codigo);

                // verifica se encontrou o cliente pelo codigo
                if (objCliente.CliCodigo > 0)
                {
                    // preecher os textbox com os dados do cliente
                    txtCodigoC.Text = objCliente.CliCodigo.ToString();
                    txtNomeC.Text = objCliente.CliNome;
                    txtEnderecoC.Text = objCliente.CliEndereco;
                    txtNumeroC.Text = objCliente.CliNumero.ToString();
                    txtEmailC.Text = objCliente.CliEmail;
                    txtTelefoneC.Text = objCliente.CliTelefone;
                    txtNomeC.Focus();
                }
                else
                {
                    var escolha = MessageBox.Show(
                        "Registro não foi encontrado, deseja incluir um novo?",
                        "Atenção",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (escolha == DialogResult.Yes)
                    {
                        // preecher para fazer a inclusão
                        txtCodigoC.Text = "0";
                        txtNomeC.Focus();
                    }
                    else
                    {
                        // preecher para fazer a alteração
                        txtCodigoC.Text = "0";
                        txtNomeC.Text = "";
                        txtCodigoC.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("Digite um número válido");
                txtNomeC.Text = "";
                txtCodigoC.Text = "0";
                txtCodigoC.Focus();
            }
        }
    }
}
