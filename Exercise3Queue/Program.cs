namespace Exercise3Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de jogadores: ");
            int quant = int.Parse(Console.ReadLine());

            int ganhador = Exercise3.JogoBatataQuente(quant);

            Console.WriteLine($"\nO jogador {ganhador} GANHOU!");
        }
    }
}
