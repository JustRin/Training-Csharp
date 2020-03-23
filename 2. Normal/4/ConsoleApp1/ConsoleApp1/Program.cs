using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabotnik rab = new Rabotnik();
            Console.WriteLine("Enter information about worker:");
            Console.Write("Name: ");
            rab.name = Console.ReadLine();
            Console.Write("Experience: ");
            rab.experience = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hourly wage: ");
            rab.hourly_wage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of hours worked: ");
            rab.hours_worked = Convert.ToDouble(Console.ReadLine());
            rab.GetInfo();
        }
    }

    class Rabotnik
    {
        public string name;
        public double experience;
        public double hourly_wage;
        public double hours_worked;
        public void GetInfo()
        {
            double salary = hourly_wage * hours_worked;
            double p = 0;
            if(experience >= 1 && experience < 3)
            {
                p = 0.03;
            }
            else if (experience >= 3 && experience < 5)
            {
                p = 0.08;
            }
            else if(experience >= 5)
            {
                p = 0.15;
            }
            else if (experience < 0)
            {
                p = 0;
            }
            double premy = salary * p;
            Console.WriteLine($"\n==============================\n\nName: {name}  \nExperience: {experience} \nHourly wage: {hourly_wage} \nNumber of hours worked: {hours_worked} \nSalary is: {salary} \nPremy is: {premy}");
        }

    }
}
