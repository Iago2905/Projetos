using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLoja.Dados;

namespace ProjetoLoja
{
    public partial class CadastroVendas : Form
    {
        public CadastroVendas()
        {
            InitializeComponent();
        }

        private void BuscarVendas()
        {

            // Buscar no banco de dados a tabela de consulta

            VendasBd objBd = new VendasBd();

            // Verificar o tipo de busca 

            string pesquisa = txtBuscaV.Text;
            DataSet tabelaVenda = new DataSet();

            if (string.IsNullOrWhiteSpace(pesquisa))
            {
                // Buscar todos 
                tabelaVenda = objBd.Buscar();
            }
            else
            {
                // Buscar com pesquisa (like)
                tabelaVenda = objBd.Buscar(pesquisa);
            }

            // Preencher o DGV com a tabela 

            dgvCadastroV.DataSource = tabelaVenda;
            dgvCadastroV.DataMember = "Vendas";
        }

        private void btnSalvarV_Click(object sender, EventArgs e)
        {
            Vendas objVendas = new Vendas();

            objVendas.VenCodigo = Convert.ToInt32(txtCodigoV.Text);
            objVendas.CliCodigo = Convert.ToInt32(txtCodigoCV.Text);
            objVendas.ProCodigo = Convert.ToInt32(txtCodigoPV.Text);
            objVendas.VenData = Convert.ToDateTime(txtDataV.Text);

            VendasBd objBd = new VendasBd();

            int codigo = 0;
            var valido = int.TryParse(txtCodigoV.Text, out codigo);
            if (!valido)
            {
                MessageBox.Show("Digite um código válido");
                txtCodigoV.Text = "0";
                txtCodigoV.Focus();
                return;
            }
            else if (codigo == 0)
            {
                int codigoGerado = objBd.Incluir(objVendas);
                MessageBox.Show("Registro incluído com sucesso!");
                txtCodigoV.Text = codigoGerado.ToString();

                CadastroItemVenda formulario = new CadastroItemVenda(codigoGerado);
                formulario.ShowDialog();

                BuscarVendas();
                return;
            }
            else
            {
                objVendas.VenCodigo = codigo;
                objBd.Alterar(objVendas);
                MessageBox.Show("Registro alterado com sucesso!");
            }

            // Se chegou aqui, foi alteração, atualiza lista e limpa código
            txtCodigoV.Text = "0";
            BuscarVendas();
        }

        private void btnBuscarV_Click(object sender, EventArgs e)
        {
            BuscarVendas();
        }

        private void btnEditarV_Click(object sender, EventArgs e)
        {

            int codigo = 0;

            // Verificar se tem algum registro selecionado no DGV 

            if (dgvCadastroV.SelectedRows.Count > 0)
            {
                codigo = Convert.ToInt32(dgvCadastroV.CurrentRow.Cells[0].Value);
                //MessageBox.Show("O código selecionado é:" + codigo);

                // Executa o comando apra obter a especialidade pelo codigo selecionado 

                VendasBd bd = new VendasBd();
                var objVendas = bd.Obter(codigo);

                // verifica se encontrou a especialidade pelo codigo

                if (objVendas != null)
                {
                    // Preencher os TextBox com os dados da especialidade 

                    txtCodigoV.Text = objVendas.VenCodigo.ToString();
                    txtCodigoCV.Text = objVendas.CliCodigo.ToString();
                    txtCodigoPV.Text = objVendas.ProCodigo.ToString();
                    txtDataV.Text = objVendas.VenData.ToString();

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

        private void btnExcluirV_Click(object sender, EventArgs e)
        {

            // Verificar se o código foi selecionado

            int codigo = 0;

            if (dgvCadastroV.SelectedRows.Count > 0)
            {
                codigo = Convert.ToInt32(dgvCadastroV.CurrentRow.Cells[0].Value);

                // Perguntar se deseja realmente excluir o registro 

                var resposta = MessageBox.Show("Deseja excluir esse registro?", "Atenção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                // Verifica a resposta 
                if (resposta == DialogResult.Yes)
                {
                    // Faz a exclusão do registro no banco de dados 

                    VendasBd bd = new VendasBd();
                    bd.Excluir(codigo);
                    MessageBox.Show("Registro excluído com sucesso!");
                    BuscarVendas();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro da lista");
            }
        }

        private void btnFecharV_Click(object sender, EventArgs e)
        {
            // Fechar o formulário
            this.Close();
        }

        private void txtCodigoV_Validated(object sender, EventArgs e)
        {

            //verifica se digitou novo codigo correto
            int codigo;
            bool resultado = int.TryParse(txtCodigoV.Text, out codigo);

            //verifica se digitou um numero valido
            if (resultado)
            {
                VendasBd bd = new VendasBd();
                var objVendas = bd.Obter(codigo);

                // verifica se encontrou a especialidade pelo codigo
                if (objVendas.VenCodigo > 0)
                {
                    // preecher os textbox com os dados da especialidade
                    txtCodigoV.Text = objVendas.VenCodigo.ToString();
                    txtCodigoCV.Text = objVendas.CliCodigo.ToString();
                    txtCodigoPV.Text = objVendas.ProCodigo.ToString();
                    txtDataV.Text = objVendas.VenData.ToString();
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
                        txtCodigoV.Text = "0";
                        txtCodigoV.Focus();
                    }
                    else
                    {
                        // preecher para fazer a alteração
                        txtCodigoV.Text = "0";
                        txtCodigoV.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("Digite um número válido");
                txtCodigoV.Text = "0";
                txtCodigoV.Focus();
            }
        }
    }
}
