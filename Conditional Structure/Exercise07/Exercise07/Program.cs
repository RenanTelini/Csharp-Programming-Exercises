using System;
using System.Globalization;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an value to 'x':");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter an value to 'y':");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origen");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Y-Axis");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("X-Axis");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}