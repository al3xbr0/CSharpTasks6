using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM task = new ATM();

            try
            {
                Console.WriteLine("Sum of money\nto exchange: ");
                string sum = Console.ReadLine();
                task.Sum = sum;

                Console.WriteLine("\nValues of coins\n(space-separated): ");
                string[] vals = Console.ReadLine().Split(' ');
                task.Vals = vals;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"\n{e.Message}\nThe program will be terminated.");
                return;
            }

            Console.Write("\nWant to get solution\nas a formatted table? Y/N");
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            }
            while (key != ConsoleKey.Y && key != ConsoleKey.N);
            Console.Write("\n\n");

            task.Solve(key == ConsoleKey.Y);
        }
    }
}