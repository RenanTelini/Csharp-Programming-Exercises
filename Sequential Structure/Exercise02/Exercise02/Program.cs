using System;
using System.Globalization;

namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for the radius of a circle:");
            double area, pi, radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pi = 3.14159;
            area = pi * radius * radius;

            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}