using tabuleiro;

namespace xadrez
{
    internal class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override bool[,] movPossiveis()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "C";
        }
    }
}
