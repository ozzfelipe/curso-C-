using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CalculoImpostoExerciciosClassesAbstratas.Entities
{
    class Company : Payers
    {

        public int Employees { get; set; }
        double total;

        public Company(string name, double anualIncome, int employees) : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double calculatorTaxes()
        {

            if (Employees > 10)
            {
                total = (Anualncome * 0.14);
            }
            else
            {
                total = (Anualncome * 0.16);
            }

            return total;
        }

        public override string ToString()
        {
            return Name + ": $ " + total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
