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
            
            tab.PutPecas(new Torre(tab, Cor.Azul), new Posicao(0,0));
            Screen.PrinTab(tab);

            string stop = Console.ReadLine();
        }
    }
}
