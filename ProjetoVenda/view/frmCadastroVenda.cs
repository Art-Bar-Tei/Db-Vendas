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
        private ProdutoControle producoControle;
        private VendaControle vendaControle;

        public frmCadastroVenda()
        {
            InitializeComponent();


            producoControle = new ProdutoControle();
            vendaControle = new VendaControle();
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

            this.dgvCarrinho.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Sub-total",
                DataPropertyName = "subTotal",
                Name = "colunaSubTotal",
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "C2" }
            });

            this.dgvCarrinho.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Excluir",
                Name = "colunaExcluir",
                Text = "Excluir",
                UseColumnTextForButtonValue = true
            });

        }

        private void carregarVendas()

        {
            List<Produto> lista = producoControle.ListarProdutos();
            cbxProdutos.DataSource = lista;
            cbxProdutos.DisplayMember = "nome";
            cbxProdutos.ValueMember = "id_produto";

        }

        public void atualizarCarrinho()
        {
            this.dgvCarrinho.DataSource = this.carrinho.ToList();
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
            Produto? product = cbxProdutos.SelectedItem as Produto;
            this.lblPreco.Text = $"Preço Unitario: R$ {product.valorReal:C2}";//QUEBROUUUUUU
            this.lblQuantidade.Text = $"Quantidade Disponivel: {product.quantidade}";
            this.nunQuantidade.Maximum = product.quantidade;
            this.nunQuantidade.Value = (this.nunQuantidade.Maximum > 0) ? 1 : 0;


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto product = cbxProdutos.SelectedItem as Produto;
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
            if(quantidade < 0)
            {
                MessageBox.Show("Quantidade inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            
            try
            {
                bool resposta = vendaControle.cadastrarVenda(this.carrinho);
                if (resposta)
                {
                    carrinho.Clear();
                    frmCadastroVenda_Load(this, EventArgs.Empty);
                    MessageBox.Show
                        ("Venda cadastrada com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show
                        ("Erro ao cadastrar venda!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    ($"Erro ao cadastrar venda: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (this.dgvCarrinho.Columns[e.ColumnIndex].Name.Equals("colunaExcluir"))
            {
                ExcluirItemCarrinho(e.RowIndex);
            }
        }
        
        private void ExcluirItemCarrinho(int Indice)
        {
            DialogResult confirmar = MessageBox.Show
                ($"Deseja excluir o item do carrinho?",
                "Excluir Item",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.No)
            {
                return;
            }
            this.carrinho.RemoveAt(Indice);
            atualizarCarrinho();

            // Excluir o item do carrinho
        }
    }
}

