using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password:");
            int password = int.Parse(Console.ReadLine());

            while (password != 2002 )
            {
                Console.WriteLine("Incorrect password! Enter another password:");
                password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Access Granted!");
        }
    }
}