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
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtTelefone = new TextBox();
            txtRua = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtCep = new TextBox();
            btnCadastrar = new Button();
            txtSenha1 = new TextBox();
            dgvFuncionario = new DataGridView();
            cbxADM = new ComboBox();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(400, 46);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(219, 23);
            txtNome.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(719, 46);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "usuario";
            txtUsuario.Size = new Size(195, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(719, 96);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(195, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(400, 126);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(219, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(400, 172);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(219, 23);
            txtRua.TabIndex = 2;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(400, 263);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(219, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(400, 224);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(94, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(519, 224);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(758, 248);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 50);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenha1
            // 
            txtSenha1.Location = new Point(719, 142);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.PasswordChar = '*';
            txtSenha1.PlaceholderText = "Confirmar Senha";
            txtSenha1.Size = new Size(195, 23);
            txtSenha1.TabIndex = 8;
            // 
            // dgvFuncionario
            // 
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.Location = new Point(12, 321);
            dgvFuncionario.Name = "dgvFuncionario";
            dgvFuncionario.Size = new Size(984, 359);
            dgvFuncionario.TabIndex = 10;
            // 
            // cbxADM
            // 
            cbxADM.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxADM.FormattingEnabled = true;
            cbxADM.Items.AddRange(new object[] { "CLT", "Patrão" });
            cbxADM.Location = new Point(743, 202);
            cbxADM.Name = "cbxADM";
            cbxADM.Size = new Size(152, 23);
            cbxADM.TabIndex = 11;
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
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 681);
            Controls.Add(cbxADM);
            Controls.Add(dgvFuncionario);
            Controls.Add(txtSenha1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCep);
            Controls.Add(txtNumero);
            Controls.Add(txtComplemento);
            Controls.Add(txtRua);
            Controls.Add(txtTelefone);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Funcionario";
            Load += frmCadastroFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtTelefone;
        private TextBox txtRua;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private TextBox txtCep;
        private Button btnCadastrar;
        private TextBox txtSenha1;
        private DataGridView dgvFuncionario;
        private ComboBox cbxADM;
        private ImageList imageList1;
        private ImageList imageList2;
    }
}