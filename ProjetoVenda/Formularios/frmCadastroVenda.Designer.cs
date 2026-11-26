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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nunQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cbxProdutos
            // 
            cbxProdutos.Anchor = AnchorStyles.Top;
            cbxProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProdutos.FormattingEnabled = true;
            cbxProdutos.Location = new Point(13, 21);
            cbxProdutos.Name = "cbxProdutos";
            cbxProdutos.Size = new Size(745, 23);
            cbxProdutos.TabIndex = 0;
            cbxProdutos.SelectedIndexChanged += cbxProdutos_SelectedIndexChanged;
            // 
            // lblPreco
            // 
            lblPreco.Anchor = AnchorStyles.Top;
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(16, 72);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(88, 15);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço Unitario: ";
            // 
            // lblQuantidade
            // 
            lblQuantidade.Anchor = AnchorStyles.Top;
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(16, 106);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(133, 15);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade Disponivel: ";
            // 
            // nunQuantidade
            // 
            nunQuantidade.Anchor = AnchorStyles.Top;
            nunQuantidade.Location = new Point(638, 72);
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
            dgvCarrinho.Dock = DockStyle.Fill;
            dgvCarrinho.Location = new Point(3, 158);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrinho.Size = new Size(798, 363);
            dgvCarrinho.TabIndex = 4;
            dgvCarrinho.CellContentClick += dgvCarrinho_CellContentClick;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top;
            btnAdicionar.Location = new Point(638, 106);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(125, 31);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Atualizar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblPrecoTotal
            // 
            lblPrecoTotal.Anchor = AnchorStyles.Right;
            lblPrecoTotal.AutoSize = true;
            lblPrecoTotal.Font = new Font("Segoe UI", 26F);
            lblPrecoTotal.Location = new Point(594, -3);
            lblPrecoTotal.Name = "lblPrecoTotal";
            lblPrecoTotal.Size = new Size(201, 47);
            lblPrecoTotal.TabIndex = 6;
            lblPrecoTotal.Text = "Total Venda";
            lblPrecoTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Bottom;
            btnCadastrar.Font = new Font("Segoe UI", 20F);
            btnCadastrar.Location = new Point(318, 47);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(230, 48);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvCarrinho, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Location = new Point(-11, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.5801525F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70.4198456F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.Size = new Size(804, 628);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxProdutos);
            panel1.Controls.Add(lblPreco);
            panel1.Controls.Add(lblQuantidade);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(nunQuantidade);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 149);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPrecoTotal);
            panel2.Controls.Add(btnCadastrar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 527);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 98);
            panel2.TabIndex = 6;
            // 
            // frmCadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(799, 641);
            Controls.Add(tableLayoutPanel1);
            Name = "frmCadastroVenda";
            Text = "Cadastro de Vendas";
            Load += frmCadastroVenda_Load;
            ((System.ComponentModel.ISupportInitialize)nunQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
    }
}