using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter quantity 'X': ");
            int x = Convert.ToInt32(Console.ReadLine()); // number of x

            double[] Z = new double[x];
            double[] B = new double[x];
            double[] A = new double[x];
            double[] Betta = new double[x];
            double[] summX = new double[x];
            double summ = 0;

            for(int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter Z, B, A, Betta for X" + (i + 1));
                Console.Write("Z = ");
                Z[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("B = ");
                B[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("A = ");
                A[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Betta = ");
                Betta[i] = Convert.ToDouble(Console.ReadLine());

                summX[i] = Math.Pow(Z[i], 3) - B[i] + Math.Pow(A[i], 2) / Math.Pow(Math.Tan(Betta[i]), 2); // x's formula
                summ += summX[i]; // sum the x
            }

            Console.WriteLine("Y = " + summ); //Answer
        }
    }
}
