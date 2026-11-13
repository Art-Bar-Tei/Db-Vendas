using MySqlConnector;
using ProjetoVenda.database;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.repository
{
    internal class ProductRepository
    {
        private Produto map(MySqlDataReader reader)
        {
            return new Produto
            {
                id_produto = reader.GetInt32("id_produto"),
                id_funcionario = reader.GetInt32("id_funcionario"),
                nome = reader.GetString("nome"),
                marca = reader.GetString("marca"),
                preco = reader.GetInt32("preco"),
                quantidade = reader.GetInt32("quantidade"),
                data_registro = reader.GetDateTime("data_registro")
            };
        }

        public int createProduct(Produto product)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = @"INSERT INTO produto
                (id_funcionario, nome, marca, preco, quantidade) 
                VALUES 
                (@id_funcionario, @nome, @marca, @preco, @quantidade)";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@id_funcionario", product.id_funcionario);
            cmd.Parameters.AddWithValue("@nome", product.nome);
            cmd.Parameters.AddWithValue("@marca", product.marca);
            cmd.Parameters.AddWithValue("@preco", product.preco);
            cmd.Parameters.AddWithValue("@quantidade", product.quantidade);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

        public List<Produto> getAll()
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT * FROM produto";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            using var reader = cmd.ExecuteReader();

            List<Produto> list = new List<Produto>();
            while (reader.Read())
            {
                list.Add( map(reader) );
            }
            return list;
        }

        public List<Produto> listarPorPagina(int qtd, int pagina)
        {
            int offset = qtd * (pagina - 1);
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT * FROM produto LIMIT @limit OFFSET @offset";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@limit", qtd);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var reader = cmd.ExecuteReader();

            List<Produto> list = new List<Produto>();
            while (reader.Read())
            {
                list.Add(map(reader));
            }
            return list;
        }
        
        public int quantidadeProdutos()
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT COUNT(*) FROM produto";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool atualizar(Produto produto)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = @"UPDATE produto SET
                    nome = @nome, marca = @marca, preco = @preco, quantidade = @quantidade
                WHERE id_produto = @id_produto";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@id_produto", produto.id_produto);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("@preco", produto.preco);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool excluir(int id_produto)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = @"DELETE FROM produto WHERE id_produto = @id_produto";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            return cmd.ExecuteNonQuery() > 0;
        }


    }
}
