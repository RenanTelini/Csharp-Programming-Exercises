using System;
using System.Globalization;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to represent the number of test cases:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter three decimal numbers with one decimal place:");

                string[] numbers = Console.ReadLine().Split(' ');
                double a = double.Parse(numbers[0], CultureInfo.InvariantCulture);
                double b = double.Parse(numbers[1], CultureInfo.InvariantCulture);
                double c = double.Parse(numbers[2], CultureInfo.InvariantCulture);

                double avg = (a * 2 + b * 3 + c * 5) / 10;

                Console.WriteLine(avg.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}