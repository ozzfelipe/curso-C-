using System;
using System.Globalization;

namespace ExerciciosMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args) {


            double ctDolar, qtdDolar;

            Console.Write("Qual a cotação do dolar? ");
            ctDolar =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qauntos dólares você vai comprar? ");
            qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.converteDolar(ctDolar, qtdDolar).ToString("F2", CultureInfo.InvariantCulture));

        }
        } 
    }
