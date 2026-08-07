using System;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to calculate its factorial:");
            int n = int.Parse(Console.ReadLine());

            int result = 1;
            for(int i = 1; i <= n; i++)
                result = result * i;

            Console.WriteLine(result);
        }
    }
}