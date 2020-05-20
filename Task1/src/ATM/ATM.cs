using System;
using System.Collections.Generic;
using System.Linq;

namespace ATM
{
    public class ATM
    {
        public const string ERROR_MESSAGE = "ERROR: All inputs must be positive and integer!";

        private int sum;
        private readonly List<int> values;

        public string Sum
        {
            set
            {
                try
                {
                    sum = Convert.ToInt32(value);
                }
                catch (FormatException)
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }
                if (sum <= 0)
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }
            }
        }
        public string[] Vals
        {
            set
            {
                try
                {
                    List<int> converted = Array.ConvertAll(value, Convert.ToInt32).ToList();
                    converted = converted.Distinct().ToList();
                    converted.ForEach(v => { if (v <= 0) throw new ArgumentException(ERROR_MESSAGE); });
                    values.AddRange(converted);
                }
                catch (FormatException)
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }
                values.Sort();
            }
        }

        private int valsNum;
        private int[] valsAmounts;
        private int count;

        private string separator;
        public bool formattedOutput;

        public ATM()
        {
            values = new List<int>();
        }

        public int Solve(bool formattedOutput)
        {
            valsNum = values.Count;
            separator = $"+----------+{string.Concat(Enumerable.Repeat("----------+", valsNum))}\n";
            this.formattedOutput = formattedOutput;
            count = 0;
            valsAmounts = new int[valsNum];

            if (formattedOutput)
            {
                Console.Write(separator);
                Console.Write("| number   |");
                for (int i = 0; i < valsNum; i++)
                {
                    Console.Write(" ${0,-7} |", values[i]);
                }
                Console.Write($"\n{separator}");
            }

            RecFind(0, sum);

            if (formattedOutput)
            {
                Console.Write($"{{0}}| {{1,8}} {{2,-{(11 * valsNum - 1)}}} |\n{{0}}",
                    separator, count, "combinations in total");
            }
            else
            {
                Console.Write(count + " combinations in total");
            }

            return count;
        }

        private void RecFind(int index, int sum)
        {
            if (index == valsNum)
            {
                count++;
                Print();
            }
            else
            {
                if (index == valsNum - 1)
                {
                    if (sum % values[index] == 0)
                    {
                        valsAmounts[index] = sum / values[index];
                        RecFind(index + 1, 0);
                    }
                }
                else
                {
                    for (int i = 0; i <= sum / values[index]; i++)
                    {
                        valsAmounts[index] = i;
                        RecFind(index + 1, sum - values[index] * i);
                    }
                }
            }
        }

        private void Print()
        {
            if (formattedOutput)
            {
                Console.Write("| {0,-8} |", count);
                for (int i = 0; i < valsNum; i++)
                {
                    Console.Write(" x{0,-7} |", valsAmounts[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < valsNum; i++)
                {
                    Console.Write(string.Concat(Enumerable.Repeat($"{values[i]} ", valsAmounts[i])));
                }
                Console.WriteLine();
            }
        }
    }
}