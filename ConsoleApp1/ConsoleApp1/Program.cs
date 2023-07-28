using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)


        {

            char[,] tabuleiro = new char[3, 3];
            char turno = 'X';


            int jogada = 0;
            bool fimDeJogo = false;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("--------- JOGO DA VELHA ---------");
            Console.WriteLine("---------------------------------");



            //Montar e imprimir o tabulereiro
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    tabuleiro[i, j] = '-';
                    Console.Write(tabuleiro[i, j] + "\t");
                }
                Console.WriteLine();
            }



            while (jogada < 9 && !fimDeJogo)
            {
                //Diagonal
                if ((tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2] && tabuleiro[0, 0] != '-') || (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0] && tabuleiro[0, 2] != '-'))
                {

                    Console.WriteLine($"-------------------------------------------");
                    Console.WriteLine($"FIM DE JOGO, o último jogador é vencedor !!");
                    Console.WriteLine($"-------------------------------------------");
                    break;
                }

                //Linha
                if ((tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 1] == tabuleiro[0, 2] && tabuleiro[0, 2] != '-') ||
                    (tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[1, 2] && tabuleiro[1, 2] != '-') ||
                    (tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 1] == tabuleiro[2, 2] && tabuleiro[2, 2] != '-'))
                {

                    Console.WriteLine($"-------------------------------------------");
                    Console.WriteLine($"FIM DE JOGO, o último jogador é vencedor !!");
                    Console.WriteLine($"-------------------------------------------");
                    break;
                }

                //Coluna
                if ((tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[1, 0] == tabuleiro[2, 0] && tabuleiro[2, 0] != '-') ||
                    (tabuleiro[0, 1] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 1] && tabuleiro[2, 1] != '-') ||
                    (tabuleiro[0, 2] == tabuleiro[1, 2] && tabuleiro[1, 2] == tabuleiro[2, 2] && tabuleiro[2, 2] != '-'))
                {

                    Console.WriteLine($"-------------------------------------------");
                    Console.WriteLine($"FIM DE JOGO, o último jogador é vencedor !!");
                    Console.WriteLine($"-------------------------------------------");
                    break;
                }






                int linha, coluna;

                Console.WriteLine($"Jogador, escolha linha de 1 a 3: ");
                linha = int.Parse(Console.ReadLine());

                Console.WriteLine($"Jogador, escolha coluna de 1 a 3: ");
                coluna = int.Parse(Console.ReadLine());

                Console.Clear();

                if (tabuleiro[linha - 1, coluna - 1] == '-')
                {
                    tabuleiro[linha - 1, coluna - 1] = turno;
                }
                else
                {
                    Console.WriteLine("Errooooou, já ta preenchido");
                }

                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                {
                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                    {
                        Console.Write($"{tabuleiro[i, j]} ");
                    }
                    Console.WriteLine();
                }



                if (turno == 'X')
                {
                    turno = 'O';
                }
                else
                {
                    turno = 'X';
                }




                jogada++;

            }




























        }
    }
}