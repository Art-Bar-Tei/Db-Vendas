using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.model
{
    internal class Funcionario
    {
        public int id_funcionario{ get; set; }
        public string nome{ get; set; }
        public string usuario{ get; set; }
        public string senha{ get; set; }
        public string telefone{ get; set; }
        public string? rua{ get; set; } 
        public string numero{ get; set; }
        public string? complemento{ get; set; }
        public string cep{ get; set; }

        public bool adm{ get; set; }

    }
}
