using System;
using System.Globalization;

namespace Funcionario_Exerciocio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine( "\nFuncionário" + funcionario.ToString());

            Console.Write("\nDigite a porcentagem para aumentar o salario: ");
            funcionario.AumentoSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nDados atualizados: " + funcionario.ToString());

        }
    }
}
