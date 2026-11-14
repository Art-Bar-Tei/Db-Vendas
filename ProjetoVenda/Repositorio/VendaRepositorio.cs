using MySqlConnector;
using ProjetoVenda.database;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.repository
{
    internal class VendaRepositorio
    {
        public bool CadastrarVenda(Venda venda)
        {
            using MySqlConnection conector = BancoDeDados.PegarConexao();
            using MySqlTransaction transisao = conector.BeginTransaction();
            try
            {
                foreach (var item in venda.itens.OrderBy(item => item.id_produto))
                {
                    string sqlBloqueio = "SELECT * FROM produto WHERE id_produto = @id_produto FOR UPDATE";
                    using var cmdBloqueio = new MySqlCommand(sqlBloqueio, conector, transisao);
                    cmdBloqueio.Parameters.AddWithValue("@id_produto", item.id_produto);
                    using var leitor = cmdBloqueio.ExecuteReader();
                    if (!leitor.Read())
                    {
                        throw new Exception("Erro no registro!!!");
                    }
                    int quantidadeDisponivel = leitor.GetInt32("quantidade");
                    if (quantidadeDisponivel < item.quantidade)
                    {
                        throw new Exception($"Quantidade insuficiente para o produto {item.nome}");
                    }
                }

                string sqlVenda = @"INSERT INTO venda (id_funcionario) 
                               VALUES (@id_funcionario)";
                using var cmdVenda = new MySqlCommand(sqlVenda, conector, transisao);
                cmdVenda.Parameters.AddWithValue("@id_funcionario", venda.id_funcionario);
                cmdVenda.ExecuteNonQuery();
                venda.id_venda = (int)cmdVenda.LastInsertedId;


                foreach (Item item in venda.itens)
                {
                    string sqlItem = @"INSERT INTO item (id_venda, id_produto)
                                   VALUES (@id_venda, @id_produto)";
                    using MySqlCommand cmdItem = new MySqlCommand(sqlItem, conector, transisao);
                    cmdItem.Parameters.AddWithValue("@id_venda", venda.id_venda);
                    cmdItem.Parameters.AddWithValue("@id_produto", item.id_produto);
                    cmdItem.Parameters.AddWithValue("@quantidade", item.quantidade);
                    cmdItem.Parameters.AddWithValue("@preco", item.preco);
                    int linhasAlteradas = cmdItem.ExecuteNonQuery();
                    if (linhasAlteradas != 1)
                    {
                        throw new Exception($"Erro ao cadastrar o pro {item.nome}");
                    }
                    string sqlUpdateQuantidade = @"UPDATE produto SET quantidade = quantidade - @quantidade 
                                               WHERE id_produto = @id_produto";
                    using MySqlCommand cmdUpdateQuantidade = new MySqlCommand(sqlUpdateQuantidade, conector, transisao);
                    cmdUpdateQuantidade.Parameters.AddWithValue("@quantidade", item.quantidade);
                    cmdUpdateQuantidade.Parameters.AddWithValue("@id_produto", item.id_produto);
                    int linhasAtualizadas = cmdUpdateQuantidade.ExecuteNonQuery();
                    if (linhasAtualizadas != 1)
                    {
                        throw new Exception($"Erro ao atualizar a quantidade do produto {item.nome}");
                    }
                    cmdUpdateQuantidade.ExecuteNonQuery();
                }
                transisao.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transisao.Rollback();
                throw ex;
                return false;
            }

        }
    }
}
