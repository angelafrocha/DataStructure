namespace Exercise2Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numerical expretion to check balance");
            string expression = Console.ReadLine();

            Console.WriteLine("The expression is " + Exercise2.BalancedExpression(expression));
        }
    }
}
