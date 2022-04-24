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
                PartidaXadrez partida = new PartidaXadrez();
                Screen.PrinTab(partida.tab);
                while (partida.finished != true)
                {
                    Console.Clear();
                    Screen.PrinTab(partida.tab);
                    Console.WriteLine();
                    Console.Write("Origin: ");
                    Posicao orig = Screen.ReadPosicao().ToPosicao();
                    Console.Write("Destiny: ");
                    Posicao destiny = Screen.ReadPosicao().ToPosicao();
                    partida.ExeMov(orig, destiny);
                }
                string stop = Console.ReadLine();
            }
            catch (TabException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                string a = Console.ReadLine();
            }
        }
    }
}
