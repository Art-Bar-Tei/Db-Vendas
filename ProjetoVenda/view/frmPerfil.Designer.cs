namespace ProjetoVenda.view
{
    partial class frmPerfil
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
            label1 = new Label();
            lblNome = new Label();
            lblRua = new Label();
            lblNúmero = new Label();
            lblTel = new Label();
            lblCEP = new Label();
            lblComplemento = new Label();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            txtNome = new TextBox();
            txtTel = new TextBox();
            txtRua = new TextBox();
            txtNúmero = new TextBox();
            txtCEP = new TextBox();
            txtComplemento = new TextBox();
            txtUser = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 44);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Cursor = Cursors.No;
            lblNome.Location = new Point(296, 44);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Cursor = Cursors.No;
            lblRua.Location = new Point(37, 231);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(27, 15);
            lblRua.TabIndex = 2;
            lblRua.Text = "Rua";
            // 
            // lblNúmero
            // 
            lblNúmero.AutoSize = true;
            lblNúmero.Cursor = Cursors.No;
            lblNúmero.Location = new Point(389, 231);
            lblNúmero.Name = "lblNúmero";
            lblNúmero.Size = new Size(21, 15);
            lblNúmero.TabIndex = 3;
            lblNúmero.Text = "N°";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Cursor = Cursors.No;
            lblTel.Location = new Point(296, 129);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(52, 15);
            lblTel.TabIndex = 4;
            lblTel.Text = "Telefone";
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Cursor = Cursors.No;
            lblCEP.Location = new Point(594, 231);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(28, 15);
            lblCEP.TabIndex = 5;
            lblCEP.Text = "CEP";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(37, 286);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 6;
            lblComplemento.Text = "Complemento";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Foto;
            pictureBox1.Location = new Point(37, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(389, 286);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(30, 15);
            lblUsuario.TabIndex = 8;
            lblUsuario.Text = "User";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(296, 75);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(371, 23);
            txtNome.TabIndex = 9;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(296, 147);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(371, 23);
            txtTel.TabIndex = 10;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(37, 249);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(289, 23);
            txtRua.TabIndex = 11;
            // 
            // txtNúmero
            // 
            txtNúmero.Location = new Point(389, 249);
            txtNúmero.Name = "txtNúmero";
            txtNúmero.Size = new Size(125, 23);
            txtNúmero.TabIndex = 12;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(594, 249);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(125, 23);
            txtCEP.TabIndex = 13;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(37, 319);
            txtComplemento.Multiline = true;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(289, 52);
            txtComplemento.TabIndex = 14;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(389, 319);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(371, 23);
            txtUser.TabIndex = 15;
            // 
            // frmPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 450);
            Controls.Add(txtUser);
            Controls.Add(txtComplemento);
            Controls.Add(txtCEP);
            Controls.Add(txtNúmero);
            Controls.Add(txtRua);
            Controls.Add(txtTel);
            Controls.Add(txtNome);
            Controls.Add(lblUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(lblComplemento);
            Controls.Add(lblCEP);
            Controls.Add(lblTel);
            Controls.Add(lblNúmero);
            Controls.Add(lblRua);
            Controls.Add(lblNome);
            Controls.Add(label1);
            Name = "frmPerfil";
            Text = "frmPerfil";
            Load += frmPerfil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNome;
        private Label lblRua;
        private Label lblNúmero;
        private Label lblTel;
        private Label lblCEP;
        private Label lblComplemento;
        private PictureBox pictureBox1;
        private Label lblUsuario;
        private TextBox txtNome;
        private TextBox txtTel;
        private TextBox txtRua;
        private TextBox txtNúmero;
        private TextBox txtCEP;
        private TextBox txtComplemento;
        private TextBox txtUser;
    }
}