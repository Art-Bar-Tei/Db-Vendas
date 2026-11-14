using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ProjetoVenda.database;
using ProjetoVenda.model;
using MySqlConnector;

namespace ProjetoVenda.repository
{
    internal class FuncionrioRepositorio
    {
        private Funcionario mapear(MySqlDataReader leitor)
        {
            return new Funcionario
            { 
                id_funcionario = leitor.IsDBNull(leitor.GetOrdinal("id_funcionario")) ? 0 : leitor.GetInt32("id_funcionario"),
                nome = leitor.GetString("nome"),
                usuario = leitor.GetString("usuario"),
                senha = leitor.GetString("senha"),
                telefone = leitor.GetString("telefone"),
                rua = ( leitor.IsDBNull(leitor.GetOrdinal("rua")) ) 
                    ? null : leitor.GetString("rua"),
                numero = leitor.GetString("numero"),
                complemento = (leitor.IsDBNull(leitor.GetOrdinal("complemento")))
                    ? null : leitor.GetString("complemento"),
                cep = leitor.GetString("cep"),
                adm = leitor.GetBoolean("adm")
            };

        }
        public List<Funcionario> pegarPorNomeDeUsuario()
        {
            using MySqlConnection conector = BancoDeDados.PegarConexao();
            string sql = "SELECT * FROM funcionario";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            using var leitor = cmd.ExecuteReader();

            List<Funcionario> lista = new List<Funcionario>();
            while (leitor.Read())
            {
                lista.Add(mapear(leitor));
            }
            return lista;
        }

        public Funcionario? pegarPorNomeDeUsuario(string usuario)
        {
            using MySqlConnection conector = BancoDeDados.PegarConexao();
            string sql = "SELECT * FROM funcionario WHERE usuario = @usuario";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            using var leitor = cmd.ExecuteReader();
            if (leitor .Read())
            {
                return mapear(leitor);
            }
            return null;
        }

        public int createEmployee(Funcionario funcionario)
        {
            using MySqlConnection conector = BancoDeDados.PegarConexao();
            string sql = @"INSERT INTO funcionario
                (nome, usuario, senha, telefone, rua, numero, complemento, cep, adm) 
                VALUES 
                (@nome, @usuario, @senha, @telefone, @rua, @numero, @complemento, @cep, @adm)";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            cmd.Parameters.AddWithValue("@rua", funcionario.rua);
            cmd.Parameters.AddWithValue("@numero", funcionario.numero);
            cmd.Parameters.AddWithValue("@complemento", funcionario.complemento);
            cmd.Parameters.AddWithValue("@cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@adm", funcionario.adm);

            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

    
    }
}
