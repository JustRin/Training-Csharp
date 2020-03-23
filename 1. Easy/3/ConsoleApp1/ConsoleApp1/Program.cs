using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            double count;
            Console.Write("Enter number:");
            double numb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter power:");
            int pow = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < pow; i++)
            {
                if(number != 0)
                {
                    number *= numb;
                }
                else if(number == 0)
                {
                    number = numb * numb;
                }
            }
            Console.Write("number = " + number);
        }
    }
}
