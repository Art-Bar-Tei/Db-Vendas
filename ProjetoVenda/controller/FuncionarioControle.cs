using System;
using System.Collections.Generic;
using System.Text;
using BCrypt.Net;
using ProjetoVenda.model;
using ProjetoVenda.repository;

namespace ProjetoVenda.controller
{
    internal class FuncionarioControle
    {
        private EmployeeRepository repository;

        public FuncionarioControle()
        {
            repository = new EmployeeRepository();
        }

        public List<Funcionario> getFuncionariosl()
        {
            return repository.getFuncionarios();
        }

        public static bool login(string username, string password)
        {
            EmployeeRepository respository = new EmployeeRepository();
            Funcionario? resp = respository.getByUsername(username);
            if (resp == null)
            {
                return false;
            }


            bool validatePassword;
            try
            {
                validatePassword = BCrypt.Net.BCrypt.Verify(password, resp.senha);
            }catch(Exception ex)
            {
                validatePassword = false;
            }

            if ( !validatePassword )
            {
                return false;
            }
            // gravar os dados do usuario logado!!!!
            Sessao.userAuth = resp;
            return true;

        }


        public bool createEmployee(Funcionario funcionario, Funcionario funcionarios)
        {

            // fazer verificação se o usuario nao existe
            // solicitar ao respository se o usuario existe
            EmployeeRepository respository = new EmployeeRepository();
            Funcionario? resp = respository.getByUsername(funcionarios.usuario);
            if (resp != null)
            {
                return false;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(funcionarios.senha);
           
            return true;
        }

        public void deslogar()
        {
            Sessao.userAuth = null;
        }
        public Funcionario? usuarioAutenticado()
        {
            return Sessao.userAuth;
        }
        public bool usuarioADM()
        {
            if (Sessao.userAuth == null)
            {
                return false;
            }
            return Sessao.userAuth.adm;
        }
    }
}
