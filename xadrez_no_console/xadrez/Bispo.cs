using tabuleiro;

namespace xadrez
{
    internal class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override bool[,] movPossiveis()
        {
            throw new TabException("Bisp Error");
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
