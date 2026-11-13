namespace ProjetoVenda.view
{
    partial class frmCadastroVenda
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
            cbxProdutos = new ComboBox();
            lblPreco = new Label();
            lblQuantidade = new Label();
            nunQuantidade = new NumericUpDown();
            dgvCarrinho = new DataGridView();
            btnAdicionar = new Button();
            lblPrecoTotal = new Label();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)nunQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            SuspendLayout();
            // 
            // cbxProdutos
            // 
            cbxProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProdutos.FormattingEnabled = true;
            cbxProdutos.Location = new Point(12, 12);
            cbxProdutos.Name = "cbxProdutos";
            cbxProdutos.Size = new Size(745, 23);
            cbxProdutos.TabIndex = 0;
            cbxProdutos.SelectedIndexChanged += cbxProdutos_SelectedIndexChanged;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(15, 63);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(101, 15);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço Unitario: R$";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(15, 97);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(133, 15);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade Disponivel: ";
            // 
            // nunQuantidade
            // 
            nunQuantidade.Location = new Point(637, 63);
            nunQuantidade.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nunQuantidade.Name = "nunQuantidade";
            nunQuantidade.Size = new Size(120, 23);
            nunQuantidade.TabIndex = 3;
            nunQuantidade.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.AllowUserToAddRows = false;
            dgvCarrinho.AllowUserToDeleteRows = false;
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(9, 134);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrinho.Size = new Size(861, 403);
            dgvCarrinho.TabIndex = 4;
            dgvCarrinho.CellContentClick += dgvCarrinho_CellContentClick;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(637, 97);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(125, 31);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Atualizar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblPrecoTotal
            // 
            lblPrecoTotal.AutoSize = true;
            lblPrecoTotal.Font = new Font("Segoe UI", 26F);
            lblPrecoTotal.Location = new Point(455, 540);
            lblPrecoTotal.Name = "lblPrecoTotal";
            lblPrecoTotal.Size = new Size(201, 47);
            lblPrecoTotal.TabIndex = 6;
            lblPrecoTotal.Text = "Total Venda";
            lblPrecoTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 20F);
            btnCadastrar.Location = new Point(290, 617);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(288, 65);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmCadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 694);
            Controls.Add(btnCadastrar);
            Controls.Add(lblPrecoTotal);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvCarrinho);
            Controls.Add(nunQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(cbxProdutos);
            Name = "frmCadastroVenda";
            Text = "Cadastro de Vendas";
            Load += frmCadastroVenda_Load;
            ((System.ComponentModel.ISupportInitialize)nunQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private ComboBox cbxProdutos;
        private Label lblPreco;
        private Label lblQuantidade;
        private NumericUpDown nunQuantidade;
        private DataGridView dgvCarrinho;
        private Button btnAdicionar;
        private Label lblPrecoTotal;
        private Button btnCadastrar;
    }
}