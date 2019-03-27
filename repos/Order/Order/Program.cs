using Order.Entities;
using Order.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Order
{
    class Program
    {

        public static DateTime moment { get; set; } = DateTime.Now;
        public static OrderStatus status { get; set; }
        public static Client client;
        public static List<OrderItem> items { get; set; } = new List<OrderItem>();


        static void Main(string[] args)
        {

            Console.WriteLine("Enter client Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: ");
            string birth = Console.ReadLine();

            client = new Client(name, email, birth);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("Hiw many items to this order? ");
            int quantityItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantityItems; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPreco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product prod = new Product(productName, productPreco);
                OrderItem orderItem = new OrderItem(productQuantity, productPreco, prod);
                addItem(orderItem);
            }

            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order Moment: " + moment);
            Console.WriteLine("Client: " + client);
            Console.WriteLine("Order Items:");
            foreach (OrderItem obj in items)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Total price: " + total(),"F2", CultureInfo.InvariantCulture);

        }


        public static void addItem(OrderItem item)
        {
            items.Add(item);
        }

        public static void removeItem(OrderItem item)
        {
            items.Remove(item);
        }

        public static double total()
        {
            double soma = 0;

            foreach (OrderItem obj in items)
            {
                soma += obj.subTotal();
            }
            return soma;
        }


    }
}