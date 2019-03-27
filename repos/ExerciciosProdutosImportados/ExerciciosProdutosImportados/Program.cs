using ExerciciosProdutosImportados.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciciosProdutosImportados
{
    class Program
    {

        static void Main(string[] args)
        {
            
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int quantity =  int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());

                if (type == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product pCommon = new Product(name, price);

                    list.Add(pCommon);

                } else if (type == 'i'){
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Costums fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product pImported = new ImportedProduct(name, price, customsFee);

                    list.Add(pImported);
                } else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture   date (DD/MM/YYYY)? ");
                    DateTime manufacturedDate = DateTime.Parse(Console.ReadLine());

                    Product pUsed = new UsedProduct(name, price, manufacturedDate);

                    list.Add(pUsed);
                }

            }

            Console.WriteLine("PRICE TAGS:");

            foreach (Product p in list)
            {
                Console.WriteLine(p.priceTag());
            }
        }
    }
}
