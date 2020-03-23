using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select the action on Array (1 sum, 2 subtraction, 3 multiplication):");
            Matrix matrix = new Matrix();
            int sign = Convert.ToInt32(Console.ReadLine());
            matrix.run(sign);
        }
    }

    class Matrix
    {
        string[] mass1;
        string[] mass2;
        public void read_matrix_from_file()
        {
            mass1 = File.ReadAllLines("1.txt");
            mass2 = File.ReadAllLines("2.txt");
        }
        public void summ_matrix()
        {
            read_matrix_from_file();
            Console.Write("Enter size array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[n, n];
            int[,] matrix2 = new int[n, n];
            int[,] matrix12 = new int[n, n];
            for (int p = 0; p < n; p++)
            {
                int[] m1 = mass1[p].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
                int[] m2 = mass2[p].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
                for (int i = 0; i < n; i++)
                {
                    matrix1[p, i] = m1[i];
                    matrix2[p, i] = m2[i];
                }
            }
            Console.WriteLine("Matrix 1: ");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Matrix 2: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Matrix 1 + Matrix 2: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix12[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix12[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        public void subtraction_matrix()
        {
            read_matrix_from_file();
            Console.Write("Enter size array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[n, n];
            int[,] matrix2 = new int[n, n];
            int[,] matrix12 = new int[n, n];
            for (int p = 0; p < n; p++)
            {
                int[] m1 = mass1[p].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
                int[] m2 = mass2[p].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
                for (int i = 0; i < n; i++)
                {
                    matrix1[p, i] = m1[i];
                    matrix2[p, i] = m2[i];
                }
            }
            Console.WriteLine("Matrix 1: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Matrix 2: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Matrix 1 - Matrix 2: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix12[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix12[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        public void multiplication_matrix()
        {
            read_matrix_from_file();
            Console.Write("Enter size array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[n, n];
            int[,] matrix2 = new int[n, n];
            int[,] matrix12 = new int[n, n];
            for (int p = 0; p < n; p++)
            {
                int[] m1 = mass1[p].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
                int[] m2 = mass2[p].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
                for (int i = 0; i < n; i++)
                {
                    matrix1[p, i] = m1[i];
                    matrix2[p, i] = m2[i];
                }
            }
            Console.WriteLine("Matrix 1: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Matrix 2: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Matrix 1 * Matrix 2: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        matrix12[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix12[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        public void run(int sign)
        {
            switch (sign)
            {
                case 1:
                    {
                        summ_matrix();
                        break;
                    }
                case 2:
                    {
                        subtraction_matrix();
                        break;
                    }
                case 3: 
                    {
                        multiplication_matrix();
                        break; 
                    }
                default: break;
            }
        }
    }
}
