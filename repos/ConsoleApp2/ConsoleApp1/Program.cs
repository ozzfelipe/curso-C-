using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            retangulo.LARGURA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.ALTURA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine( retangulo.ToString());

        }
    }
}
