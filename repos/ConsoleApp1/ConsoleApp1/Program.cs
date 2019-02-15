using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int y = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double w = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            char z = char.Parse(Console.ReadLine());

            Console.WriteLine(x + " " + y + " " + w + " " + z);
            Console.ReadLine();

            
            string[] vet = Console.ReadLine().Split(' ');
            x = vet[0];
            y = int.Parse(vet[1]);
            w = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(w);

            Console.ReadLine();
        }
    }
}
