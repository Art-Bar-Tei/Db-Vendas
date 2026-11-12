using ProjetoVenda.model;
using ProjetoVenda.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.controller
{
    internal class VendaControle
    {

        EmployeeController EmployeeController;
        VendaRepositorio VendaRepositorio;
        public VendaControle()
        {
            EmployeeController = new EmployeeController();
            VendaRepositorio = new VendaRepositorio();
        }

        public bool cadastrarVenda(List <Item> itens)
        {
            Employee? funcionarioLogado = EmployeeController.usuarioAutenticado();
            if(funcionarioLogado == null)
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
