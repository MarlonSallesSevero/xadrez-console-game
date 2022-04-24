using System;
using tabuleiro;

namespace xadrez_no_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);

            Screen.PrinTab(tab);
            Console.WriteLine();
            string a = Console.ReadLine();
        }
    }
}
