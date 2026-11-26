using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using DotNetEnv;

namespace ProjetoVenda.database
{
    internal static class BancoDeDados
    {
        private static string textoDeConexao;


        static BancoDeDados()
        {
            string caminho = Path.Combine(Directory.GetCurrentDirectory(), ".env");
            Env.Load(caminho);


            MySqlConnectionStringBuilder construtor = new MySqlConnectionStringBuilder
            {
                
                Server = Env.GetString("DB_HOST"),
                Port = Convert.ToUInt32(Env.GetString("DB_PORT")),
                Database = Env.GetString("DB_NAME"),
                UserID = Env.GetString("DB_USER"),
                Password = Env.GetString("DB_PASSWORD")
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
