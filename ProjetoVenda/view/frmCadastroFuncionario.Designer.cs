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
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(44, 44);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(219, 23);
            txtNome.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(363, 44);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "usuario";
            txtUsuario.Size = new Size(195, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(363, 94);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(195, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(44, 124);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(219, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(44, 170);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(219, 23);
            txtRua.TabIndex = 2;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(44, 261);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(219, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(44, 222);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(94, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(163, 222);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(403, 221);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 50);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenha1
            // 
            txtSenha1.Location = new Point(363, 140);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.PasswordChar = '*';
            txtSenha1.PlaceholderText = "Confirmar Senha";
            txtSenha1.Size = new Size(195, 23);
            txtSenha1.TabIndex = 8;
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 329);
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
            Text = "Cadastro Funcionario";
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
    }
}