using System;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer:");
            int n = int.Parse(Console.ReadLine());

            int square, cube;
            for (int i = 1; i <= n; i++)
            {
                square = i * i;
                cube = i * i * i;
                Console.WriteLine("{0} {1} {2}", i, square, cube);
            }
        }
    }
}