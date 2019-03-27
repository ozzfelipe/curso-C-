using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciciosProdutosImportados.Entities
{
    class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }


        public ImportedProduct(string name, double preco, double customsFee) : base(name, preco)
        {
            CustomsFee = customsFee;
        }

        public double totalPrice()
        {
            return Preco + CustomsFee;
        }

        public override string priceTag()
        {
            return Name + " $ " + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + $" (Custums fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})" ;
        }
    }
}
