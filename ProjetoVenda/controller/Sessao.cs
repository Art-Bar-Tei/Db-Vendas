using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVenda.model;

namespace ProjetoVenda.controller
{
    internal static class Sessao
    {
        public static Funcionario? userAuth;

        public static bool isAdmin = false;

    }
}
