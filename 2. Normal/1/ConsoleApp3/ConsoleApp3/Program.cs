using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введитее директорию для проверки файла!");
            string link = Console.ReadLine();
            Dir dir = new Dir(link);
        }
    }

    public class Dir
    {
        public string link;
        public Dir(string link)
        {
            StreamReader sr = File.OpenText(link);
            int left = 0;
            int right = 0;
            while (!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                if (c.ToString() == "{") left++;
                else if(c.ToString() == "}") right++;
            }

            if (left == right) Console.WriteLine("Баланс {} не нарушен!");
            else Console.WriteLine("Баланс {} нарушен!");
            Console.WriteLine("Кол-во { = " + left + "\nКол - во { = " + right);
        }
    }
}
