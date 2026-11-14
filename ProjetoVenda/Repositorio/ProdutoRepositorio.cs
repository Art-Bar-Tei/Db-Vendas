using MySqlConnector;
using ProjetoVenda.database;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.repository
{
    internal class ProdutoRepositorio
    {
        private Produto mapear(MySqlDataReader leitor)
        {
            return new Produto
            {
                id_produto = leitor.GetInt32("id_produto"),
                id_funcionario = leitor.GetInt32("id_funcionario"),
                nome = leitor.GetString("nome"),
                marca = leitor.GetString("marca"),
                preco = leitor.GetInt32("preco"),
                quantidade = leitor.GetInt32("quantidade"),
                data_registro = leitor.GetDateTime("data_registro")
            };
        }

        public int criarProduto(Produto product)
        {
            using MySqlConnection conector = BancoDeDados.PegarConexao();
            string sql = @"INSERT INTO produto
                (id_funcionario, nome, marca, preco, quantidade) 
                VALUES 
                (@id_funcionario, @nome, @marca, @preco, @quantidade)";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@id_funcionario", product.id_funcionario);
            cmd.Parameters.AddWithValue("@nome", product.nome);
            cmd.Parameters.AddWithValue("@marca", product.marca);
            cmd.Parameters.AddWithValue("@preco", product.preco);
            cmd.Parameters.AddWithValue("@quantidade", product.quantidade);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

        public List<Produto> pegarTodos()
        {
            using MySqlConnection connector = BancoDeDados.PegarConexao();
            string sql = "SELECT * FROM produto";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            using var reader = cmd.ExecuteReader();

            List<Produto> lista = new List<Produto>();
            while (reader.Read())
            {
                lista.Add( mapear(reader) );
            }
            return lista;
        }

        public List<Produto> listarPorPagina(int qtd, int pagina)
        {
            int offset = qtd * (pagina - 1);
            using MySqlConnection conector = BancoDeDados.PegarConexao();
            string sql = "SELECT * FROM produto LIMIT @limit OFFSET @offset";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@limit", qtd);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var reader = cmd.ExecuteReader();

            List<Produto> lista = new List<Produto>();
            while (reader.Read())
            {
                lista.Add(mapear(reader));
            }
            return lista;
        }
        
        public int quantidadeProdutos()
        {
            using MySqlConnection conector = BancoDeDados.PegarConexao();
            string sql = "SELECT COUNT(*) FROM produto";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool atualizar(Produto produto)
        {
            using MySqlConnection conector = BancoDeDados.PegarConexao();
            string sql = @"UPDATE produto SET
                    nome = @nome, marca = @marca, preco = @preco, quantidade = @quantidade
                WHERE id_produto = @id_produto";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@id_produto", produto.id_produto);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("@preco", produto.preco);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool excluir(int id_produto)
        {
            using MySqlConnection conector = BancoDeDados.PegarConexao();
            string sql = @"DELETE FROM produto WHERE id_produto = @id_produto";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            return cmd.ExecuteNonQuery() > 0;
        }


    }
}
