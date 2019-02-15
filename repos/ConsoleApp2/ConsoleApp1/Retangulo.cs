using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Retangulo
    {
        public double LARGURA, ALTURA;

        public double AreaRetangulo()
        {
            double area = LARGURA * ALTURA;
            return area;
        }

        public double PerimetroRetangulo()
        {
            double perimetro = (LARGURA + ALTURA) * 2;
            return perimetro;
        }

        public double DiagonalRetangulo()
        {
            double diagonal = Math.Sqrt(Math.Pow(LARGURA, 2) + Math.Pow(ALTURA, 2));
            return diagonal;
        }



        public override string ToString()
        {
            return "AREA: " + AreaRetangulo().ToString("F2", CultureInfo.InvariantCulture) +
                "\nPERIMETRO: " + PerimetroRetangulo().ToString("F2", CultureInfo.InvariantCulture) +
                "\nDIAGONAL: " + DiagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture)
                ;
        }

    }
}
