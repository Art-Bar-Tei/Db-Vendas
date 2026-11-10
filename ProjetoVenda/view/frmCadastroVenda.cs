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
        private List<Item> carrinho = new List<Item>();

        private ProductController producoControle;
        public frmCadastroVenda()
        {
            InitializeComponent();


            producoControle = new ProductController();
        }
        private void configurarCarrinho()
        {
            this.dgvCarrinho.AutoGenerateColumns = false;
            this.dgvCarrinho.Columns.Clear();
            this.dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Produto",
                DataPropertyName = "nome",
                Name = "colunaNome"
            });
            this.dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Marca",
                DataPropertyName = "marca",
                Name = "colunaMarca"
            });
            this.dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Preço",
                DataPropertyName = "valorReal",
                Name = "colunaPreco",
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "C2" }
            });
            this.dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Quantidade",
                DataPropertyName = "quantidade",
                Name = "colunaQuantidade"
            });
            this.dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Sub-total",
                DataPropertyName = "subTotal",
                Name = "colunaSubTotal",
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "C2" }
            });

        }

        private void carregarVendas()

        {
            List<Product> lista = producoControle.ListarProdutos();
            cbxProdutos.DataSource = lista;
            cbxProdutos.DisplayMember = "nome";
            cbxProdutos.ValueMember = "id_produto";

        }

        public void atualizarCarrinho()
        {
            this.dgvCarrinho.DataSource = null;
            this.dgvCarrinho.DataSource = this.carrinho;
            this.btnCadastrar.Enabled = this.carrinho.Count() > 0;
            decimal total = this.carrinho.Sum(item => item.subTotal);
            this.lblPrecoTotal.Text = $"Total Venda: R$ {total:C2}";
        }
        private void frmCadastroVenda_Load(object sender, EventArgs e)
        {
            carregarVendas();
            configurarCarrinho();
            atualizarCarrinho();
        }

        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product? product = cbxProdutos.SelectedItem as Product;
            this.lblPreco.Text = $"Preço Unitario: R$ {product.valorReal:C2}";//QUEBROUUUUUU
            this.lblQuantidade.Text = $"Quantidade Disponivel: {product.quantidade}";
            this.nunQuantidade.Maximum = product.quantidade;
            this.nunQuantidade.Value = (this.nunQuantidade.Maximum > 0) ? 1 : 0;
            

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Product product = cbxProdutos.SelectedItem as Product;
            int quantidade = (int)this.nunQuantidade.Value;

            Item? itemexistente = this.carrinho.FirstOrDefault(item => item.id_produto == product.id_produto);
            if (itemexistente == null)
            {
                Item novoItem = new Item
                {
                    id_produto = product.id_produto,
                    quantidade = quantidade,
                    preco = product.preco,
                    nome = product.nome,
                    marca = product.marca
                };
                this.carrinho.Add(novoItem);
            }
            else
            {
                itemexistente.quantidade += quantidade;
            }
            product.quantidade -= quantidade;
            this.cbxProdutos.SelectedItem = product;
            cbxProdutos_SelectedIndexChanged(this, EventArgs.Empty);
            atualizarCarrinho();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            decimal total = this.carrinho.Sum(item => item.subTotal);
            DialogResult confirmar = MessageBox.Show
                ($"Deseja confirmar a venda no valor: {total:C2}?",
                "Confirmação Venda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.No)
            {
                return;
            }
            carrinho.Clear();
            frmCadastroVenda_Load(this, EventArgs.Empty);
            MessageBox.Show
                ("Venda cadastrada com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}

