using System;

namespace Excersie02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer number:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Even number!");
            }
            else
            {
                Console.WriteLine("Odd number!");
            }
        }
    }
}