namespace Exercise2Stack
{
    internal class Exercise2
    {
        public static string BalancedExpression(string expression)
        {
            // Essa primeira pilha é dispensável. Você pode iterar direto na expression
            // Stack<char> stackExpression = new Stack<char>(expression);
            Stack<char> stackAux = new Stack<char>();
            var pairs = new Dictionary<char, char>() {
                { '{','}' },
                { '(',')' },
                { '[',']' }
            };

            foreach (char c in expression)
            {
                if (c == '{' || c == '[' || c == '(')  
                {
                    stackAux.Push(c);
                }
                else if (c == '}' || c == ']' || c == ')')
                {
                    if (stackAux.Count == 0)
                        return "Unbalanced!";

                    var expectedPair = pairs[stackAux.Pop()];

                    if (expectedPair != c)
                        return "Unbalanced!";
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
