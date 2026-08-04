using System;
using System.Globalization;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value:");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (value >= 0 && value <= 25)
            {
                Console.WriteLine("Range (0, 25)");
            }
            else if (value > 25 && value <= 50)
            {
                Console.WriteLine("Range (25, 50)");
            }
            else if (value > 50 && value <= 75)
            {
                Console.WriteLine("Range (50, 75)");
            }
            else if (value > 75 && value <= 100)
            {
                Console.WriteLine("Range (75, 100)");
            }
            else
            {
                Console.WriteLine("Number out of range");
            }
        }
    }
}