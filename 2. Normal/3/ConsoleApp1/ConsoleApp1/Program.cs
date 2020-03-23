using Microsoft.VisualBasic;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ConstHours = 3600;
            int ConstMinuts = 60;
            Console.WriteLine("Enter metod (1 Time to sec) (2 sec to time)!");
            int metod = Convert.ToInt32(Console.ReadLine());
            switch (metod)
            {
                case 1:
                    {
                        Console.Write("Enter hours: ");
                        int hours = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter minuts: ");
                        int min = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter sec: ");
                        int sec = Convert.ToInt32(Console.ReadLine());
                        int time = sec + (min * ConstMinuts) + (hours * ConstHours);
                        Console.WriteLine("Time ->  " + time + " sec");
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter sec: ");
                        int sec = Convert.ToInt32(Console.ReadLine());
                        int hours = sec / ConstHours;
                        int min = (sec - (ConstHours * hours))/ ConstMinuts;
                        int second = (sec - (ConstHours * hours) - (min * ConstMinuts));
                        Console.WriteLine("Time -> " + hours + ":" + min + ":" + second);
                        break;
                    }
                default: break;
            }
        }
    }
}
