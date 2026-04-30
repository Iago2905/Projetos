namespace ProjetoLoja
{
    partial class CadastroVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVendas));
            this.btnEditarV = new System.Windows.Forms.Button();
            this.btnFecharV = new System.Windows.Forms.Button();
            this.btnExcluirV = new System.Windows.Forms.Button();
            this.dgvCadastroV = new System.Windows.Forms.DataGridView();
            this.VenCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CliCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPesquisaV = new System.Windows.Forms.GroupBox();
            this.btnBuscarV = new System.Windows.Forms.Button();
            this.txtBuscaV = new System.Windows.Forms.TextBox();
            this.lblBuscaV = new System.Windows.Forms.Label();
            this.gbCadastroV = new System.Windows.Forms.GroupBox();
            this.txtDataV = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoPV = new System.Windows.Forms.TextBox();
            this.lblCodigoCV = new System.Windows.Forms.Label();
            this.txtCodigoCV = new System.Windows.Forms.TextBox();
            this.lblCodigoPV = new System.Windows.Forms.Label();
            this.btnSalvarV = new System.Windows.Forms.Button();
            this.lblCodigoV = new System.Windows.Forms.Label();
            this.lblDataV = new System.Windows.Forms.Label();
            this.txtCodigoV = new System.Windows.Forms.TextBox();
            this.lblTituloV = new System.Windows.Forms.Label();
            this.pctRimV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroV)).BeginInit();
            this.gbPesquisaV.SuspendLayout();
            this.gbCadastroV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRimV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarV
            // 
            this.btnEditarV.Location = new System.Drawing.Point(14, 480);
            this.btnEditarV.Name = "btnEditarV";
            this.btnEditarV.Size = new System.Drawing.Size(75, 23);
            this.btnEditarV.TabIndex = 4;
            this.btnEditarV.Text = "Editar";
            this.btnEditarV.UseVisualStyleBackColor = true;
            this.btnEditarV.Click += new System.EventHandler(this.btnEditarV_Click);
            // 
            // btnFecharV
            // 
            this.btnFecharV.Location = new System.Drawing.Point(294, 480);
            this.btnFecharV.Name = "btnFecharV";
            this.btnFecharV.Size = new System.Drawing.Size(75, 23);
            this.btnFecharV.TabIndex = 6;
            this.btnFecharV.Text = "Fechar";
            this.btnFecharV.UseVisualStyleBackColor = true;
            this.btnFecharV.Click += new System.EventHandler(this.btnFecharV_Click);
            // 
            // btnExcluirV
            // 
            this.btnExcluirV.Location = new System.Drawing.Point(95, 480);
            this.btnExcluirV.Name = "btnExcluirV";
            this.btnExcluirV.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirV.TabIndex = 5;
            this.btnExcluirV.Text = "Excluir ";
            this.btnExcluirV.UseVisualStyleBackColor = true;
            this.btnExcluirV.Click += new System.EventHandler(this.btnExcluirV_Click);
            // 
            // dgvCadastroV
            // 
            this.dgvCadastroV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VenCodigo,
            this.CliCodigo,
            this.ProCodigo,
            this.VenData});
            this.dgvCadastroV.Location = new System.Drawing.Point(12, 314);
            this.dgvCadastroV.Name = "dgvCadastroV";
            this.dgvCadastroV.RowTemplate.Height = 25;
            this.dgvCadastroV.Size = new System.Drawing.Size(357, 150);
            this.dgvCadastroV.TabIndex = 3;
            // 
            // VenCodigo
            // 
            this.VenCodigo.DataPropertyName = "VenCodigo";
            this.VenCodigo.HeaderText = "Codigo Venda";
            this.VenCodigo.Name = "VenCodigo";
            // 
            // CliCodigo
            // 
            this.CliCodigo.DataPropertyName = "CliCodigo";
            this.CliCodigo.HeaderText = "Codigo Cliente";
            this.CliCodigo.Name = "CliCodigo";
            // 
            // ProCodigo
            // 
            this.ProCodigo.DataPropertyName = "ProCodigo";
            this.ProCodigo.HeaderText = "Codigo Produto";
            this.ProCodigo.Name = "ProCodigo";
            // 
            // VenData
            // 
            this.VenData.DataPropertyName = "VenData";
            this.VenData.HeaderText = "Data Venda";
            this.VenData.Name = "VenData";
            // 
            // gbPesquisaV
            // 
            this.gbPesquisaV.Controls.Add(this.btnBuscarV);
            this.gbPesquisaV.Controls.Add(this.txtBuscaV);
            this.gbPesquisaV.Controls.Add(this.lblBuscaV);
            this.gbPesquisaV.Location = new System.Drawing.Point(12, 220);
            this.gbPesquisaV.Name = "gbPesquisaV";
            this.gbPesquisaV.Size = new System.Drawing.Size(357, 88);
            this.gbPesquisaV.TabIndex = 2;
            this.gbPesquisaV.TabStop = false;
            this.gbPesquisaV.Text = "Pesquisa";
            // 
            // btnBuscarV
            // 
            this.btnBuscarV.Location = new System.Drawing.Point(276, 55);
            this.btnBuscarV.Name = "btnBuscarV";
            this.btnBuscarV.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarV.TabIndex = 2;
            this.btnBuscarV.Text = "Buscar";
            this.btnBuscarV.UseVisualStyleBackColor = true;
            this.btnBuscarV.Click += new System.EventHandler(this.btnBuscarV_Click);
            // 
            // txtBuscaV
            // 
            this.txtBuscaV.Location = new System.Drawing.Point(2, 56);
            this.txtBuscaV.Name = "txtBuscaV";
            this.txtBuscaV.Size = new System.Drawing.Size(268, 23);
            this.txtBuscaV.TabIndex = 1;
            // 
            // lblBuscaV
            // 
            this.lblBuscaV.AutoSize = true;
            this.lblBuscaV.Location = new System.Drawing.Point(0, 38);
            this.lblBuscaV.Name = "lblBuscaV";
            this.lblBuscaV.Size = new System.Drawing.Size(38, 15);
            this.lblBuscaV.TabIndex = 0;
            this.lblBuscaV.Text = "Busca";
            // 
            // gbCadastroV
            // 
            this.gbCadastroV.Controls.Add(this.txtDataV);
            this.gbCadastroV.Controls.Add(this.txtCodigoPV);
            this.gbCadastroV.Controls.Add(this.lblCodigoCV);
            this.gbCadastroV.Controls.Add(this.txtCodigoCV);
            this.gbCadastroV.Controls.Add(this.lblCodigoPV);
            this.gbCadastroV.Controls.Add(this.btnSalvarV);
            this.gbCadastroV.Controls.Add(this.lblCodigoV);
            this.gbCadastroV.Controls.Add(this.lblDataV);
            this.gbCadastroV.Controls.Add(this.txtCodigoV);
            this.gbCadastroV.Location = new System.Drawing.Point(12, 43);
            this.gbCadastroV.Name = "gbCadastroV";
            this.gbCadastroV.Size = new System.Drawing.Size(357, 171);
            this.gbCadastroV.TabIndex = 1;
            this.gbCadastroV.TabStop = false;
            this.gbCadastroV.Text = "Cadastro";
            // 
            // txtDataV
            // 
            this.txtDataV.Location = new System.Drawing.Point(7, 99);
            this.txtDataV.Mask = "00/00/0000";
            this.txtDataV.Name = "txtDataV";
            this.txtDataV.Size = new System.Drawing.Size(112, 23);
            this.txtDataV.TabIndex = 1;
            this.txtDataV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataV.ValidatingType = typeof(System.DateTime);
            // 
            // txtCodigoPV
            // 
            this.txtCodigoPV.Location = new System.Drawing.Point(239, 99);
            this.txtCodigoPV.Name = "txtCodigoPV";
            this.txtCodigoPV.Size = new System.Drawing.Size(112, 23);
            this.txtCodigoPV.TabIndex = 5;
            this.txtCodigoPV.Text = "0";
            this.txtCodigoPV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodigoCV
            // 
            this.lblCodigoCV.AutoSize = true;
            this.lblCodigoCV.Location = new System.Drawing.Point(238, 21);
            this.lblCodigoCV.Name = "lblCodigoCV";
            this.lblCodigoCV.Size = new System.Drawing.Size(86, 15);
            this.lblCodigoCV.TabIndex = 2;
            this.lblCodigoCV.Text = "Codigo Cliente";
            // 
            // txtCodigoCV
            // 
            this.txtCodigoCV.Location = new System.Drawing.Point(239, 39);
            this.txtCodigoCV.Name = "txtCodigoCV";
            this.txtCodigoCV.Size = new System.Drawing.Size(112, 23);
            this.txtCodigoCV.TabIndex = 3;
            this.txtCodigoCV.Text = "0";
            this.txtCodigoCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodigoPV
            // 
            this.lblCodigoPV.AutoSize = true;
            this.lblCodigoPV.Location = new System.Drawing.Point(238, 81);
            this.lblCodigoPV.Name = "lblCodigoPV";
            this.lblCodigoPV.Size = new System.Drawing.Size(92, 15);
            this.lblCodigoPV.TabIndex = 4;
            this.lblCodigoPV.Text = "Codigo Produto";
            // 
            // btnSalvarV
            // 
            this.btnSalvarV.Location = new System.Drawing.Point(276, 142);
            this.btnSalvarV.Name = "btnSalvarV";
            this.btnSalvarV.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarV.TabIndex = 8;
            this.btnSalvarV.Text = "Salvar";
            this.btnSalvarV.UseVisualStyleBackColor = true;
            this.btnSalvarV.Click += new System.EventHandler(this.btnSalvarV_Click);
            // 
            // lblCodigoV
            // 
            this.lblCodigoV.AutoSize = true;
            this.lblCodigoV.Location = new System.Drawing.Point(7, 21);
            this.lblCodigoV.Name = "lblCodigoV";
            this.lblCodigoV.Size = new System.Drawing.Size(81, 15);
            this.lblCodigoV.TabIndex = 6;
            this.lblCodigoV.Text = "Codigo Venda";
            // 
            // lblDataV
            // 
            this.lblDataV.AutoSize = true;
            this.lblDataV.Location = new System.Drawing.Point(7, 81);
            this.lblDataV.Name = "lblDataV";
            this.lblDataV.Size = new System.Drawing.Size(66, 15);
            this.lblDataV.TabIndex = 0;
            this.lblDataV.Text = "Data Venda";
            // 
            // txtCodigoV
            // 
            this.txtCodigoV.Location = new System.Drawing.Point(7, 39);
            this.txtCodigoV.Name = "txtCodigoV";
            this.txtCodigoV.Size = new System.Drawing.Size(112, 23);
            this.txtCodigoV.TabIndex = 7;
            this.txtCodigoV.Text = "0";
            this.txtCodigoV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoV.Validated += new System.EventHandler(this.txtCodigoV_Validated);
            // 
            // lblTituloV
            // 
            this.lblTituloV.AutoSize = true;
            this.lblTituloV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloV.Location = new System.Drawing.Point(12, 9);
            this.lblTituloV.Name = "lblTituloV";
            this.lblTituloV.Size = new System.Drawing.Size(175, 30);
            this.lblTituloV.TabIndex = 0;
            this.lblTituloV.Text = "Cadastro Vendas";
            // 
            // pctRimV
            // 
            this.pctRimV.Image = ((System.Drawing.Image)(resources.GetObject("pctRimV.Image")));
            this.pctRimV.Location = new System.Drawing.Point(279, 0);
            this.pctRimV.Name = "pctRimV";
            this.pctRimV.Size = new System.Drawing.Size(100, 50);
            this.pctRimV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRimV.TabIndex = 8;
            this.pctRimV.TabStop = false;
            // 
            // CadastroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(379, 510);
            this.Controls.Add(this.pctRimV);
            this.Controls.Add(this.btnEditarV);
            this.Controls.Add(this.btnFecharV);
            this.Controls.Add(this.btnExcluirV);
            this.Controls.Add(this.dgvCadastroV);
            this.Controls.Add(this.gbPesquisaV);
            this.Controls.Add(this.gbCadastroV);
            this.Controls.Add(this.lblTituloV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroV)).EndInit();
            this.gbPesquisaV.ResumeLayout(false);
            this.gbPesquisaV.PerformLayout();
            this.gbCadastroV.ResumeLayout(false);
            this.gbCadastroV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRimV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEditarV;
        private Button btnFecharV;
        private Button btnExcluirV;
        private DataGridView dgvCadastroV;
        private GroupBox gbPesquisaV;
        private Button btnBuscarV;
        private TextBox txtBuscaV;
        private Label lblBuscaV;
        private GroupBox gbCadastroV;
        private TextBox txtCodigoPV;
        private Label lblCodigoCV;
        private TextBox txtCodigoCV;
        private Label lblCodigoPV;
        private Button btnSalvarV;
        private Label lblCodigoV;
        private Label lblDataV;
        private TextBox txtCodigoV;
        private Label lblTituloV;
        private MaskedTextBox txtDataV;
        private DataGridViewTextBoxColumn VenCodigo;
        private DataGridViewTextBoxColumn CliCodigo;
        private DataGridViewTextBoxColumn ProCodigo;
        private DataGridViewTextBoxColumn VenData;
        private PictureBox pctRimV;
    }
}