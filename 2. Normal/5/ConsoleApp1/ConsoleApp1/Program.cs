using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int k = Convert.ToInt32(Console.ReadLine());
            avg(k);
            
        }

        static void avg(int k)
        {
            int[] mas = new int[k];
            Random rnd = new Random();
            int mas_summ = 0;
            Console.WriteLine("Array: ");
            for (int i = 0; i < k; i++)
            {
                mas[i] = rnd.Next(0, 100);
                mas_summ += mas[i];
                Console.Write(mas[i] + " ");
            }
            double summ = mas_summ / k;
            print(summ);
        }

        static void print(double summ)
        {
            Console.WriteLine("\nAverage arithmetic value: " + summ);
        }
    }
}
