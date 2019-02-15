using System;
using System.Globalization;

namespace NotasDeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.NOME = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.CalculaNotaFinal();
            aluno.VerificaNotaAluno(aluno.NOTA_FINAL);

            Console.WriteLine(aluno.ToString());
        }
    }
}
