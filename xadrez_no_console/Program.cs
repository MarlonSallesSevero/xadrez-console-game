using System;
using tabuleiro;
using xadrez;
namespace xadrez_no_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PartidaXadrez partida = new PartidaXadrez();
            while (!partida.finished)
            {
                try
                {
                    Console.Clear();
                    Screen.PrinTab(partida.tab);
                    Console.WriteLine();
                    Console.WriteLine($"Turno : {partida.turno}");
                    Console.WriteLine($"Aguardando Jogada : {partida.atualPlayer}");
                    Console.WriteLine();
                    
                    Console.Write("Origin: ");
                    Posicao orig = Screen.ReadPosicao().ToPosicao();
                    partida.ValidarPosOrigem(orig); 
                    bool[,] posPossiveis = partida.tab.peca(orig).movPossiveis();
                    
                    Console.Clear();
                    Screen.PrinTabPossiveis(partida.tab, posPossiveis);
                    
                    Console.Write("Destiny: ");
                    Posicao destiny = Screen.ReadPosicao().ToPosicao();
                    partida.ValidaPosDestino(orig, destiny); 
                    partida.ExeMov(orig, destiny);
                }catch (TabException ex)
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
}
 