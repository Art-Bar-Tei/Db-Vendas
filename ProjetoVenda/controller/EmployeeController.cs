using System;
using System.Collections.Generic;
using System.Text;
using BCrypt.Net;
using ProjetoVenda.model;
using ProjetoVenda.repository;

namespace ProjetoVenda.controller
{
    internal class EmployeeController
    {
        private EmployeeRepository repository;

        public EmployeeController()
        {
            repository = new EmployeeRepository();
        }

        public List<Employee> getFuncionariosl()
        {
            return repository.getFuncionarios();
        }

        public static bool login(string username, string password)
        {
            EmployeeRepository respository = new EmployeeRepository();
            Employee? resp = respository.getByUsername(username);
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
            Session.userAuth = resp;
            return true;

        }


        public bool createEmployee(Employee funcionario, Employee funcionarios)
        {

            // fazer verificação se o usuario nao existe
            // solicitar ao respository se o usuario existe
            EmployeeRepository respository = new EmployeeRepository();
            Employee? resp = respository.getByUsername(funcionarios.usuario);
            if (resp != null)
            {
                return false;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(funcionarios.senha);
           
            return true;
        }

        public void deslogar()
        {
            Session.userAuth = null;
        }
        public Employee? usuarioAutenticado()
        {
            return Session.userAuth;
        }
        public bool usuarioADM()
        {
            if (Session.userAuth == null)
            {
                return false;
            }
            return Session.userAuth.adm;
        }
    }
}
