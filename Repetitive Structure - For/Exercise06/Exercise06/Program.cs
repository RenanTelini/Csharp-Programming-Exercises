using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to calculate its divisors:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }
        }
    }
}