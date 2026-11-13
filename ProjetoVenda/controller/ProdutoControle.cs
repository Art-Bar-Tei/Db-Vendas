using ProjetoVenda.model;
using ProjetoVenda.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.controller
{
    internal class ProdutoControle
    {
        private ProductRepository repository;

        public ProdutoControle()
        {
            repository = new ProductRepository();
        }

        public bool createProduct(Produto produto)
        {
            int id_funcionario = Sessao.userAuth.id_funcionario;
            produto.id_funcionario = id_funcionario;
            produto.validar();
            // fazer o cadastro
            repository.createProduct(produto);

            return true;
        }

        public List<Produto> ListarProdutos()
        {
            return repository.getAll();
        }

        public List<Produto> listarPorPagina(int qtd, int pagina)
        {
            return repository.listarPorPagina(qtd, pagina);
        }


        public int quantidadePaginas(int quantidadeItens)
        {
            int totalProdutos = repository.quantidadeProdutos();
            return (int)Math.Ceiling((decimal)totalProdutos / quantidadeItens);
        }


        public bool atualizar(Produto product)
        {
            return repository.atualizar(product);
        }

        public bool excluir(Produto product)
        {
            return repository.excluir(product.id_produto);
        }

        
    
    }
}
