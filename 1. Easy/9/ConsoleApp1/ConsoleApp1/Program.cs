using System;
/*
     ******************************************    *****************
     *                side № 2                *    *    side № 1   *
     *                                        *    *               *
     ******************************************    *****************

     ******************************************
     *                                        *
     *                                        *
     *                side № 3                *
     *                                        *
     *                                        *
     ******************************************
*/

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length(a): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width(b): ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height(c): ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the oppenings(d): ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the oppenings(l): ");
            double l = Convert.ToDouble(Console.ReadLine());
            switch ((b <= d) && (c <= l) ? 1 : (a <= d) && (c <= l) ? 2 : (a <= d) && (b <= l) ? 3 : -1)
            {
                case 1:
                    {
                        Console.WriteLine("Brick went into the hole by the first party");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Brick went into the hole by the second party");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Brick went into the hole by a third party");
                        break;
                    }
                default: Console.WriteLine("Brick did not pass through the hole"); break;

            }
        }
    }
}
