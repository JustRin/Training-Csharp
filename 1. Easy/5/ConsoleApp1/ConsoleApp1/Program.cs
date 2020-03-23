using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre Z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vector Length:" + Math.Sqrt(x * x + y * y + z * z));
        }
    }
}
