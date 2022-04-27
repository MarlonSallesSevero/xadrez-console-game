using tabuleiro;

namespace xadrez
{
    internal class Rainha : Peca
    {
        public Rainha(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override bool[,] movPossiveis()
        {
            throw new TabException("Peça Invalida");
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
