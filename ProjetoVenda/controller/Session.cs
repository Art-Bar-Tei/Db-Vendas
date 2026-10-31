using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVenda.model;

namespace ProjetoVenda.controller
{
    internal static class Session
    {
        public static Employee? userAuth;

        public static bool isAdmin = false;

    }
}
