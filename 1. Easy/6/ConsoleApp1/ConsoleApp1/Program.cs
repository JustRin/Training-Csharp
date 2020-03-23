using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sequence of digits: ");
            string s = Console.ReadLine();
            char[] mas = new char[s.Length];
            for (int i = 0; i < s.Length; i++) mas[i] = s[i];
            Console.Write("Enter the digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number> s.Length) Console.WriteLine("Incorrect entry of  number");
            else Console.WriteLine("kth digit of the sequence:" + mas[number - 1]);
        }
    }
}
