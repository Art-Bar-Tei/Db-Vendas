using ProjetoVenda.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.view
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            this.txtNome.Clear();
            this.txtTelefone.Clear();
            this.txtRua.Clear();
            this.txtNumero.Clear();
            this.txtCep.Clear();
            this.txtComplemento.Clear();
            this.txtUsuario.Clear();
            this.txtSenha.Clear();
            this.txtSenha1.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string telefone = this.txtTelefone.Text;
            string rua = this.txtRua.Text;
            string numero = this.txtNumero.Text;
            string cep = this.txtCep.Text;
            string complemento = this.txtComplemento.Text;

            string usuario = this.txtUsuario.Text;
            string senha = this.txtSenha.Text;
            string senha1 = this.txtSenha1.Text;

            if (senha != senha1)
            {
                MessageBox.Show(
                    "Senhas nao Confere",
                    "Senhas incorretas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                 );
                return;
            }

            // chamar o controlador do usuario para cadastro
            EmployeeController controller = new EmployeeController();

            bool resp = controller.createEmployee(nome, telefone, rua, numero, cep, 
                complemento, usuario, senha);

            if (resp)
            {
                MessageBox.Show("Funcionario Cadastrado Com Sucesso",
                    "Cadastro Funcionario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar Funcionario",
                    "Cadastro Funcionario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
