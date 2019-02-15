
namespace ExerciciosMembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double iof = 0.06;
        
        public static double converteDolar(double ctDolar, double qtdDolar)
        {
            double total = ctDolar * qtdDolar;
            return total +=  (ctDolar * qtdDolar) * iof; 
        }
    }
}
