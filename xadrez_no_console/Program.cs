using System;
using tabuleiro;
using xadrez;
namespace xadrez_no_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.PutPecas(new Torre(tab, Cor.Azul), new Posicao(0, 0));
                tab.PutPecas(new Rei(tab, Cor.Azul), new Posicao(0, 10));

                Screen.PrinTab(tab);

                string a = Console.ReadLine();
            }
            catch(TabException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                string aa = Console.ReadLine();
            }
        }
    }
}
