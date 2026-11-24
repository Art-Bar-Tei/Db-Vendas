namespace ProjetoVenda.view
{
    partial class frmCadastroFuncionario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFuncionario));
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtRua = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtCep = new TextBox();
            dgvFuncionario = new DataGridView();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            txtUsuario = new TextBox();
            cbxADM = new ComboBox();
            txtSenha = new TextBox();
            txtSenha1 = new TextBox();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top;
            txtNome.Location = new Point(455, 20);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(219, 23);
            txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Top;
            txtTelefone.Location = new Point(455, 84);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(219, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtRua
            // 
            txtRua.Anchor = AnchorStyles.Top;
            txtRua.Location = new Point(455, 130);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(219, 23);
            txtRua.TabIndex = 2;
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.Top;
            txtComplemento.Location = new Point(455, 221);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(219, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Top;
            txtNumero.Location = new Point(455, 182);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(94, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtCep
            // 
            txtCep.Anchor = AnchorStyles.Top;
            txtCep.Location = new Point(574, 182);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 4;
            // 
            // dgvFuncionario
            // 
            dgvFuncionario.AllowUserToAddRows = false;
            dgvFuncionario.AllowUserToDeleteRows = false;
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.Location = new Point(3, 326);
            dgvFuncionario.Name = "dgvFuncionario";
            dgvFuncionario.Size = new Size(1327, 282);
            dgvFuncionario.TabIndex = 10;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "Foto.jpg");
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvFuncionario, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1368, 646);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(cbxADM);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtSenha1);
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtComplemento);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(txtCep);
            panel1.Controls.Add(txtRua);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1362, 317);
            panel1.TabIndex = 11;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top;
            txtUsuario.Location = new Point(714, 20);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "usuario";
            txtUsuario.Size = new Size(195, 23);
            txtUsuario.TabIndex = 6;
            // 
            // cbxADM
            // 
            cbxADM.Anchor = AnchorStyles.Top;
            cbxADM.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxADM.FormattingEnabled = true;
            cbxADM.Items.AddRange(new object[] { "CLT", "Patrão" });
            cbxADM.Location = new Point(723, 163);
            cbxADM.Name = "cbxADM";
            cbxADM.Size = new Size(152, 23);
            cbxADM.TabIndex = 11;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top;
            txtSenha.Location = new Point(714, 70);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(195, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtSenha1
            // 
            txtSenha1.Anchor = AnchorStyles.Top;
            txtSenha1.Location = new Point(714, 116);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.PasswordChar = '*';
            txtSenha1.PlaceholderText = "Confirmar Senha";
            txtSenha1.Size = new Size(195, 23);
            txtSenha1.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Top;
            btnCadastrar.Location = new Point(742, 206);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 50);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 646);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Funcionario";
            Load += frmCadastroFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtRua;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private TextBox txtCep;
        private DataGridView dgvFuncionario;
        private ImageList imageList1;
        private ImageList imageList2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox txtUsuario;
        private ComboBox cbxADM;
        private TextBox txtSenha;
        private TextBox txtSenha1;
        private Button btnCadastrar;
    }
}