using CalculoImpostoExerciciosClassesAbstratas.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalculoImpostoExerciciosClassesAbstratas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Payers> payers = new List<Payers>();

            Console.Write("Enter the number of the tax payers: ");
            int quantityPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantityPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char typePayer = char.Parse(Console.ReadLine());

                if (typePayer.Equals('i'))
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual incume: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double heathExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Individual individual = new Individual(name, anualIncome, heathExpeditures);

                    payers.Add(individual);
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual incume: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    Company company = new Company(name, anualIncome, employees);

                    payers.Add(company);
                }

            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double totalPaid = 0.00;

            foreach (Payers p in payers)
            {

                double total = p.calculatorTaxes();
                totalPaid = totalPaid +  total;

                Console.Write(p.writeTotal(total)); 
                
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + "$ " + totalPaid.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
