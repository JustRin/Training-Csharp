using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t Check if the number is an integer");
            Console.Write("Insert the number: ");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("This is an integer!");
            }
            catch
            {
                Console.WriteLine("Not a number, or a fractional number!");
            }
        }
    }
}
