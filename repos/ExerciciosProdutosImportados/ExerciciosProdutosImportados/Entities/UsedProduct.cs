using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciciosProdutosImportados.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct(string name, double preco, DateTime manufacturedDate) : base(name, preco)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string priceTag()
        {
            return Name + " (used) " + "$ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) + $" (Manufactured date: {DateTime.Parse( ManufacturedDate.ToString("dd/MM/yyyy") )}";
        }
    }
}
