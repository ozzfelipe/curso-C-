using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(" ");

            int[,] mat = new int[int.Parse(a[0]), int.Parse(a[1])];

            for (int i = 0; i < int.Parse(a[0]); i++)
            {
                string[] values = Console.ReadLine().Split(" ");

                for (int j = 0; j < int.Parse(a[1]); j++)
                {

                    mat[i, j] = int.Parse(values[j]);

                }

            }

            int number = int.Parse(Console.ReadLine());

            // retorna posição do numero escolhido
            for (int i = 0; i < int.Parse(a[0]); i++)
            {
                for (int j = 0; j < int.Parse(a[1]); j++)
                {
                    if (mat[i, j] == number)
                    {
                        Console.WriteLine("Position " + i + "," + j);

                        // Verifica numeros ao redor do numero escolhido
                        j--;
                        if (j >= 0)
                        {
                            Console.Write("Left: " + mat[i, j]);
                            Console.WriteLine();
                            j++;
                        }
                        else { j++; }
                        j++;
                        if ((j) < mat.GetLongLength(1))
                        {
                            Console.Write("Right: " + mat[i, j]);
                            Console.WriteLine();
                            j--;
                        }
                        else { j--; }
                        i--;
                        if (i >= 0)
                        {
                            Console.Write("Up: " + mat[i, j]);
                            Console.WriteLine();
                            i++;
                        }
                        else { i++; }
                        i++;
                        if ((i) < mat.GetLongLength(0))
                        {
                            Console.Write("Down: " + mat[i, j]);
                            Console.WriteLine();
                            i--;
                        }
                        else { i--; }


                    }
                }
            }


        }
    }
}
