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
        private FuncionrioRepositorio repositorio;

        public FuncionarioControle()
        {
            repositorio = new FuncionrioRepositorio();
        }

        public List<Funcionario> pegarPorFuncionario()
        {
            return repositorio.pegarPorNomeDeUsuario();
        }

        public static bool login(string usuario, string senha)
        {
            FuncionrioRepositorio respository = new FuncionrioRepositorio();
            Funcionario? resposta = respository.pegarPorNomeDeUsuario(usuario);
            if (resposta == null)
            {
                return false;
            }


            bool validateSenha;
            try
            {
                validateSenha = BCrypt.Net.BCrypt.Verify(senha, resposta.senha);
            }catch(Exception ex)
            {
                validateSenha = false;
            }

            if ( !validateSenha )
            {
                return false;
            }
            // gravar os dados do usuario logado!!!!
            Sessao.usuarioAutenticado = resposta;
            return true;

        }


        public bool CriarFuncionario(Funcionario funcionario, Funcionario funcionarios)
        {

            // fazer verificação se o usuario nao existe
            // solicitar ao respository se o usuario existe
            FuncionrioRepositorio respository = new FuncionrioRepositorio();
            Funcionario? resp = respository.pegarPorNomeDeUsuario(funcionarios.usuario);
            if (resp != null)
            {
                return false;
            }

            string SenhaCriptografada = BCrypt.Net.BCrypt.HashPassword(funcionarios.senha);
           
            return true;
        }

        public void deslogar()
        {
            Sessao.usuarioAutenticado = null;
        }
        public Funcionario? usuarioAutenticado()
        {
            return Sessao.usuarioAutenticado;
        }
        public bool usuarioADM()
        {
            if (Sessao.usuarioAutenticado == null)
            {
                return false;
            }
            return Sessao.usuarioAutenticado.adm;
        }
    }
}
