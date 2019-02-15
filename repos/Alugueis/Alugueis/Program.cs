using System;
using System.Globalization;

namespace Alugueis
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] alugueis = new Quartos[10];

            Console.Write("How many rooms will be rentend? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("\nRent #" + i + ": ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                alugueis[room] = new Quartos { Name = name, Email = email, Room = room };
            }

            Console.WriteLine("\nBusy rooms:");
            
            for (int i = 0; i < alugueis.Length; i++)
            {
                if (alugueis[i] != null)
                {
                    Console.WriteLine( alugueis[i].Room + ": " 
                        + alugueis[i].Name + ", " 
                        + alugueis[i].Email);
                }
            }

        }
    }
}
