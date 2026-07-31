using System;
using System.Globalization;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three decimal values for 'A', 'B' and 'C':");

            string[] values = (Console.ReadLine().Split(' '));
            float a = float.Parse(values[0], CultureInfo.InvariantCulture);
            float b = float.Parse(values[1], CultureInfo.InvariantCulture);
            float c = float.Parse(values[2], CultureInfo.InvariantCulture);

            float area = (a * c) / 2;
            Console.WriteLine("Triangle: {0}", area.ToString("F3", CultureInfo.InvariantCulture));

            float pi = 3.14159f;
            area = pi * (c * c);
            Console.WriteLine("Circle: {0}", area.ToString("F3", CultureInfo.InvariantCulture));

            area = (a + b) * c / 2;
            Console.WriteLine("Trapezoid: {0}", area.ToString("F3", CultureInfo.InvariantCulture));

            area = b * b;
            Console.WriteLine("Square: {0}", area.ToString("F3", CultureInfo.InvariantCulture));

            area = a * b;
            Console.WriteLine("Rectangle: {0}", area.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}