using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            Console.WriteLine("1.) Free fall?");
            Console.WriteLine("answers:");
            Console.WriteLine("-> 9.8");
            Console.WriteLine("-> 10");
            Console.WriteLine("-> 1.1");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a.ToString() == "9.8" || a.ToString() == "1" || a.ToString() == "9,8")
            {
                count ++;
            }
            Console.WriteLine("Speed of light?");
            Console.WriteLine("answers:");
            Console.WriteLine("-> 300 000");
            Console.WriteLine("-> 1 264 684 235 898");
            Console.WriteLine("-> 3 258 145 962 125 934");
            string b = Console.ReadLine();
            if (b.ToString() == "300 000" || b.ToString() == "1" || b.ToString() == "300000")
            {
                count ++;
            }
            Console.WriteLine("Light year?");
            Console.WriteLine("answers:");
            Console.WriteLine("-> 1 year");
            Console.WriteLine("-> 2 year");
            Console.WriteLine("-> 0,5 year");
            string c = Console.ReadLine();
            if (c.ToString() == "1" || c.ToString() == "1" || c.ToString() == "1 year")
            {
                count ++;
            }

            switch (count)
            {
                case 1:
                    {
                        Console.WriteLine("0 balls"); 
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("2 balls"); 
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("4 balls"); 
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("5 balls"); 
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error"); 
                        break;
                    }
            }
        }
    }
}
