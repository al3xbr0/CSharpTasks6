using System;
using System.Collections.Generic;

namespace BinCalc
{
    class Calculator
    {
        private string task;
        private readonly string expression;

        public Calculator(String task)
        {
            this.task = task;
            expression = GetExpr();
        }

        public string Result()
        {
            Stack<int> temp = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]))
                {
                    string a = "";

                    while (expression[i] != ' ' && !IsOperator(expression[i]))
                    {
                        a += expression[i];
                        i++;
                        if (i == expression.Length) break;
                    }
                    temp.Push(int.Parse(a));
                    i--;
                }
                else if (IsOperator(expression[i]))
                {
                    int a = temp.Pop();
                    int b = temp.Pop();

                    int result = expression[i] switch
                    {
                        '+' => b + a,
                        '-' => b - a,
                        '*' => b * a,
                        '/' => b / a,
                        _ => throw new NotImplementedException(),
                    };
                    temp.Push(result);
                }
            }
            return ToBinary(temp.Peek());
        }

        private string GetExpr()
        {
            string expr = "";
            Stack<char> stack = new Stack<char>();

            string res = "";
            int start = 0;

            if (task[0] == '-')
            {
                for (int j = 1; j < task.Length; j++)
                {
                    if (IsOperator(task[j]))
                    {
                        string tmp = task.Substring(0, j);
                        res += "0" + tmp;
                        start = j;
                        break;
                    }
                    if (j == task.Length - 1)
                    {
                        string tmp = task;
                        res += "(0" + tmp + ")";
                    }
                }
            }

            for (int i = start; i < task.Length; i++)
            {
                if (task[i] == '-' && task[i - 1] != ')' && IsOperator(task[i - 1]))
                {
                    for (int j = i + 1; j < task.Length; j++)
                    {
                        if (IsOperator(task[j]))
                        {
                            string tmp = task[i..j];
                            res += "0" + tmp + ")";
                            i = j;
                            break;
                        }
                        if (j == task.Length - 1)
                        {
                            var tmp = task.Substring(i);
                            res += "0" + tmp + ")";
                            i = j;
                        }
                    }
                }
                else
                    res += task[i];
            }
            task = res;

            string tempBin = "";
            for (int i = 0; i < task.Length; i++)
            {
                if (char.IsDigit(task[i]))
                {
                    while (!IsOperator(task[i]))
                    {
                        tempBin += task[i];
                        i++;
                        if (i == task.Length)
                        {
                            break;
                        }
                    }
                    expr += FromBinary(tempBin);
                    tempBin = "";

                    expr += " ";
                    i--;
                }

                if (IsOperator(task[i]))
                {
                    if (task[i] == '(')
                    {
                        stack.Push(task[i]);
                    }
                    else if (task[i] == ')')
                    {
                        char s = stack.Pop();
                        while (s != '(')
                        {
                            expr += s.ToString() + ' ';
                            s = stack.Pop();
                        }
                    }
                    else
                    {
                        if (stack.Count > 0)
                        {
                            if (GetPriority(task[i]) <= GetPriority(stack.Peek()))
                            {
                                expr += stack.Pop() + " ";
                            }
                        }
                        stack.Push(char.Parse(task[i].ToString()));
                    }
                }
            }

            while (stack.Count > 0)
            {
                expr += stack.Pop() + " ";
            }
            return expr;
        }

        private static bool IsOperator(char sym)
        {
            return GetPriority(sym) != 6;
        }

        private static int GetPriority(char sym)
        {
            return sym switch
            {
                '(' => 1,
                ')' => 2,
                '+' => 3,
                '-' => 4,
                '*' => 5,
                '/' => 5,
                _ => 6,
            };
        }

        private static int FromBinary(string bin)
        {
            return Convert.ToInt32(bin, 2);
        }

        private static string ToBinary(int dec)
        {
            return Convert.ToString(dec, 2);
        }
    }
}