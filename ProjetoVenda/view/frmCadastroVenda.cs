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


    public partial class frmCadastroVenda : Form
    {
        private ProductController producoControle;
        public frmCadastroVenda()
        {
            InitializeComponent();
            producoControle = new ProductController();
        }

        private void carregarVendas()
        {
            List<Product> lista = producoControle.ListarProdutos();
            cbxProdutos.DataSource = lista;
            cbxProdutos.DisplayMember = "nome";
            cbxProdutos.ValueMember = "id_produto";

        }
        private void frmCadastroVenda_Load(object sender, EventArgs e)
        {
            carregarVendas();
        }

        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product= cbxProdutos.SelectedItem as Product;
            this.lblPreco.Text = $"Preço Unitario: R$ {product.preco}";
            this.lblQuantidade.Text = $"Quantidade Disponivel: {product.quantidade}";
            this.nunQuantidade.Maximum = product.quantidade;
            this.nunQuantidade.Value = 1;
            this.nunQuantidade.Minimum = (this.nunQuantidade.Maximum>0) ? 1 : 0;

        }
    }
}

