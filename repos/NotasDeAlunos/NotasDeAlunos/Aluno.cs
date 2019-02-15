using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NotasDeAlunos
{
    class Aluno
    {
        public string NOME, RESULTADO;
        public double N1, N2, N3, NOTA_FINAL;

        public double CalculaNotaFinal()
        {

            NOTA_FINAL = N1 + N2 + N3;

            return NOTA_FINAL;
        }

        public string VerificaNotaAluno(double notaFinal)
        {
            double notaFaltante;
            if (notaFinal >= 60)
            {
                RESULTADO = "APROVADO";
            }
            else
            {
                notaFaltante = 60 - notaFinal;
                RESULTADO = "REPROVADO\n" + "FALTARAM " + notaFaltante.ToString("F2", CultureInfo.InvariantCulture);
            }
            return RESULTADO;
        }

        public override string ToString()
        {

            return "NOTA FINAL" + " = " + NOTA_FINAL.ToString("F2", CultureInfo.InvariantCulture) + "\n" + RESULTADO;
        }
    }
}
