namespace ProjetoVenda.view
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblUsername = new Label();
            btnCadFuncionario = new Button();
            btnCadProduto = new Button();
            panel2 = new Panel();
            btnPerfil = new Button();
            btnSair = new Button();
            panel1 = new Panel();
            painelPrincipal = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(45, 65);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "nome do usuario";
            // 
            // btnCadFuncionario
            // 
            btnCadFuncionario.Location = new Point(29, 246);
            btnCadFuncionario.Name = "btnCadFuncionario";
            btnCadFuncionario.Size = new Size(104, 73);
            btnCadFuncionario.TabIndex = 1;
            btnCadFuncionario.Text = "Cadastrar Funcionario";
            btnCadFuncionario.UseVisualStyleBackColor = true;
            btnCadFuncionario.Click += btnCadFuncionario_Click;
            // 
            // btnCadProduto
            // 
            btnCadProduto.Location = new Point(29, 129);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(104, 85);
            btnCadProduto.TabIndex = 2;
            btnCadProduto.Text = "Cadastrar Produto";
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPerfil);
            panel2.Controls.Add(btnSair);
            panel2.Controls.Add(btnCadProduto);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(btnCadFuncionario);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 710);
            panel2.TabIndex = 4;
            // 
            // btnPerfil
            // 
            btnPerfil.Location = new Point(29, 364);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(104, 73);
            btnPerfil.TabIndex = 4;
            btnPerfil.Text = "Acessar perfil";
            btnPerfil.UseVisualStyleBackColor = true;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(29, 634);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(104, 44);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(192, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 80);
            panel1.TabIndex = 5;
            // 
            // painelPrincipal
            // 
            painelPrincipal.Dock = DockStyle.Fill;
            painelPrincipal.Location = new Point(192, 80);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(817, 630);
            painelPrincipal.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 710);
            Controls.Add(painelPrincipal);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "Tela Inicial";
            Load += frmPrincipal_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Button btnCadFuncionario;
        private Button btnCadProduto;
        private Panel panel2;
        private Panel panel1;
        private Panel painelPrincipal;
        private Button btnSair;
        private Button btnPerfil;
    }
}