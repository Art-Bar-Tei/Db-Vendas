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
    public partial class frmPerfil : Form
    {
        private FuncionarioControle controle;
        private Funcionario? funcionario;
        public frmPerfil()
        {
            InitializeComponent();
            controle = new FuncionarioControle();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            funcionario = controle.usuarioAutenticado();
            if (funcionario != null)
            {
                carregarInformacoesFuncionario();
            }
        }
        private void carregarInformacoesFuncionario()
        {
            if (funcionario != null)
            {
                txtNome.Text = funcionario.nome;
                txtTel.Text = funcionario.telefone;
                txtRua.Text = funcionario.rua;
                txtNúmero.Text = funcionario.numero.ToString();
                txtCEP.Text = funcionario.cep;
                txtComplemento.Text = funcionario.complemento;
                txtUser.Text = funcionario.usuario;
            }
        }
    }
    
}

