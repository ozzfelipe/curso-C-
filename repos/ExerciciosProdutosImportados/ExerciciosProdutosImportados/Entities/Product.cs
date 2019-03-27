using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciciosProdutosImportados.Entities
{
    class Product
    {

        public String Name { get; set; }
        public double Preco { get; set; }

        public void product()
        {

        }

        public Product(string name, double preco)
        {
            Name = name;
            Preco = preco;
        }

        public virtual string priceTag()
        {
            return Name + " $ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
