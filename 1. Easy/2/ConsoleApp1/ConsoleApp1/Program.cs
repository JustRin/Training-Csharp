using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number no greater than 99: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number < 10)
            {
                Console.WriteLine("Number less than 10");
            }else if(number >= 100)
            {
                Console.WriteLine("Number greater than 99");
            }
            else
            {
                if((number / 10) > (number % 10))
                {
                    Console.WriteLine(number / 10 + " - larger number");
                    Console.WriteLine(number % 10 + " - lower number");
                }
                else
                {
                    Console.WriteLine(number / 10 + " - lower number");
                    Console.WriteLine(number % 10 + " - larger number");
                }
            }
                

        }
    }
}
