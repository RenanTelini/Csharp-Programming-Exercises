using System;
using System.Diagnostics.Metrics;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to enter?:");
            int n = int.Parse(Console.ReadLine());

            int inCounter = 0;
            int outCounter = 0;
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter an integer number:");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                    inCounter++;
                else
                    outCounter++;
            }

            Console.WriteLine("{0} in", inCounter);
            Console.WriteLine("{0} out", outCounter);
        }
    }
}