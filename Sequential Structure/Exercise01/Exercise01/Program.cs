using System;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entry a integer number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Entry another integer number:");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("Sum results: " + c);
        }
    }
}