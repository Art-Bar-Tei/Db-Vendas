using ProjetoVenda.model;
using ProjetoVenda.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.controller
{
    internal class VendaControle
    {

        FuncionarioControle FuncionarioControle;
        VendaRepositorio VendaRepositorio;
        public VendaControle()
        {
            FuncionarioControle = new FuncionarioControle();
            VendaRepositorio = new VendaRepositorio();
        }

        public bool cadastrarVenda(List<Item> itens)
        {
            Funcionario? funcionarioLogado = FuncionarioControle.usuarioAutenticado();
            if (funcionarioLogado == null)
            {
                throw new Exception("Funcionario não autenticado");

            }
            int idFuncionario = funcionarioLogado.id_funcionario;
            Venda venda = new Venda
            {
                id_funcionario = idFuncionario,
                date = DateTime.Now,
                itens = itens,
                nome_funcionario = funcionarioLogado.nome
            };
            VendaRepositorio.CadastrarVenda(venda);
            return true;
        }
    }

}
