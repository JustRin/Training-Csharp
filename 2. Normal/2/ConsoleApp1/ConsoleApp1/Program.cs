using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            List<int> mas_numbers = new List<int>();
            List<int> mas = new List<int>();
            Console.Write("\n Array numbers: ");
            for (int i = 0; i < size; i++)
            {
                mas_numbers.Add(rnd.Next(0, 100));
                if(mas_numbers[i]%2 != 0)
                {
                    if (mas_numbers[i] != 0)
                    {
                        mas.Add(mas_numbers[i]);
                    }
                }
                Console.Write(" " + mas_numbers[i]);
            }
            Console.Write("\n Odd numbers: ");
            for(int i = 0; i < mas.Count; i++)
            {
                
                Console.Write(" " + mas[i]);
            }

        }
    }
}
