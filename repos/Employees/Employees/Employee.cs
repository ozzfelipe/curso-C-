using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Employees
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; set; }

        public Employee(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void increaseSalary(double percentage)
        {
            Salario += Salario * percentage;
        }

        public override string ToString()
        {
            return Id + ", "
                    + Name + ", "
                    + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
