using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Conta_Bancaria
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }
        
        public ContaBancaria(int nrConta, string nTitular, double depositoInicial)
        {
            NumeroConta = nrConta;
            NomeTitular = nTitular;
            Deposito(depositoInicial);
        }

        public ContaBancaria(int nrConta, string nTitular)
        {
            NumeroConta = nrConta;
            NomeTitular = nTitular;
        }


        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor;
            Saldo -= 5.00;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta.ToString()
                + ", Titular: " + NomeTitular
                + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture) + "\n";
            
        }
    }
}
