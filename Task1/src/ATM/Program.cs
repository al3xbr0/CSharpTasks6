using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of money\nto exchange: ");
            string sum = Console.ReadLine();
            Console.WriteLine("\nValues of coins\n(space-separated): ");
            string[] vals = Console.ReadLine().Split(' ');
            Console.WriteLine();

            ATM task = new ATM(sum, vals);
            task.Solve(true);
        }
    }
}