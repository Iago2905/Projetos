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
using ProjetoLojaPro;

namespace ProjetoLoja
{
    public partial class CadastroItemVenda : Form
    {
        public CadastroItemVenda()
        {
            InitializeComponent();
            BuscarItemVenda();
        }
        public CadastroItemVenda(int codigoVenda)
        {
            InitializeComponent();
            txtCodigoVV.Text = codigoVenda.ToString();
            txtCodigoVV.ReadOnly = true;
        }

        private void BuscarItemVenda()
        {

            // Buscar no banco de dados a tabela de especialidade

            ItemVendaBd objBd = new ItemVendaBd();

            // Verificar o tipo de busca

            string pesquisa = txtBuscaIV.Text;
            DataSet tabelaItemVenda = new DataSet();

            if (string.IsNullOrWhiteSpace(pesquisa))
            {
                // Buscar todos 
                tabelaItemVenda = objBd.Buscar();
            }
            else
            {
                // Buscar com pesquisa (like)
                tabelaItemVenda = objBd.Buscar(pesquisa);
            }

            // Preencher o DGV com a tabela

            dgvCadastroIV.DataSource = tabelaItemVenda;
            dgvCadastroIV.DataMember = "ItemVenda";
        }

        private void btnSalvarIV_Click(object sender, EventArgs e)
        {
            // Criar o objeto de Produto

            ItemVenda objItemVenda = new ItemVenda();

            // Preencher objeto com os dados do formulário

            objItemVenda.ItemVenCodigo = Convert.ToInt32(txtCodigoIV.Text);
            objItemVenda.VenCodigo = Convert.ToInt32(txtCodigoVV.Text);
            objItemVenda.ProVenQuantidade = Convert.ToInt32(txtProVenQuantidade.Text);
            objItemVenda.ProPrecoV = txtProPrecoV.Text;

            // Salvar no banco de dados

            ItemVendaBd objBd = new ItemVendaBd();

            // Verificar o tipo de operacao incluir ou alterar
            int codigo = 0;
            var valido = int.TryParse(txtCodigoIV.Text, out codigo);
            if (!valido)
            {
                MessageBox.Show("Digite um código válido");
                txtCodigoIV.Text = "0";
                txtCodigoIV.Focus();
                return;
            }
            else if (codigo == 0)
            {
                objBd.Incluir(objItemVenda);
                MessageBox.Show("Registro incluído com sucesso!");
            }
            else
            {
                objItemVenda.ItemVenCodigo = codigo;
                objBd.Alterar(objItemVenda);
                MessageBox.Show("Registro alterado com sucesso!");
            }

            // Iniciar os campos para uma nova operação
            txtCodigoIV.Text = "0";
            txtCodigoVV.Text = "0";
            BuscarItemVenda();
        }

        private void btnBuscarIV_Click(object sender, EventArgs e)
        {
            BuscarItemVenda();
        }

        private void btnEditarIV_Click(object sender, EventArgs e)
        {
            int codigo = 0;

            // Verificar se tem algum registro selecionado no DGV

            if (dgvCadastroIV.SelectedRows.Count > 0)
            {
                codigo = Convert.ToInt32(dgvCadastroIV.CurrentRow.Cells[0].Value);

                // Executa o comando apra obter a especialidade pelo codigo selecionado

                ItemVendaBd bd = new ItemVendaBd();
                var objItemVenda = bd.Obter(codigo);

                // verifica se encontrou a especialidade pelo codigo

                if (objItemVenda != null)
                {
                    // Preencher os TextBox com os dados da especialidade 
                    txtCodigoIV.Text = objItemVenda.ItemVenCodigo.ToString();
                    txtCodigoVV.Text = objItemVenda.VenCodigo.ToString();
                    txtProPrecoV.Text = objItemVenda.ProPrecoV.ToString();
                    txtProVenQuantidade.Text = objItemVenda.ProVenQuantidade.ToString();
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

        private void btnExcluirIV_Click(object sender, EventArgs e)
        {// Verificar se o código foi selecionado

            int codigo = 0;

            if (dgvCadastroIV.SelectedRows.Count > 0)
            {
                codigo = Convert.ToInt32(dgvCadastroIV.CurrentRow.Cells[0].Value);

                // Perguntar se deseja realmente excluir o registro

                var resposta = MessageBox.Show("Deseja excluir esse registro?", "Atenção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                // Verifica a resposta 
                if (resposta == DialogResult.Yes)
                {
                    // Faz a exclusão do registro no banco de dados

                    ItemVendaBd bd = new ItemVendaBd();
                    bd.Excluir(codigo);
                    MessageBox.Show("Registro excluído com sucesso!");
                    BuscarItemVenda();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro da lista");
            }
        }

        private void btnFecharIV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoIV_Validated(object sender, EventArgs e)
        {
            //verifica se digitou novo codigo correto
            int codigo;
            bool resultado = int.TryParse(txtCodigoIV.Text, out codigo);

            //verifica se digitou um numero valido
            if (resultado)
            {
                ItemVendaBd bd = new ItemVendaBd();
                var objItemVenda = bd.Obter(codigo);

                // verifica se encontrou a especialidade pelo codigo
                if (objItemVenda.ItemVenCodigo > 0)
                {
                    // preecher os textbox com os dados da especialidade
                    txtCodigoIV.Text = objItemVenda.ItemVenCodigo.ToString();
                    txtCodigoVV.Text = objItemVenda.VenCodigo.ToString();
                    txtProPrecoV.Text = objItemVenda.ProPrecoV;
                    txtProVenQuantidade.Text = objItemVenda.ProVenQuantidade.ToString();
                    txtCodigoVV.Focus();
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
                        txtCodigoIV.Text = "0";
                        txtCodigoVV.Focus();
                    }
                    else
                    {
                        // preecher para fazer a alteração
                        txtCodigoIV.Text = "0";
                        txtCodigoVV.Text = "0";
                        txtCodigoIV.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("Digite um número válido");
                txtCodigoIV.Text = "0";
                txtCodigoVV.Focus();
                txtProPrecoV.Text = "0";
                txtProVenQuantidade.Text = "0";
                txtCodigoVV.Focus();
            }
        }

        private void txtCodigoIV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

