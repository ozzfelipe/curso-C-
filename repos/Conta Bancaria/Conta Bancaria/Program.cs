using System;
using System.Globalization;

namespace Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldoConta;
            ContaBancaria contaBancaria;


            Console.Write("Entre com o número da conta: ");
            int nrConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o tirular da conta: ");
            string nTitular = Console.ReadLine();
            char depositoInicial = DepositoInicial();

            if (depositoInicial == 's' || depositoInicial == 'S')
            {
                Console.Write("Entre com o valor do deposito Inicial: ");
                saldoConta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(nrConta, nTitular, saldoConta);
            }
            else
            {
                contaBancaria = new ContaBancaria(nrConta, nTitular);
            }
            Console.Write("\nDados da conta:\n" + contaBancaria.ToString(), CultureInfo.InvariantCulture);

            Console.Write("\nEntre com um valor para déposito: ");

            contaBancaria.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.Write("Dados da conta atualizados:\n" + contaBancaria.ToString(), CultureInfo.InvariantCulture);

            Console.Write("\nEntre com um valor para saque: ");

            contaBancaria.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.Write("Dados da conta atualizados:\n" + contaBancaria.ToString(), CultureInfo.InvariantCulture + "\n");

        }


        public static char DepositoInicial()
        {
            char deposito;
            Console.Write("Havera deposito inicial (s/n)? ");
            deposito = char.Parse(Console.ReadLine());

            while (deposito != 's' && deposito != 'n' && deposito != 'S' && deposito != 'N')
            {

                Console.Write("Digite somente 's' ou 'n': ");
                deposito = char.Parse(Console.ReadLine());

            }

            return deposito;

        }

    }
}

