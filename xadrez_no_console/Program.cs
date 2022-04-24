using System;
using tabuleiro;
using xadrez;
namespace xadrez_no_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.PutPecas(new Torre(tab, Cor.Branca), new Posicao(0, 0));
            tab.PutPecas(new Rei(tab, Cor.Preto), new Posicao(0, 1));
            Screen.PrinTab(tab);
            string stop = Console.ReadLine();
        }
    }
}
