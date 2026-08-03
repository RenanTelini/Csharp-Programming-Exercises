using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer number:");
            int x = int.Parse(Console.ReadLine());

            if (x < 0)
            { 
                Console.WriteLine("Negative number!");
            }
            else
            { 
                Console.WriteLine("Positive number!");
            }
        }
    }
}