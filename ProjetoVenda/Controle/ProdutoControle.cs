using ProjetoVenda.model;
using ProjetoVenda.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.controller
{
    internal class ProdutoControle
    {
        private ProdutoRepositorio repositorio;

        public ProdutoControle()
        {
            repositorio = new ProdutoRepositorio();
        }

        public bool criarProduto(Produto produto)
        {
            int id_funcionario = Sessao.usuarioAutenticado.id_funcionario;
            produto.id_funcionario = id_funcionario;
            produto.validar();
            // fazer o cadastro
            repositorio.criarProduto(produto);

            return true;
        }

        public List<Produto> ListarProdutos()
        {
            return repositorio.pegarTodos();
        }

        public List<Produto> listarPorPagina(int qtd, int pagina)
        {
            return repositorio.listarPorPagina(qtd, pagina);
        }


        public int quantidadePaginas(int quantidadeItens)
        {
            int totalProdutos = repositorio.quantidadeProdutos();
            return (int)Math.Ceiling((decimal)totalProdutos / quantidadeItens);
        }


        public bool atualizar(Produto product)
        {
            return repositorio.atualizar(product);
        }

        public bool excluir(Produto product)
        {
            return repositorio.excluir(product.id_produto);
        }

        
    
    }
}
