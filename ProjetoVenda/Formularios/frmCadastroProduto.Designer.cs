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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            groupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 21);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(402, 23);
            txtNome.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.Anchor = AnchorStyles.Left;
            txtMarca.Location = new Point(6, 72);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca";
            txtMarca.Size = new Size(276, 23);
            txtMarca.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(414, 18);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "10000=R$ 1.00";
            txtPreco.Size = new Size(184, 23);
            txtPreco.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(288, 76);
            txtQuantidade.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            txtQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(120, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.Location = new Point(414, 87);
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
            dgvProdutos.Dock = DockStyle.Fill;
            dgvProdutos.Location = new Point(3, 178);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(816, 362);
            dgvProdutos.TabIndex = 5;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Right;
            btnAtualizar.Enabled = false;
            btnAtualizar.Location = new Point(414, 47);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(112, 34);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Right;
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(532, 47);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Left;
            btnAnterior.Location = new Point(43, 11);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(95, 56);
            btnAnterior.TabIndex = 8;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Anchor = AnchorStyles.Right;
            btnProximo.Location = new Point(709, 11);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(87, 56);
            btnProximo.TabIndex = 9;
            btnProximo.Text = "Proximo >";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPaginas.Location = new Point(241, 15);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(402, 48);
            lblPaginas.TabIndex = 10;
            lblPaginas.Text = "Pagina 1 de 5";
            lblPaginas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxQuantidadeItens
            // 
            cbxQuantidadeItens.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbxQuantidadeItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuantidadeItens.FormattingEnabled = true;
            cbxQuantidadeItens.Items.AddRange(new object[] { "5", "10", "25", "50", "100" });
            cbxQuantidadeItens.Location = new Point(544, 116);
            cbxQuantidadeItens.Name = "cbxQuantidadeItens";
            cbxQuantidadeItens.Size = new Size(125, 23);
            cbxQuantidadeItens.TabIndex = 11;
            cbxQuantidadeItens.SelectedIndexChanged += cbxQuantidadeItens_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 12;
            label1.Text = "NOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 3);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 12;
            label2.Text = "PREÇO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 60);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 12;
            label3.Text = "MARCA";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(288, 57);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 12;
            label4.Text = "QUANTIDADE";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(cbxQuantidadeItens);
            groupBox.Controls.Add(btnExcluir);
            groupBox.Controls.Add(btnAtualizar);
            groupBox.Controls.Add(button1);
            groupBox.Controls.Add(txtQuantidade);
            groupBox.Controls.Add(txtPreco);
            groupBox.Controls.Add(txtMarca);
            groupBox.Controls.Add(txtNome);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(816, 169);
            groupBox.TabIndex = 13;
            groupBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dgvProdutos, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(23, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.Size = new Size(822, 615);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProximo);
            panel1.Controls.Add(lblPaginas);
            panel1.Controls.Add(btnAnterior);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 546);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 66);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 169);
            panel2.TabIndex = 7;
            // 
            // frmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(859, 837);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroProduto";
            Text = "Cadastro de Produtos";
            Load += frmCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
    }
}