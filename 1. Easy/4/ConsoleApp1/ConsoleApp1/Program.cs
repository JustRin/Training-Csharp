using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a three-digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number <= 99)
            {
                Console.WriteLine("Nubmer <= 99");
            }
            else if(number >= 1000)
            {
                Console.WriteLine("Number >= 1000");
            }
            else
            {
                if (((number / 100) % 10) == ((number / 10) % 10) || ((number / 10) % 10) == (number % 10) || ((number / 100) % 10) == (number % 10))
                {
                    Console.WriteLine("Among the digits of the entered three-digit number " + number + ", there are identical");
                }
                else
                {
                    Console.WriteLine("There are no identical figures.");
                }
            }
        }
    }
}
