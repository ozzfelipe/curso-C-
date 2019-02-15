using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Funcionario_Exerciocio2
{
    class Funcionario
    {
        public string Nome;
        public double Salario, Imposto;

        public double SalarioLiquido()
        {
            double salario = Salario -= Imposto;
            return salario;
        }

        public void AumentoSalario(double porcentagem)
        {
            double aumento = Salario * (porcentagem / 100);
        }

        public override string ToString()
            
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
