using System;
using System.Globalization;
using System.Reflection.Emit;

namespace Exercise05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the code piece 1:");
            int piece1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the quantity of piece 1:");
            int qty1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of each piece 1:");
            double unitPrice1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the code piece 2:");
            int piece2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the quantity of piece 2:");
            int qty2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of each piece 2:");
            double unitPrice2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = qty1 * unitPrice1 + qty2 * unitPrice2;
            Console.WriteLine("Total to be paid: U$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}