using System;
using System.Globalization;

namespace Exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the employee number:");
            int employeeID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of hours worked:");
            int hoursWorked = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hourly rate:");
            double hourlyRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = hoursWorked * hourlyRate;

            Console.WriteLine("Number = {0}", employeeID);
            Console.WriteLine("Salary = U$ {0}", salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}