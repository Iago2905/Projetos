namespace ProjetoLoja
{
    public partial class PrincipalForms : Form
    {
        public PrincipalForms()
        {
            InitializeComponent();
        }

        private void PrincipalForms_Load(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chamar o formulário de cadastro de produto

            CadastroProduto formulario = new CadastroProduto();

            //Formulário pertence ao PrincipalForm

            formulario.MdiParent = this;

            //Exibe o formulário denttro do PrincipalForm

            formulario.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chamar o formulário de cadastro de cliente

            CadastroCliente formulario = new CadastroCliente();

            //Formulário pertence ao PrincipalForm

            formulario.MdiParent = this;

            //Exibe o formulário denttro do PrincipalForm

            formulario.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Chamar o formulário de cadastro de vendas

            CadastroVendas formulario = new CadastroVendas();

            //Formulário pertence ao PrincipalForm

            formulario.MdiParent = this;

            //Exibe o formulário denttro do PrincipalForm

            formulario.Show();
        }
    }
}