namespace ProjetoLoja
{
    partial class CadastroItemVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroItemVenda));
            this.gbCadastroIV = new System.Windows.Forms.GroupBox();
            this.txtCodigoIV = new System.Windows.Forms.TextBox();
            this.txtProPrecoV = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecoPV = new System.Windows.Forms.Label();
            this.txtProVenQuantidade = new System.Windows.Forms.TextBox();
            this.lblProVenQuantidade = new System.Windows.Forms.Label();
            this.lblCodigoV = new System.Windows.Forms.Label();
            this.txtCodigoVV = new System.Windows.Forms.TextBox();
            this.btnSalvarIV = new System.Windows.Forms.Button();
            this.lblCodigoIV = new System.Windows.Forms.Label();
            this.pctRimIV = new System.Windows.Forms.PictureBox();
            this.lblTituloIV = new System.Windows.Forms.Label();
            this.gbPesquisaIV = new System.Windows.Forms.GroupBox();
            this.lblBuscaIV = new System.Windows.Forms.Label();
            this.btnBuscarIV = new System.Windows.Forms.Button();
            this.txtBuscaIV = new System.Windows.Forms.TextBox();
            this.btnEditarIV = new System.Windows.Forms.Button();
            this.btnFecharIV = new System.Windows.Forms.Button();
            this.dgvCadastroIV = new System.Windows.Forms.DataGridView();
            this.ItemVenCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProVenQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProPrecoV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirIV = new System.Windows.Forms.Button();
            this.gbCadastroIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRimIV)).BeginInit();
            this.gbPesquisaIV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroIV)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadastroIV
            // 
            this.gbCadastroIV.Controls.Add(this.txtCodigoIV);
            this.gbCadastroIV.Controls.Add(this.txtProPrecoV);
            this.gbCadastroIV.Controls.Add(this.lblPrecoPV);
            this.gbCadastroIV.Controls.Add(this.txtProVenQuantidade);
            this.gbCadastroIV.Controls.Add(this.lblProVenQuantidade);
            this.gbCadastroIV.Controls.Add(this.lblCodigoV);
            this.gbCadastroIV.Controls.Add(this.txtCodigoVV);
            this.gbCadastroIV.Controls.Add(this.btnSalvarIV);
            this.gbCadastroIV.Controls.Add(this.lblCodigoIV);
            this.gbCadastroIV.Controls.Add(this.pctRimIV);
            this.gbCadastroIV.Location = new System.Drawing.Point(20, 44);
            this.gbCadastroIV.Name = "gbCadastroIV";
            this.gbCadastroIV.Size = new System.Drawing.Size(443, 200);
            this.gbCadastroIV.TabIndex = 1;
            this.gbCadastroIV.TabStop = false;
            this.gbCadastroIV.Text = "Cadastro";
            // 
            // txtCodigoIV
            // 
            this.txtCodigoIV.Location = new System.Drawing.Point(8, 39);
            this.txtCodigoIV.Name = "txtCodigoIV";
            this.txtCodigoIV.Size = new System.Drawing.Size(112, 23);
            this.txtCodigoIV.TabIndex = 9;
            this.txtCodigoIV.Text = "0";
            this.txtCodigoIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoIV.Validated += new System.EventHandler(this.txtCodigoIV_Validated);
            // 
            // txtProPrecoV
            // 
            this.txtProPrecoV.Location = new System.Drawing.Point(326, 142);
            this.txtProPrecoV.Mask = "$ 00,00";
            this.txtProPrecoV.Name = "txtProPrecoV";
            this.txtProPrecoV.Size = new System.Drawing.Size(111, 23);
            this.txtProPrecoV.TabIndex = 5;
            this.txtProPrecoV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecoPV
            // 
            this.lblPrecoPV.AutoSize = true;
            this.lblPrecoPV.Location = new System.Drawing.Point(326, 124);
            this.lblPrecoPV.Name = "lblPrecoPV";
            this.lblPrecoPV.Size = new System.Drawing.Size(37, 15);
            this.lblPrecoPV.TabIndex = 2;
            this.lblPrecoPV.Text = "Preço";
            // 
            // txtProVenQuantidade
            // 
            this.txtProVenQuantidade.Location = new System.Drawing.Point(326, 39);
            this.txtProVenQuantidade.Name = "txtProVenQuantidade";
            this.txtProVenQuantidade.Size = new System.Drawing.Size(111, 23);
            this.txtProVenQuantidade.TabIndex = 3;
            this.txtProVenQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProVenQuantidade
            // 
            this.lblProVenQuantidade.AutoSize = true;
            this.lblProVenQuantidade.Location = new System.Drawing.Point(326, 21);
            this.lblProVenQuantidade.Name = "lblProVenQuantidade";
            this.lblProVenQuantidade.Size = new System.Drawing.Size(104, 15);
            this.lblProVenQuantidade.TabIndex = 2;
            this.lblProVenQuantidade.Text = "Quantidade Venda";
            // 
            // lblCodigoV
            // 
            this.lblCodigoV.AutoSize = true;
            this.lblCodigoV.Location = new System.Drawing.Point(8, 124);
            this.lblCodigoV.Name = "lblCodigoV";
            this.lblCodigoV.Size = new System.Drawing.Size(81, 15);
            this.lblCodigoV.TabIndex = 0;
            this.lblCodigoV.Text = "Codigo Venda";
            // 
            // txtCodigoVV
            // 
            this.txtCodigoVV.Location = new System.Drawing.Point(8, 142);
            this.txtCodigoVV.Name = "txtCodigoVV";
            this.txtCodigoVV.Size = new System.Drawing.Size(112, 23);
            this.txtCodigoVV.TabIndex = 1;
            this.txtCodigoVV.Text = "0";
            this.txtCodigoVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSalvarIV
            // 
            this.btnSalvarIV.Location = new System.Drawing.Point(362, 171);
            this.btnSalvarIV.Name = "btnSalvarIV";
            this.btnSalvarIV.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarIV.TabIndex = 8;
            this.btnSalvarIV.Text = "Salvar";
            this.btnSalvarIV.UseVisualStyleBackColor = true;
            this.btnSalvarIV.Click += new System.EventHandler(this.btnSalvarIV_Click);
            // 
            // lblCodigoIV
            // 
            this.lblCodigoIV.AutoSize = true;
            this.lblCodigoIV.Location = new System.Drawing.Point(7, 21);
            this.lblCodigoIV.Name = "lblCodigoIV";
            this.lblCodigoIV.Size = new System.Drawing.Size(108, 15);
            this.lblCodigoIV.TabIndex = 6;
            this.lblCodigoIV.Text = "Codigo Item Venda";
            // 
            // pctRimIV
            // 
            this.pctRimIV.Image = ((System.Drawing.Image)(resources.GetObject("pctRimIV.Image")));
            this.pctRimIV.Location = new System.Drawing.Point(8, 16);
            this.pctRimIV.Name = "pctRimIV";
            this.pctRimIV.Size = new System.Drawing.Size(422, 178);
            this.pctRimIV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRimIV.TabIndex = 8;
            this.pctRimIV.TabStop = false;
            // 
            // lblTituloIV
            // 
            this.lblTituloIV.AutoSize = true;
            this.lblTituloIV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloIV.Location = new System.Drawing.Point(14, 9);
            this.lblTituloIV.Name = "lblTituloIV";
            this.lblTituloIV.Size = new System.Drawing.Size(229, 30);
            this.lblTituloIV.TabIndex = 0;
            this.lblTituloIV.Text = "Cadastro Itens Vendas";
            // 
            // gbPesquisaIV
            // 
            this.gbPesquisaIV.Controls.Add(this.lblBuscaIV);
            this.gbPesquisaIV.Controls.Add(this.btnBuscarIV);
            this.gbPesquisaIV.Controls.Add(this.txtBuscaIV);
            this.gbPesquisaIV.Location = new System.Drawing.Point(20, 258);
            this.gbPesquisaIV.Name = "gbPesquisaIV";
            this.gbPesquisaIV.Size = new System.Drawing.Size(443, 78);
            this.gbPesquisaIV.TabIndex = 2;
            this.gbPesquisaIV.TabStop = false;
            this.gbPesquisaIV.Text = "Pesquisa";
            // 
            // lblBuscaIV
            // 
            this.lblBuscaIV.AutoSize = true;
            this.lblBuscaIV.Location = new System.Drawing.Point(6, 29);
            this.lblBuscaIV.Name = "lblBuscaIV";
            this.lblBuscaIV.Size = new System.Drawing.Size(38, 15);
            this.lblBuscaIV.TabIndex = 0;
            this.lblBuscaIV.Text = "Busca";
            // 
            // btnBuscarIV
            // 
            this.btnBuscarIV.Location = new System.Drawing.Point(368, 46);
            this.btnBuscarIV.Name = "btnBuscarIV";
            this.btnBuscarIV.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarIV.TabIndex = 2;
            this.btnBuscarIV.Text = "Buscar";
            this.btnBuscarIV.UseVisualStyleBackColor = true;
            this.btnBuscarIV.Click += new System.EventHandler(this.btnBuscarIV_Click);
            // 
            // txtBuscaIV
            // 
            this.txtBuscaIV.Location = new System.Drawing.Point(6, 47);
            this.txtBuscaIV.Name = "txtBuscaIV";
            this.txtBuscaIV.Size = new System.Drawing.Size(356, 23);
            this.txtBuscaIV.TabIndex = 1;
            // 
            // btnEditarIV
            // 
            this.btnEditarIV.Location = new System.Drawing.Point(20, 511);
            this.btnEditarIV.Name = "btnEditarIV";
            this.btnEditarIV.Size = new System.Drawing.Size(75, 23);
            this.btnEditarIV.TabIndex = 4;
            this.btnEditarIV.Text = "Editar";
            this.btnEditarIV.UseVisualStyleBackColor = true;
            this.btnEditarIV.Click += new System.EventHandler(this.btnEditarIV_Click);
            // 
            // btnFecharIV
            // 
            this.btnFecharIV.Location = new System.Drawing.Point(388, 510);
            this.btnFecharIV.Name = "btnFecharIV";
            this.btnFecharIV.Size = new System.Drawing.Size(75, 23);
            this.btnFecharIV.TabIndex = 6;
            this.btnFecharIV.Text = "Fechar";
            this.btnFecharIV.UseVisualStyleBackColor = true;
            this.btnFecharIV.Click += new System.EventHandler(this.btnFecharIV_Click);
            // 
            // dgvCadastroIV
            // 
            this.dgvCadastroIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroIV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemVenCodigo,
            this.VenCodigo,
            this.ProVenQuantidade,
            this.ProPrecoV});
            this.dgvCadastroIV.Location = new System.Drawing.Point(20, 342);
            this.dgvCadastroIV.Name = "dgvCadastroIV";
            this.dgvCadastroIV.RowTemplate.Height = 25;
            this.dgvCadastroIV.Size = new System.Drawing.Size(443, 163);
            this.dgvCadastroIV.TabIndex = 3;
            // 
            // ItemVenCodigo
            // 
            this.ItemVenCodigo.DataPropertyName = "ItemVenCodigo";
            this.ItemVenCodigo.HeaderText = "Código Item Venda";
            this.ItemVenCodigo.Name = "ItemVenCodigo";
            // 
            // VenCodigo
            // 
            this.VenCodigo.DataPropertyName = "VenCodigo";
            this.VenCodigo.HeaderText = "Código Venda";
            this.VenCodigo.Name = "VenCodigo";
            // 
            // ProVenQuantidade
            // 
            this.ProVenQuantidade.DataPropertyName = "ProVenQuantidade";
            this.ProVenQuantidade.HeaderText = "Quantidade";
            this.ProVenQuantidade.Name = "ProVenQuantidade";
            // 
            // ProPrecoV
            // 
            this.ProPrecoV.DataPropertyName = "ProPrecoV";
            this.ProPrecoV.HeaderText = "Preço";
            this.ProPrecoV.Name = "ProPrecoV";
            // 
            // btnExcluirIV
            // 
            this.btnExcluirIV.Location = new System.Drawing.Point(101, 510);
            this.btnExcluirIV.Name = "btnExcluirIV";
            this.btnExcluirIV.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirIV.TabIndex = 5;
            this.btnExcluirIV.Text = "Excluir";
            this.btnExcluirIV.UseVisualStyleBackColor = true;
            this.btnExcluirIV.Click += new System.EventHandler(this.btnExcluirIV_Click);
            // 
            // CadastroItemVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(482, 541);
            this.Controls.Add(this.gbPesquisaIV);
            this.Controls.Add(this.btnEditarIV);
            this.Controls.Add(this.btnFecharIV);
            this.Controls.Add(this.dgvCadastroIV);
            this.Controls.Add(this.btnExcluirIV);
            this.Controls.Add(this.gbCadastroIV);
            this.Controls.Add(this.lblTituloIV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroItemVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroItemVenda";
            this.gbCadastroIV.ResumeLayout(false);
            this.gbCadastroIV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRimIV)).EndInit();
            this.gbPesquisaIV.ResumeLayout(false);
            this.gbPesquisaIV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroIV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbCadastroIV;
        private Button btnSalvarIV;
        private Label lblCodigoIV;
        private Label lblTituloIV;
        private Label lblCodigoV;
        private TextBox txtCodigoVV;
        private TextBox txtProVenQuantidade;
        private Label lblProVenQuantidade;
        private Label lblPrecoPV;
        private MaskedTextBox txtProPrecoV;
        private GroupBox gbPesquisaIV;
        private Label lblBuscaIV;
        private Button btnBuscarIV;
        private TextBox txtBuscaIV;
        private Button btnEditarIV;
        private Button btnFecharIV;
        private DataGridView dgvCadastroIV;
        private Button btnExcluirIV;
        private TextBox txtCodigoIV;
        private DataGridViewTextBoxColumn ItemVenCodigo;
        private DataGridViewTextBoxColumn VenCodigo;
        private DataGridViewTextBoxColumn ProVenQuantidade;
        private DataGridViewTextBoxColumn ProPrecoV;
        private PictureBox pctRimIV;
    }
}