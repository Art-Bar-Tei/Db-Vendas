using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.database
{
    internal static class Database
    {
        private static string stringConnection;


        static Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Port = 3306,
                Database = "db_vendas",
                UserID = "root",
                Password = ""
            };
            stringConnection = builder.ConnectionString;
        }

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(stringConnection);
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
