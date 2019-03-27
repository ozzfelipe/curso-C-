using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CalculoImpostoExerciciosClassesAbstratas.Entities
{
    abstract class Payers
    {
        public String Name { get; set; }
        public double Anualncome { get; set; }

        protected Payers()
        {
        }

        public Payers(string name, double anualncome)
        {
            Name = name;
            Anualncome = anualncome;
        }

        public abstract double calculatorTaxes();

        public string writeTotal(double total)
        {

            return Name + ": $ " + total.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}
