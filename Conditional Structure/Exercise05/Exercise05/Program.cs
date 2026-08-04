using System;
using System.Globalization;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the code of item:");
            int code = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the quantity of item:");
            int qty = int.Parse(Console.ReadLine());

            double total;
            if (code == 1)
            {
                total = qty * 4;
            }
            else if (code == 2)
            {
                total = qty * 4.5;
            } 
            else if (code == 3)
            {
                total = qty * 5;
            }
            else if (code == 4)
            {
                total = qty * 2;
            }
            else if (code == 5)
            {
                total = qty * 1.5;
            }
            else
            {
                total = 0;
            }

            Console.WriteLine("Total to be paid: U$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}