using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Enter the last number of the sequence: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int DefaulNumber = number;
            while (number >= 0)
            {
                if (number % 5 == 0)
                {
                    total += number;
                }
                number--;
            }
            Console.WriteLine("The sum of numbers divisible by 5 from the sequence [0, " + DefaulNumber + "] = " + total);
        }
    }
}
