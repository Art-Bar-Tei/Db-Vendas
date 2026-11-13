using ProjetoVenda.controller;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.view
{
    public partial class frmPrincipal : Form
    {
        private FuncionarioControle controller;

        public frmPrincipal()
        {
            InitializeComponent();
            controller = new FuncionarioControle();
            Funcionario? funcionario = controller.usuarioAutenticado();
            string nome = (funcionario != null) ? funcionario.nome : "";
            this.Text += $" - {nome}";
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            bool adm = controller.usuarioADM();
            if (adm)
            {
                this.btnCadFuncionario.Enabled = true;
            }
            else
            {
                this.btnCadFuncionario.Enabled = false;
            }

        }

        private void exibirFormulario(Form formulario)
        {
            while (painelPrincipal.Controls.Count > 0)
            {
                painelPrincipal.Controls[0].Dispose();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            this.lblTitulo.Text = formulario.Text;

            painelPrincipal.Controls.Add(formulario);
            formulario.Show();
        }



        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            exibirFormulario(frm);
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            exibirFormulario(frm);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // evento para sair
            controller.deslogar();
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmPerfil frm = new frmPerfil();
            exibirFormulario(frm);
        }

        private void btnCadVendas_Click(object sender, EventArgs e)
        {
            frmCadastroVenda frm = new frmCadastroVenda();
            exibirFormulario(frm);
        }

    }
}
