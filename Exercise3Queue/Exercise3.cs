using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Queue
{
    internal class Exercise3
    {
        public static int JogoBatataQuente(int quantidadeJogadores)
        {
            int passes = new Random().Next(1, 100);
            int passesNormalizados = passes % quantidadeJogadores;

            if (passesNormalizados == 0)
            {
                passesNormalizados = quantidadeJogadores;
            }

            Queue<int> filaJogadores = new Queue<int>(quantidadeJogadores);

            for (int i = 1; i <= quantidadeJogadores; i++)
            {
                filaJogadores.Enqueue(i);
            }

            Console.WriteLine($"\nNumero de passes: {passes}.\n");

            while (filaJogadores.Count > 1)
            {
                for (int i = 0; i < passesNormalizados - 1; i++)
                {
                    int jogadorAtual = filaJogadores.ElementAt(i);
                    filaJogadores.Dequeue();
                    filaJogadores.Enqueue(jogadorAtual);
                }

                Console.WriteLine($"O jogador {filaJogadores.ElementAt(0)} QUEIMOU!");
                filaJogadores.Dequeue();
            }

            return filaJogadores.ElementAt(0);
        }
    }
}
