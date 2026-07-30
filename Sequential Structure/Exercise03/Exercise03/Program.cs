using System;

namespace Exercise03
{
    internal class Exercise03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value to 'A':");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an integer value to 'B':");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an integer value to 'C':");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an integer value to 'D':");
            int d = int.Parse(Console.ReadLine());

            int difference = a * b - c * d;

            Console.WriteLine("Difference: {0}", difference);
        }
    }
}