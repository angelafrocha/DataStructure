using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Stack
{
    internal class Exercise2
    {
        public static string BalancedExpression(string expression)
        {
            Stack<char> stackExpression = new Stack<char>(expression);
            Stack<char> stackAux = new Stack<char>();

            foreach (char c in stackExpression)
            {
                if (c == '}' || c == ']' || c == ')')
                {
                    stackAux.Push(c);
                }
                else if (c == '{' || c == '[' || c == '(')
                {
                    if (stackAux.Count == 0)
                    {
                        stackAux.Push(c);
                    }
                    else
                    {
                        stackAux.Pop();
                    }

                }
            }

            if (stackAux.Count == 0)
            {
                return "Balanced!";
            }
            else
            {
                return "Unbalanced!";
            }
        }
    }
}
