using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM
{
    public class ATM
    {
        private readonly int sum;
        private readonly List<int> values; //
        private readonly int valsNum;
        private int[] valsAmounts;
        private int count;

        private readonly string separator;
        public bool formattedOutput;

        public ATM(string sum, string[] vals)
        {
            values = new List<int>();

            try
            {
                this.sum = Convert.ToInt32(sum);
                if (this.sum <= 0)
                {
                    throw new ArgumentException("ERROR: Sum and Values must be positive!");
                }

                foreach (string val in vals)
                {
                    int v = Convert.ToInt32(val);
                    if (v <= 0)
                    {
                        throw new ArgumentException("ERROR: Sum and Values must be positive!");
                    }
                    if (!values.Contains(v))
                    {
                        values.Add(v);
                    }
                }

            }
            catch (FormatException)
            {
                throw new ArgumentException("ERROR: Invalid input!");
            }

            values.Sort();
            valsNum = values.Count;
            separator = $"+----------+{string.Concat(Enumerable.Repeat("----------+", valsNum))}\n";
        }

        public int Solve(bool formattedOutput)
        {
            count = 0;
            valsAmounts = new int[valsNum];

            this.formattedOutput = formattedOutput;
            
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
   