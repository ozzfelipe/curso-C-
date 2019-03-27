using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CalculoImpostoExerciciosClassesAbstratas.Entities
{
    class Individual : Payers
    {

        public double HealthExpenditures { get; set; }
        double total;

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double calculatorTaxes()
        {
            
            if (Anualncome < 20000.00)
            {
                total = (Anualncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                total = (Anualncome * 0.25) - (HealthExpenditures * 0.5);
            }

            return total;
        }

        public override string ToString()
        {
            return Name + ": $ " + total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
