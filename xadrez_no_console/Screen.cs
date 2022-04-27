using System;
using tabuleiro;
using xadrez;
namespace xadrez_no_console
{
    internal class Screen
    {
        public static void PrinTab(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    PrintPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void PrinTabPossiveis(Tabuleiro tab, bool[,] possPossiveis)
        {
            ConsoleColor backgroundOrig = Console.BackgroundColor;
            ConsoleColor backgroundNew = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (possPossiveis[i, j])
                    {
                        Console.BackgroundColor = backgroundNew;
                    }
                    else
                    {
                        Console.BackgroundColor = backgroundOrig;
                    }
                    PrintPeca(tab.peca(i, j));
                    Console.BackgroundColor = backgroundOrig;

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = backgroundOrig;
        }
        public static void PrintPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
        public static PosicaoXadrez ReadPosicao()
        {
            string s = Console.ReadLine();
            char chCollu = s[0];
            int intLine = int.Parse(s[1] + "");
            return new PosicaoXadrez(chCollu, intLine);
        }
    }
}
