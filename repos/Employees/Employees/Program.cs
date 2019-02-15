using System;
using System.Collections.Generic;
using System.Globalization;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();


            Console.Write("How many employees will be registred? ");
            int n = int.Parse(Console.ReadLine());
            Employee[] employee = new Employee[n];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nEmployee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));

            }

            Console.Write("\nEnter the employee id that will have salary increase : ");
            int idBusca = int.Parse(Console.ReadLine());

            Console.Write("Enter de percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Employee id1 = list.Find(x => x.Id == idBusca);
            if (id1 != null)
            {
                id1.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdate list of emplyees:");

            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }

            



        }
    }
}
