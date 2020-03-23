using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int select = -1;
            Prism prism = new Prism();
            while (select != 0) {

                Console.WriteLine("Make a choice:");
                Console.Write("0-Exit; 1 - Show prism height; 2 - Show the number of side faces; 3 - Show squar grounds; 4 - Show side length; 5 - Show Prism volume; 6 - Set prism height; 7 - Set the length of the sides of the prism; 8 - Set the number of prism faces; 9 - Set square grounds" + "\n>>");
                select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        {
                            prism.show_prism_height();
                            break;
                        }
                    case 2:
                        {
                            prism.number_of_side_faces();
                            break;
                        }
                    case 3:
                        {
                            prism.show_squar_grounds();
                            break;
                        }
                    case 4:
                        {
                            prism.show_side_length();
                            break;
                        }
                    case 5:
                        {
                            prism.show_prism_volume();
                            break;
                        }
                    case 6:
                        {
                            prism.set_prism_height();
                            break;
                        }
                    case 7:
                        {
                            prism.set_side_length();
                            break;
                        }
                    case 8:
                        {
                            prism.set_number_of_side_faces();
                            break;
                        }
                    case 9:
                        {
                            prism.set_square_grounds();
                            break;
                        }
                    default: break;
                } 
            }
        }
    }
    class Prism
    {
        public double height = 1.1;
        public int number_side_faces = 4;
        public double squar_grounds = 10.1;
        public double side_length = 1.6;
        public void show_prism_height()
        {
            Console.WriteLine("Height = " + height);
        }
        public void show_prism_volume()
        {
            Console.WriteLine("Prism volume = " + height * squar_grounds);
        }
        public void number_of_side_faces()
        {
            Console.WriteLine("Mumber of side faces = " + number_side_faces);
        }
        public void show_squar_grounds()
        {
            Console.WriteLine("Squar grounds = " + squar_grounds);
        }
        public void show_side_length()
        {
            Console.WriteLine("Side length = " + side_length);
        }
        public void set_number_of_side_faces()
        {
            Console.Write("Set number of side faces: ");
            number_side_faces = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Successful change!\n");
        }
        public void set_side_length()
        {
            Console.Write("Set side length: ");
            side_length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Successful change!\n");
        }
        public void set_prism_height()
        {
            Console.Write("Set prism height: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Successful change!\n");
        }
        public void set_square_grounds()
        {
            Console.Write("Set square grounds: ");
            squar_grounds = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Successful change!\n");
        }
    }
}
