using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ProjetoVenda.database;
using ProjetoVenda.model;
using MySqlConnector;

namespace ProjetoVenda.repository
{
    internal class EmployeeRepository
    {
        private Employee map(MySqlDataReader reader)
        {
            return new Employee
            {
                cod_funcionario = reader.GetInt32("cod_funcionario"),
                nome = reader.GetString("nome"),
                usuario = reader.GetString("usuario"),
                senha = reader.GetString("senha"),
                telefone = reader.GetString("telefone"),
                rua = ( reader.IsDBNull(reader.GetOrdinal("rua")) ) 
                    ? null : reader.GetString("rua"),
                numero = reader.GetString("numero"),
                complemento = (reader.IsDBNull(reader.GetOrdinal("complemento")))
                    ? null : reader.GetString("complemento"),
                cep = reader.GetString("cep")
            };
        }

        public Employee? getByUsername(string username)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT * FROM funcionario WHERE usuario = @username";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@username", username);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return map(reader);
            }
            return null;
        }

        public int createEmployee(Employee employee)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = @"INSERT INTO funcionario
                (nome, usuario, senha, telefone, rua, numero, complemento, cep) 
                VALUES 
                (@nome, @usuario, @senha, @telefone, @rua, @numero, @complemento, @cep)";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@nome", employee.nome);
            cmd.Parameters.AddWithValue("@usuario", employee.usuario);
            cmd.Parameters.AddWithValue("@senha", employee.senha);
            cmd.Parameters.AddWithValue("@telefone", employee.telefone);
            cmd.Parameters.AddWithValue("@rua", employee.rua);
            cmd.Parameters.AddWithValue("@numero", employee.numero);
            cmd.Parameters.AddWithValue("@complemento", employee.complemento);
            cmd.Parameters.AddWithValue("@cep", employee.cep);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

    
    }
}
