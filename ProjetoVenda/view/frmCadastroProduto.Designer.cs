namespace ProjetoVenda.view
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            txtNome = new TextBox();
            txtMarca = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new NumericUpDown();
            button1 = new Button();
            dgvProdutos = new DataGridView();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPaginas = new Label();
            cbxQuantidadeItens = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(36, 37);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(287, 23);
            txtNome.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(342, 37);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca";
            txtMarca.Size = new Size(233, 23);
            txtMarca.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(36, 85);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "R$ 0000.00";
            txtPreco.Size = new Size(184, 23);
            txtPreco.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(243, 86);
            txtQuantidade.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            txtQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(120, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(451, 85);
            button1.Name = "button1";
            button1.Size = new Size(124, 52);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar Produto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCadastrar_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(12, 174);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(757, 449);
            dgvProdutos.TabIndex = 5;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Enabled = false;
            btnAtualizar.Location = new Point(634, 26);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(112, 34);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(634, 78);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(27, 643);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(95, 56);
            btnAnterior.TabIndex = 8;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Location = new Point(668, 643);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(87, 56);
            btnProximo.TabIndex = 9;
            btnProximo.Text = "Proximo >";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPaginas
            // 
            lblPaginas.Location = new Point(196, 643);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(402, 56);
            lblPaginas.TabIndex = 10;
            lblPaginas.Text = "Pagina 1 de 5";
            lblPaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxQuantidadeItens
            // 
            cbxQuantidadeItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuantidadeItens.FormattingEnabled = true;
            cbxQuantidadeItens.Items.AddRange(new object[] { "5", "10", "25", "50", "100" });
            cbxQuantidadeItens.Location = new Point(621, 145);
            cbxQuantidadeItens.Name = "cbxQuantidadeItens";
            cbxQuantidadeItens.Size = new Size(125, 23);
            cbxQuantidadeItens.TabIndex = 11;
            cbxQuantidadeItens.SelectedIndexChanged += cbxQuantidadeItens_SelectedIndexChanged;
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(781, 732);
            Controls.Add(cbxQuantidadeItens);
            Controls.Add(lblPaginas);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvProdutos);
            Controls.Add(button1);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtMarca);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroProduto";
            Text = "Cadastro de Produtos";
            Load += frmCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtMarca;
        private TextBox txtPreco;
        private NumericUpDown txtQuantidade;
        private Button button1;
        private DataGridView dgvProdutos;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblPaginas;
        private ComboBox cbxQuantidadeItens;
    }
}