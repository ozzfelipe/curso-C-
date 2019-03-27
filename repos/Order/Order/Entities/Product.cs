using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Preco { get; set; }

        public Product(string name, double preco)
        {
            Name = name;
            Preco = preco;
        }
    }
}
