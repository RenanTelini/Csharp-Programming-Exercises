using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the code for your favorite fuel type:");
            int fuel = int.Parse(Console.ReadLine());

            int ethanol = 0;
            int gasoline = 0;
            int diesel = 0;

            while(fuel != 4)
            {
                if (fuel == 1)
                    ethanol =+ 1;
                else if (fuel == 2)
                    gasoline =+ 1;
                else if (fuel == 3)
                    diesel =+ 1;

                Console.WriteLine("Enter another code:");
                fuel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thank you very much!");
            Console.WriteLine("Ethanol: {0}", ethanol);
            Console.WriteLine("Gasoline: {0}", gasoline);
            Console.WriteLine("Diesel: {0}", diesel);
        }
    }
}