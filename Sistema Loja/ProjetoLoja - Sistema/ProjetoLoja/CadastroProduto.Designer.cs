namespace ProjetoLoja
{
    partial class CadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            this.btnEditarP = new System.Windows.Forms.Button();
            this.btnFecharP = new System.Windows.Forms.Button();
            this.btnExcluirP = new System.Windows.Forms.Button();
            this.dgvCadastroP = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPesquisaP = new System.Windows.Forms.GroupBox();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.txtBuscaP = new System.Windows.Forms.TextBox();
            this.lblBuscaP = new System.Windows.Forms.Label();
            this.gbCadastroP = new System.Windows.Forms.GroupBox();
            this.lblPreçoP = new System.Windows.Forms.Label();
            this.btnSalvarP = new System.Windows.Forms.Button();
            this.txtPreçoP = new System.Windows.Forms.MaskedTextBox();
            this.lblQuantidadeP = new System.Windows.Forms.Label();
            this.txtQuantidadeP = new System.Windows.Forms.TextBox();
            this.lblDescriçãoP = new System.Windows.Forms.Label();
            this.txtDescriçãoP = new System.Windows.Forms.TextBox();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.lblNomeP = new System.Windows.Forms.Label();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.lblTituloP = new System.Windows.Forms.Label();
            this.pctRimP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroP)).BeginInit();
            this.gbPesquisaP.SuspendLayout();
            this.gbCadastroP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRimP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarP
            // 
            this.btnEditarP.Location = new System.Drawing.Point(12, 536);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(75, 23);
            this.btnEditarP.TabIndex = 4;
            this.btnEditarP.Text = "Editar";
            this.btnEditarP.UseVisualStyleBackColor = true;
            this.btnEditarP.Click += new System.EventHandler(this.btnEditarP_Click);
            // 
            // btnFecharP
            // 
            this.btnFecharP.Location = new System.Drawing.Point(365, 536);
            this.btnFecharP.Name = "btnFecharP";
            this.btnFecharP.Size = new System.Drawing.Size(75, 23);
            this.btnFecharP.TabIndex = 6;
            this.btnFecharP.Text = "Fechar";
            this.btnFecharP.UseVisualStyleBackColor = true;
            this.btnFecharP.Click += new System.EventHandler(this.btnFecharP_Click);
            // 
            // btnExcluirP
            // 
            this.btnExcluirP.Location = new System.Drawing.Point(93, 536);
            this.btnExcluirP.Name = "btnExcluirP";
            this.btnExcluirP.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirP.TabIndex = 5;
            this.btnExcluirP.Text = "Excluir ";
            this.btnExcluirP.UseVisualStyleBackColor = true;
            this.btnExcluirP.Click += new System.EventHandler(this.btnExcluirP_Click);
            // 
            // dgvCadastroP
            // 
            this.dgvCadastroP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Descricao,
            this.Preco,
            this.Quantidade});
            this.dgvCadastroP.Location = new System.Drawing.Point(12, 380);
            this.dgvCadastroP.Name = "dgvCadastroP";
            this.dgvCadastroP.RowTemplate.Height = 25;
            this.dgvCadastroP.Size = new System.Drawing.Size(434, 150);
            this.dgvCadastroP.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ProCodigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "ProNome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 150;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "ProDescricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 300;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "ProPreco";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "ProQuantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 75;
            // 
            // gbPesquisaP
            // 
            this.gbPesquisaP.Controls.Add(this.btnBuscarP);
            this.gbPesquisaP.Controls.Add(this.txtBuscaP);
            this.gbPesquisaP.Controls.Add(this.lblBuscaP);
            this.gbPesquisaP.Location = new System.Drawing.Point(12, 283);
            this.gbPesquisaP.Name = "gbPesquisaP";
            this.gbPesquisaP.Size = new System.Drawing.Size(434, 91);
            this.gbPesquisaP.TabIndex = 2;
            this.gbPesquisaP.TabStop = false;
            this.gbPesquisaP.Text = "Pesquisa";
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(353, 55);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarP.TabIndex = 2;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // txtBuscaP
            // 
            this.txtBuscaP.Location = new System.Drawing.Point(6, 55);
            this.txtBuscaP.Name = "txtBuscaP";
            this.txtBuscaP.Size = new System.Drawing.Size(341, 23);
            this.txtBuscaP.TabIndex = 1;
            // 
            // lblBuscaP
            // 
            this.lblBuscaP.AutoSize = true;
            this.lblBuscaP.Location = new System.Drawing.Point(6, 37);
            this.lblBuscaP.Name = "lblBuscaP";
            this.lblBuscaP.Size = new System.Drawing.Size(38, 15);
            this.lblBuscaP.TabIndex = 0;
            this.lblBuscaP.Text = "Busca";
            // 
            // gbCadastroP
            // 
            this.gbCadastroP.Controls.Add(this.lblPreçoP);
            this.gbCadastroP.Controls.Add(this.btnSalvarP);
            this.gbCadastroP.Controls.Add(this.txtPreçoP);
            this.gbCadastroP.Controls.Add(this.lblQuantidadeP);
            this.gbCadastroP.Controls.Add(this.txtQuantidadeP);
            this.gbCadastroP.Controls.Add(this.lblDescriçãoP);
            this.gbCadastroP.Controls.Add(this.txtDescriçãoP);
            this.gbCadastroP.Controls.Add(this.lblCodigoP);
            this.gbCadastroP.Controls.Add(this.txtNomeP);
            this.gbCadastroP.Controls.Add(this.lblNomeP);
            this.gbCadastroP.Controls.Add(this.txtCodigoP);
            this.gbCadastroP.Location = new System.Drawing.Point(12, 42);
            this.gbCadastroP.Name = "gbCadastroP";
            this.gbCadastroP.Size = new System.Drawing.Size(434, 232);
            this.gbCadastroP.TabIndex = 1;
            this.gbCadastroP.TabStop = false;
            this.gbCadastroP.Text = "Cadastro";
            // 
            // lblPreçoP
            // 
            this.lblPreçoP.AutoSize = true;
            this.lblPreçoP.Location = new System.Drawing.Point(316, 78);
            this.lblPreçoP.Name = "lblPreçoP";
            this.lblPreçoP.Size = new System.Drawing.Size(37, 15);
            this.lblPreçoP.TabIndex = 4;
            this.lblPreçoP.Text = "Preço";
            // 
            // btnSalvarP
            // 
            this.btnSalvarP.Location = new System.Drawing.Point(353, 199);
            this.btnSalvarP.Name = "btnSalvarP";
            this.btnSalvarP.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarP.TabIndex = 10;
            this.btnSalvarP.Text = "Salvar";
            this.btnSalvarP.UseVisualStyleBackColor = true;
            this.btnSalvarP.Click += new System.EventHandler(this.btnSalvarP_Click);
            // 
            // txtPreçoP
            // 
            this.txtPreçoP.Location = new System.Drawing.Point(317, 96);
            this.txtPreçoP.Mask = "$ 00,00";
            this.txtPreçoP.Name = "txtPreçoP";
            this.txtPreçoP.Size = new System.Drawing.Size(111, 23);
            this.txtPreçoP.TabIndex = 5;
            this.txtPreçoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantidadeP
            // 
            this.lblQuantidadeP.AutoSize = true;
            this.lblQuantidadeP.Location = new System.Drawing.Point(317, 137);
            this.lblQuantidadeP.Name = "lblQuantidadeP";
            this.lblQuantidadeP.Size = new System.Drawing.Size(69, 15);
            this.lblQuantidadeP.TabIndex = 6;
            this.lblQuantidadeP.Text = "Quantidade";
            // 
            // txtQuantidadeP
            // 
            this.txtQuantidadeP.Location = new System.Drawing.Point(317, 155);
            this.txtQuantidadeP.Name = "txtQuantidadeP";
            this.txtQuantidadeP.Size = new System.Drawing.Size(111, 23);
            this.txtQuantidadeP.TabIndex = 7;
            // 
            // lblDescriçãoP
            // 
            this.lblDescriçãoP.AutoSize = true;
            this.lblDescriçãoP.Location = new System.Drawing.Point(5, 66);
            this.lblDescriçãoP.Name = "lblDescriçãoP";
            this.lblDescriçãoP.Size = new System.Drawing.Size(58, 15);
            this.lblDescriçãoP.TabIndex = 2;
            this.lblDescriçãoP.Text = "Descrição";
            // 
            // txtDescriçãoP
            // 
            this.txtDescriçãoP.Location = new System.Drawing.Point(6, 84);
            this.txtDescriçãoP.Multiline = true;
            this.txtDescriçãoP.Name = "txtDescriçãoP";
            this.txtDescriçãoP.Size = new System.Drawing.Size(300, 138);
            this.txtDescriçãoP.TabIndex = 3;
            // 
            // lblCodigoP
            // 
            this.lblCodigoP.AutoSize = true;
            this.lblCodigoP.Location = new System.Drawing.Point(316, 20);
            this.lblCodigoP.Name = "lblCodigoP";
            this.lblCodigoP.Size = new System.Drawing.Size(46, 15);
            this.lblCodigoP.TabIndex = 8;
            this.lblCodigoP.Text = "Código";
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(6, 38);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(300, 23);
            this.txtNomeP.TabIndex = 1;
            // 
            // lblNomeP
            // 
            this.lblNomeP.AutoSize = true;
            this.lblNomeP.Location = new System.Drawing.Point(7, 20);
            this.lblNomeP.Name = "lblNomeP";
            this.lblNomeP.Size = new System.Drawing.Size(40, 15);
            this.lblNomeP.TabIndex = 0;
            this.lblNomeP.Text = "Nome";
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(317, 38);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(111, 23);
            this.txtCodigoP.TabIndex = 9;
            this.txtCodigoP.Text = "0";
            this.txtCodigoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoP.Validated += new System.EventHandler(this.txtCodigoP_Validated);
            // 
            // lblTituloP
            // 
            this.lblTituloP.AutoSize = true;
            this.lblTituloP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloP.Location = new System.Drawing.Point(12, 9);
            this.lblTituloP.Name = "lblTituloP";
            this.lblTituloP.Size = new System.Drawing.Size(186, 30);
            this.lblTituloP.TabIndex = 0;
            this.lblTituloP.Text = "Cadastro Produto";
            // 
            // pctRimP
            // 
            this.pctRimP.Image = ((System.Drawing.Image)(resources.GetObject("pctRimP.Image")));
            this.pctRimP.Location = new System.Drawing.Point(355, 0);
            this.pctRimP.Name = "pctRimP";
            this.pctRimP.Size = new System.Drawing.Size(100, 50);
            this.pctRimP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRimP.TabIndex = 7;
            this.pctRimP.TabStop = false;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(456, 565);
            this.Controls.Add(this.pctRimP);
            this.Controls.Add(this.btnEditarP);
            this.Controls.Add(this.btnFecharP);
            this.Controls.Add(this.btnExcluirP);
            this.Controls.Add(this.dgvCadastroP);
            this.Controls.Add(this.gbPesquisaP);
            this.Controls.Add(this.gbCadastroP);
            this.Controls.Add(this.lblTituloP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroP)).EndInit();
            this.gbPesquisaP.ResumeLayout(false);
            this.gbPesquisaP.PerformLayout();
            this.gbCadastroP.ResumeLayout(false);
            this.gbCadastroP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRimP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEditarP;
        private Button btnFecharP;
        private Button btnExcluirP;
        private DataGridView dgvCadastroP;
        private GroupBox gbPesquisaP;
        private Button btnBuscarP;
        private TextBox txtBuscaP;
        private Label lblBuscaP;
        private GroupBox gbCadastroP;
        private Label lblPreçoP;
        private Button btnSalvarP;
        private MaskedTextBox txtPreçoP;
        private Label lblQuantidadeP;
        private TextBox txtQuantidadeP;
        private Label lblDescriçãoP;
        private TextBox txtDescriçãoP;
        private Label lblCodigoP;
        private TextBox txtNomeP;
        private Label lblNomeP;
        private TextBox txtCodigoP;
        private Label lblTituloP;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Quantidade;
        private PictureBox pctRimP;
    }
}