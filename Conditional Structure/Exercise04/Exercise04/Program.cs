using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the game's start time:");
            int startTime = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the game's end time:");
            int endTime = int.Parse(Console.ReadLine());

            int duration;

            if (endTime > startTime)
            {
                duration = endTime - startTime;
            }
            else
            {
                duration = 24 - startTime + endTime;
            }

            Console.WriteLine("The game lasted: {0} hour(s)", duration);
        }

    }
}