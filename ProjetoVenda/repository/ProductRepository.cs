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
        private Product map(MySqlDataReader reader)
        {
            return new Product
            {
                cod_produto = reader.GetInt32("cod_produto"),
                cod_funcionario = reader.GetInt32("cod_funcionario"),
                nome = reader.GetString("nome"),
                marca = reader.GetString("marca"),
                preco = reader.GetDouble("preco"),
                quantidade = reader.GetInt32("quantidade"),
                data_registro = reader.GetDateTime("data_registro")
            };
        }

        public int createProduct(Product product)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = @"INSERT INTO produto
                (cod_funcionario, nome, marca, preco, quantidade) 
                VALUES 
                (@cod_funcionario, @nome, @marca, @preco, @quantidade)";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@cod_funcionario", product.cod_funcionario);
            cmd.Parameters.AddWithValue("@nome", product.nome);
            cmd.Parameters.AddWithValue("@marca", product.marca);
            cmd.Parameters.AddWithValue("@preco", product.preco);
            cmd.Parameters.AddWithValue("@quantidade", product.quantidade);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

        public List<Product> getAll()
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT * FROM produto";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            using var reader = cmd.ExecuteReader();

            List<Product> list = new List<Product>();
            while (reader.Read())
            {
                list.Add( map(reader) );
            }
            return list;
        }

        public List<Product> listarPorPagina(int qtd, int pagina)
        {
            int offset = qtd * (pagina - 1);
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT * FROM produto LIMIT @limit OFFSET @offset";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@limit", qtd);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var reader = cmd.ExecuteReader();

            List<Product> list = new List<Product>();
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

        public bool atualizar(Product produto)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = @"UPDATE produto SET
                    nome = @nome, marca = @marca, preco = @preco, quantidade = @quantidade
                WHERE cod_produto = @cod_produto";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@cod_produto", produto.cod_produto);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("@preco", produto.preco);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool excluir(int cod_produto)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = @"DELETE FROM produto WHERE cod_produto = @cod_produto";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@cod_produto", cod_produto);
            return cmd.ExecuteNonQuery() > 0;
        }


    }
}
