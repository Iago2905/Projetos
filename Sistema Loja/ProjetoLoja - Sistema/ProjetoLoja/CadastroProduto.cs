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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
            BuscarProduto();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void BuscarProduto()
        {

            // Buscar no banco de dados a tabela de especialidade

            ProdutoBd objBd = new ProdutoBd();

            // Verificar o tipo de busca

            string pesquisa = txtBuscaP.Text;
            DataSet tabelaProduto = new DataSet();

            if (string.IsNullOrWhiteSpace(pesquisa))
            {
                // Buscar todos 
                tabelaProduto = objBd.Buscar();
            }
            else
            {
                // Buscar com pesquisa (like)
                tabelaProduto = objBd.Buscar(pesquisa);
            }

            // Preencher o DGV com a tabela

            dgvCadastroP.DataSource = tabelaProduto;
            dgvCadastroP.DataMember = "Produtos";
        }

        private void btnSalvarP_Click(object sender, EventArgs e)
        {
            // Criar o objeto de Produto

            Produto objProduto = new Produto();

            // Preencher objeto com os dados do formulário

            objProduto.ProCodigo = Convert.ToInt32(txtCodigoP.Text);
            objProduto.ProNome = txtNomeP.Text;
            objProduto.ProDescricao = txtDescriçãoP.Text;
            objProduto.ProPreco = txtPreçoP.Text;
            objProduto.ProQuantidade = Convert.ToInt32(txtQuantidadeP.Text);

            // Salvar no banco de dados

            ProdutoBd objBd = new ProdutoBd();

            // Verificar o tipo de operacao incluir ou alterar
            int codigo = 0;
            var valido = int.TryParse(txtCodigoP.Text, out codigo);
            if (!valido)
            {
                MessageBox.Show("Digite um código válido");
                txtCodigoP.Text = "0";
                txtCodigoP.Focus();
                return;
            }
            else if (codigo == 0)
            {
                objBd.Incluir(objProduto);
                MessageBox.Show("Registro incluído com sucesso!");
            }
            else
            {
                objProduto.ProCodigo = codigo;
                objBd.Alterar(objProduto);
                MessageBox.Show("Registro alterado com sucesso!");
            }

            // Iniciar os campos para uma nova operação
            txtCodigoP.Text = "0";
            txtNomeP.Text = "";
            BuscarProduto();
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            BuscarProduto();
        }

        private void btnFecharP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {
            int codigo = 0;

            // Verificar se tem algum registro selecionado no DGV

            if (dgvCadastroP.SelectedRows.Count > 0)
            {
                codigo = Convert.ToInt32(dgvCadastroP.CurrentRow.Cells[0].Value);
                //MessageBox.Show("O código selecionado é:" + codigo);

                // Executa o comando apra obter a especialidade pelo codigo selecionado

                ProdutoBd bd = new ProdutoBd();
                var objProtudo = bd.Obter(codigo);

                // verifica se encontrou a especialidade pelo codigo

                if (objProtudo != null)
                {
                    // Preencher os TextBox com os dados da especialidade 
                    txtCodigoP.Text = objProtudo.ProCodigo.ToString();
                    txtNomeP.Text = objProtudo.ProNome.ToString();
                    txtDescriçãoP.Text = objProtudo.ProDescricao.ToString();
                    txtPreçoP.Text = objProtudo.ProPreco.ToString();
                    txtQuantidadeP.Text = objProtudo.ProQuantidade.ToString();

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

        private void btnExcluirP_Click(object sender, EventArgs e)
        {
            // Verificar se o código foi selecionado

            int codigo = 0;

            if (dgvCadastroP.SelectedRows.Count > 0)
            {
                codigo = Convert.ToInt32(dgvCadastroP.CurrentRow.Cells[0].Value);

                // Perguntar se deseja realmente excluir o registro

                var resposta = MessageBox.Show("Deseja excluir esse registro?", "Atenção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                // Verifica a resposta 
                if (resposta == DialogResult.Yes)
                {
                    // Faz a exclusão do registro no banco de dados

                    ProdutoBd bd = new ProdutoBd();
                    bd.Excluir(codigo);
                    MessageBox.Show("Registro excluído com sucesso!");
                    BuscarProduto();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro da lista");
            }
        }

        private void txtCodigoP_Validated(object sender, EventArgs e)
        {
            //verifica se digitou novo codigo correto
            int codigo;
            bool resultado = int.TryParse(txtCodigoP.Text, out codigo);

            //verifica se digitou um numero valido
            if (resultado)
            {
                ProdutoBd bd = new ProdutoBd();
                var objProduto = bd.Obter(codigo);

                // verifica se encontrou a especialidade pelo codigo
                if (objProduto.ProCodigo > 0)
                {
                    // preecher os textbox com os dados da especialidade
                    txtCodigoP.Text = objProduto.ProCodigo.ToString();
                    txtNomeP.Text = objProduto.ProNome;
                    txtDescriçãoP.Text = objProduto.ProDescricao;
                    txtPreçoP.Text = objProduto.ProPreco;
                    txtQuantidadeP.Text = objProduto.ProQuantidade.ToString();
                    txtNomeP.Focus();
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
                        txtCodigoP.Text = "0";
                        txtNomeP.Focus();
                    }
                    else
                    {
                        // preecher para fazer a alteração
                        txtCodigoP.Text = "0";
                        txtNomeP.Text = "";
                        txtCodigoP.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("Digite um número válido");
                txtCodigoP.Text = "0";
                txtNomeP.Focus();
                txtDescriçãoP.Text = "0";
                txtPreçoP.Text = "0";
                txtQuantidadeP.Text = "0";
                txtNomeP.Focus();
            }
        }
    }

}
