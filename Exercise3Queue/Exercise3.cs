namespace Exercise3Queue
{
    internal class Exercise3
    {
        public static int JogoBatataQuente(int quantidadeJogadores)
        {
            Queue<int> filaJogadores = new Queue<int>(quantidadeJogadores);

            for (int i = 1; i <= quantidadeJogadores; i++)
            {
                filaJogadores.Enqueue(i);
            }

            while (filaJogadores.Count > 1)
            {
                // O ideal é que o número de passes seja diferente em cada rodada
                int passes = new Random().Next(1, 100);
                Console.WriteLine($"\nNumero de passes até a batata explodir: {passes}.\n");
                // A implementação anterior tinha um bug pois tentava buscar o jogador por um
                // índice que já não existia na fila, uma vez que o número  de passes estava sendo normalizado
                // no inicio odo método, as alterações na fila não estava sendo levadas em consideração
                // o único caso em que a lógica anterior funcionava sem exception era quando
                // passes % quantidadeJogadores == 1
                for (int i = 1; i < passes; i++)
                {
                    // O método dequeue já devolve a instância que você precisa, não devemos acessar elementos
                    // pelo índice em uma fila (a menos que você esteja mesmo implementando um método "FurarFila")
                    int jogadorAtual = filaJogadores.Dequeue();
                    filaJogadores.Enqueue(jogadorAtual);
                }

                Console.WriteLine($"O jogador {filaJogadores.ElementAt(0)} QUEIMOU!");
                filaJogadores.Dequeue();
            }

            return filaJogadores.Dequeue();
        }
    }
}
