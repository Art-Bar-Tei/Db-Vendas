using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.database
{
    internal static class BancoDeDados
    {
        private static string textoDeConexao;


        static BancoDeDados()
        {
            MySqlConnectionStringBuilder construtor = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Port = 3306,
                Database = "db_vendas",
                UserID = "root",
                Password = ""
            };
            textoDeConexao = construtor.ConnectionString;
        }

        public static MySqlConnection PegarConexao()
        {
            MySqlConnection connection = new MySqlConnection(textoDeConexao);
            try
            {
                connection.Open();
                return connection;
            }catch (MySqlException ex)
            {
                connection.Dispose();
                throw;
            }
        }

    }
}
