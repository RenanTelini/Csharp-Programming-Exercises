using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value to 'x':");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value to 'y':");
            int y = int.Parse(Console.ReadLine());

            while(x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                    Console.WriteLine("First");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Second");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Third");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Fourth");

                Console.WriteLine("Enter a value to 'x':");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a value to 'y':");
                int b = int.Parse(Console.ReadLine());

                x = a;
                y = b;
            }
        }
    }
}