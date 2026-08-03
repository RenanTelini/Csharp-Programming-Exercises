using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number for 'A':");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an integer number for 'B':");
            int b = int.Parse(Console.ReadLine());

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("They are multiples!");
            }
            else
            {
                Console.WriteLine("They are not multiples!");
            }
        }
    }
}