using System;
using System.Globalization;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times do you want to calculate a division?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a pair of numbers for the calculation:");
                string[] pair = Console.ReadLine().Split(' ');

                double a = double.Parse(pair[0], CultureInfo.InvariantCulture);
                double b = double.Parse(pair[1], CultureInfo.InvariantCulture);

                if (b == 0 && b < 1)
                {
                    Console.WriteLine("Result: Impossible to calculate!");
                }
                else
                {
                    double c = a / b;
                    Console.WriteLine("Result: {0}", c.ToString("F1", CultureInfo.InvariantCulture));
                }
                
            }
        }
    }
}