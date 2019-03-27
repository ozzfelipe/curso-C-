using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Order.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Preco { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double preco, Product prod)
        {
            Quantity = quantity;
            Preco = preco;
            Product = prod;
        }

        public double subTotal()
        {
            double total = Quantity * Preco;
            return total;
        }

        public override string ToString()
        {
            return Product.Name + ", "
                + " $" + Product.Preco
                + " Quantity: " + Quantity + ", "
                + "Subtotal: " + "$" + subTotal();
        }

    }
}
