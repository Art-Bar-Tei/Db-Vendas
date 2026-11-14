using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.model
{
    internal class Venda
    {
        public int id_venda { get; set; }
        public int id_funcionario { get; set; }
        public DateTime date { get; set; }

        public List<Item> itens { get; set; }
        public string nome_funcionario { get; set; }
    }
}
