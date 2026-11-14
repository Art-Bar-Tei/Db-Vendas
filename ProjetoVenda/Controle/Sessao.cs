using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVenda.model;

namespace ProjetoVenda.controller
{
    internal static class Sessao
    {
        public static Funcionario? usuarioAutenticado;

        public static bool eAdmin = false;

    }
}
