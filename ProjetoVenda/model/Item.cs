using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.model
{
    internal class Item
    {
        public int id_item { get; set; }
        public int id_produto { get; set; }
        public int quantidade { get; set; }
        public int preco { get; set; }
        public string nome { get; set; }

        public string marca { get; set; }

        public decimal valorReal => this.preco / 100m;

        public decimal subTotal => (this.valorReal * this.quantidade);
    }
}
