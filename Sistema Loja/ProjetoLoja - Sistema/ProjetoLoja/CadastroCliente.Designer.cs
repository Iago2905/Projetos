namespace ProjetoLoja
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.btnEditarC = new System.Windows.Forms.Button();
            this.btnFecharC = new System.Windows.Forms.Button();
            this.dgvCadastroC = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPesquisaC = new System.Windows.Forms.GroupBox();
            this.lblBuscaC = new System.Windows.Forms.Label();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.txtBuscaC = new System.Windows.Forms.TextBox();
            this.gbCadastroC = new System.Windows.Forms.GroupBox();
            this.txtTelefoneC = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneC = new System.Windows.Forms.Label();
            this.txtEmailC = new System.Windows.Forms.TextBox();
            this.lblEmailC = new System.Windows.Forms.Label();
            this.txtNumeroC = new System.Windows.Forms.TextBox();
            this.lblNumeroC = new System.Windows.Forms.Label();
            this.txtEnderecoC = new System.Windows.Forms.TextBox();
            this.lnlEnderecoC = new System.Windows.Forms.Label();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.txtCodigoC = new System.Windows.Forms.TextBox();
            this.lblNomeC = new System.Windows.Forms.Label();
            this.lblCodigoC = new System.Windows.Forms.Label();
            this.btnSalvarC = new System.Windows.Forms.Button();
            this.lblTituloC = new System.Windows.Forms.Label();
            this.btnExcluirC = new System.Windows.Forms.Button();
            this.pctRimC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroC)).BeginInit();
            this.gbPesquisaC.SuspendLayout();
            this.gbCadastroC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRimC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarC
            // 
            this.btnEditarC.Location = new System.Drawing.Point(18, 498);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.Size = new System.Drawing.Size(75, 23);
            this.btnEditarC.TabIndex = 4;
            this.btnEditarC.Text = "Editar";
            this.btnEditarC.UseVisualStyleBackColor = true;
            this.btnEditarC.Click += new System.EventHandler(this.btnEditarC_Click_1);
            // 
            // btnFecharC
            // 
            this.btnFecharC.Location = new System.Drawing.Point(392, 499);
            this.btnFecharC.Name = "btnFecharC";
            this.btnFecharC.Size = new System.Drawing.Size(75, 23);
            this.btnFecharC.TabIndex = 6;
            this.btnFecharC.Text = "Fechar";
            this.btnFecharC.UseVisualStyleBackColor = true;
            this.btnFecharC.Click += new System.EventHandler(this.btnFecharC_Click);
            // 
            // dgvCadastroC
            // 
            this.dgvCadastroC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Endereco,
            this.Numero,
            this.Email,
            this.Telefone});
            this.dgvCadastroC.Location = new System.Drawing.Point(18, 329);
            this.dgvCadastroC.Name = "dgvCadastroC";
            this.dgvCadastroC.RowTemplate.Height = 25;
            this.dgvCadastroC.Size = new System.Drawing.Size(449, 163);
            this.dgvCadastroC.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CliCodigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 60;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "CliNome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 200;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "CliEndereco";
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.Width = 200;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "CliNumero";
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.Width = 60;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "CliEmail";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "CliTelefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // gbPesquisaC
            // 
            this.gbPesquisaC.Controls.Add(this.lblBuscaC);
            this.gbPesquisaC.Controls.Add(this.btnBuscarC);
            this.gbPesquisaC.Controls.Add(this.txtBuscaC);
            this.gbPesquisaC.Location = new System.Drawing.Point(18, 245);
            this.gbPesquisaC.Name = "gbPesquisaC";
            this.gbPesquisaC.Size = new System.Drawing.Size(449, 78);
            this.gbPesquisaC.TabIndex = 2;
            this.gbPesquisaC.TabStop = false;
            this.gbPesquisaC.Text = "Pesquisa";
            // 
            // lblBuscaC
            // 
            this.lblBuscaC.AutoSize = true;
            this.lblBuscaC.Location = new System.Drawing.Point(6, 29);
            this.lblBuscaC.Name = "lblBuscaC";
            this.lblBuscaC.Size = new System.Drawing.Size(38, 15);
            this.lblBuscaC.TabIndex = 0;
            this.lblBuscaC.Text = "Busca";
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Location = new System.Drawing.Point(368, 46);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarC.TabIndex = 2;
            this.btnBuscarC.Text = "Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // txtBuscaC
            // 
            this.txtBuscaC.Location = new System.Drawing.Point(6, 47);
            this.txtBuscaC.Name = "txtBuscaC";
            this.txtBuscaC.Size = new System.Drawing.Size(356, 23);
            this.txtBuscaC.TabIndex = 1;
            // 
            // gbCadastroC
            // 
            this.gbCadastroC.Controls.Add(this.txtTelefoneC);
            this.gbCadastroC.Controls.Add(this.lblTelefoneC);
            this.gbCadastroC.Controls.Add(this.txtEmailC);
            this.gbCadastroC.Controls.Add(this.lblEmailC);
            this.gbCadastroC.Controls.Add(this.txtNumeroC);
            this.gbCadastroC.Controls.Add(this.lblNumeroC);
            this.gbCadastroC.Controls.Add(this.txtEnderecoC);
            this.gbCadastroC.Controls.Add(this.lnlEnderecoC);
            this.gbCadastroC.Controls.Add(this.txtNomeC);
            this.gbCadastroC.Controls.Add(this.txtCodigoC);
            this.gbCadastroC.Controls.Add(this.lblNomeC);
            this.gbCadastroC.Controls.Add(this.lblCodigoC);
            this.gbCadastroC.Controls.Add(this.btnSalvarC);
            this.gbCadastroC.Location = new System.Drawing.Point(18, 42);
            this.gbCadastroC.Name = "gbCadastroC";
            this.gbCadastroC.Size = new System.Drawing.Size(449, 197);
            this.gbCadastroC.TabIndex = 1;
            this.gbCadastroC.TabStop = false;
            this.gbCadastroC.Text = "Cadastro";
            // 
            // txtTelefoneC
            // 
            this.txtTelefoneC.Location = new System.Drawing.Point(334, 135);
            this.txtTelefoneC.Mask = "(99) 00000-0000";
            this.txtTelefoneC.Name = "txtTelefoneC";
            this.txtTelefoneC.Size = new System.Drawing.Size(109, 23);
            this.txtTelefoneC.TabIndex = 9;
            this.txtTelefoneC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelefoneC
            // 
            this.lblTelefoneC.AutoSize = true;
            this.lblTelefoneC.Location = new System.Drawing.Point(334, 117);
            this.lblTelefoneC.Name = "lblTelefoneC";
            this.lblTelefoneC.Size = new System.Drawing.Size(51, 15);
            this.lblTelefoneC.TabIndex = 8;
            this.lblTelefoneC.Text = "Telefone";
            // 
            // txtEmailC
            // 
            this.txtEmailC.Location = new System.Drawing.Point(6, 135);
            this.txtEmailC.Name = "txtEmailC";
            this.txtEmailC.Size = new System.Drawing.Size(322, 23);
            this.txtEmailC.TabIndex = 7;
            // 
            // lblEmailC
            // 
            this.lblEmailC.AutoSize = true;
            this.lblEmailC.Location = new System.Drawing.Point(6, 117);
            this.lblEmailC.Name = "lblEmailC";
            this.lblEmailC.Size = new System.Drawing.Size(36, 15);
            this.lblEmailC.TabIndex = 6;
            this.lblEmailC.Text = "Email";
            // 
            // txtNumeroC
            // 
            this.txtNumeroC.Location = new System.Drawing.Point(334, 87);
            this.txtNumeroC.Name = "txtNumeroC";
            this.txtNumeroC.Size = new System.Drawing.Size(109, 23);
            this.txtNumeroC.TabIndex = 5;
            // 
            // lblNumeroC
            // 
            this.lblNumeroC.AutoSize = true;
            this.lblNumeroC.Location = new System.Drawing.Point(334, 69);
            this.lblNumeroC.Name = "lblNumeroC";
            this.lblNumeroC.Size = new System.Drawing.Size(51, 15);
            this.lblNumeroC.TabIndex = 4;
            this.lblNumeroC.Text = "Número";
            // 
            // txtEnderecoC
            // 
            this.txtEnderecoC.Location = new System.Drawing.Point(6, 91);
            this.txtEnderecoC.Name = "txtEnderecoC";
            this.txtEnderecoC.Size = new System.Drawing.Size(322, 23);
            this.txtEnderecoC.TabIndex = 3;
            // 
            // lnlEnderecoC
            // 
            this.lnlEnderecoC.AutoSize = true;
            this.lnlEnderecoC.Location = new System.Drawing.Point(6, 69);
            this.lnlEnderecoC.Name = "lnlEnderecoC";
            this.lnlEnderecoC.Size = new System.Drawing.Size(56, 15);
            this.lnlEnderecoC.TabIndex = 2;
            this.lnlEnderecoC.Text = "Endereço";
            // 
            // txtNomeC
            // 
            this.txtNomeC.Location = new System.Drawing.Point(6, 40);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(322, 23);
            this.txtNomeC.TabIndex = 1;
            // 
            // txtCodigoC
            // 
            this.txtCodigoC.Location = new System.Drawing.Point(334, 40);
            this.txtCodigoC.Name = "txtCodigoC";
            this.txtCodigoC.Size = new System.Drawing.Size(109, 23);
            this.txtCodigoC.TabIndex = 11;
            this.txtCodigoC.Text = "0";
            this.txtCodigoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoC.Validated += new System.EventHandler(this.txtCodigoC_Validated);
            // 
            // lblNomeC
            // 
            this.lblNomeC.AutoSize = true;
            this.lblNomeC.Location = new System.Drawing.Point(6, 22);
            this.lblNomeC.Name = "lblNomeC";
            this.lblNomeC.Size = new System.Drawing.Size(40, 15);
            this.lblNomeC.TabIndex = 0;
            this.lblNomeC.Text = "Nome";
            // 
            // lblCodigoC
            // 
            this.lblCodigoC.AutoSize = true;
            this.lblCodigoC.Location = new System.Drawing.Point(334, 22);
            this.lblCodigoC.Name = "lblCodigoC";
            this.lblCodigoC.Size = new System.Drawing.Size(46, 15);
            this.lblCodigoC.TabIndex = 10;
            this.lblCodigoC.Text = "Código";
            // 
            // btnSalvarC
            // 
            this.btnSalvarC.Location = new System.Drawing.Point(368, 164);
            this.btnSalvarC.Name = "btnSalvarC";
            this.btnSalvarC.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarC.TabIndex = 12;
            this.btnSalvarC.Text = "Salvar";
            this.btnSalvarC.UseVisualStyleBackColor = true;
            this.btnSalvarC.Click += new System.EventHandler(this.btnSalvarC_Click);
            // 
            // lblTituloC
            // 
            this.lblTituloC.AutoSize = true;
            this.lblTituloC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloC.Location = new System.Drawing.Point(14, 9);
            this.lblTituloC.Name = "lblTituloC";
            this.lblTituloC.Size = new System.Drawing.Size(182, 30);
            this.lblTituloC.TabIndex = 0;
            this.lblTituloC.Text = "Cadastro Clientes";
            // 
            // btnExcluirC
            // 
            this.btnExcluirC.Location = new System.Drawing.Point(99, 498);
            this.btnExcluirC.Name = "btnExcluirC";
            this.btnExcluirC.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirC.TabIndex = 5;
            this.btnExcluirC.Text = "Excluir";
            this.btnExcluirC.UseVisualStyleBackColor = true;
            this.btnExcluirC.Click += new System.EventHandler(this.btnExcluirC_Click);
            // 
            // pctRimC
            // 
            this.pctRimC.Image = ((System.Drawing.Image)(resources.GetObject("pctRimC.Image")));
            this.pctRimC.Location = new System.Drawing.Point(376, 0);
            this.pctRimC.Name = "pctRimC";
            this.pctRimC.Size = new System.Drawing.Size(100, 50);
            this.pctRimC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRimC.TabIndex = 8;
            this.pctRimC.TabStop = false;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(476, 529);
            this.Controls.Add(this.pctRimC);
            this.Controls.Add(this.btnEditarC);
            this.Controls.Add(this.btnFecharC);
            this.Controls.Add(this.dgvCadastroC);
            this.Controls.Add(this.gbPesquisaC);
            this.Controls.Add(this.gbCadastroC);
            this.Controls.Add(this.lblTituloC);
            this.Controls.Add(this.btnExcluirC);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroC)).EndInit();
            this.gbPesquisaC.ResumeLayout(false);
            this.gbPesquisaC.PerformLayout();
            this.gbCadastroC.ResumeLayout(false);
            this.gbCadastroC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRimC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEditarC;
        private Button btnFecharC;
        private DataGridView dgvCadastroC;
        private GroupBox gbPesquisaC;
        private Label lblBuscaC;
        private Button btnBuscarC;
        private TextBox txtBuscaC;
        private GroupBox gbCadastroC;
        private MaskedTextBox txtTelefoneC;
        private Label lblTelefoneC;
        private TextBox txtEmailC;
        private Label lblEmailC;
        private TextBox txtNumeroC;
        private Label lblNumeroC;
        private TextBox txtEnderecoC;
        private Label lnlEnderecoC;
        private TextBox txtNomeC;
        private TextBox txtCodigoC;
        private Label lblNomeC;
        private Label lblCodigoC;
        private Button btnSalvarC;
        private Label lblTituloC;
        private Button btnExcluirC;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Endereco;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefone;
        private PictureBox pctRimC;
    }
}