using tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override bool[,] movPossiveis()
        {
            bool[,] aux = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            //validando mov acima
            pos.defineValues(pos.linha - 1, pos.coluna);
            if (tab.ValidaPos(pos) && podeMov(pos))
            {
                aux[pos.linha, pos.coluna] = true;
            }
            //validando mov nortedeste
            pos.defineValues(pos.linha - 1, pos.coluna + 1);
            if (tab.ValidaPos(pos) && podeMov(pos))
            {
                aux[pos.linha, pos.coluna] = true;
            }
            //validando mov direita
            pos.defineValues(pos.linha, pos.coluna + 1);
            if (tab.ValidaPos(pos) && podeMov(pos))
            {
                aux[pos.linha, pos.coluna] = true;
            }
            //validando mov sudeste
            pos.defineValues(pos.linha + 1, pos.coluna + 1);
            if (tab.ValidaPos(pos) && podeMov(pos))
            {
                aux[pos.linha, pos.coluna] = true;
            }
            //validando mov abaixo
            pos.defineValues(pos.linha + 1, pos.coluna);
            if (tab.ValidaPos(pos) && podeMov(pos))
            {
                aux[pos.linha, pos.coluna] = true;
            }
            //validando mov sudoeste
            pos.defineValues(pos.linha + 1, pos.coluna - 1);
            if (tab.ValidaPos(pos) && podeMov(pos))
            {
                aux[pos.linha, pos.coluna] = true;
            }
            //validando mov esquerda
            pos.defineValues(pos.linha, pos.coluna - 1);
            if (tab.ValidaPos(pos) && podeMov(pos))
            {
                aux[pos.linha, pos.coluna] = true;
            }
            //validando mov esquerda
            pos.defineValues(pos.linha - 1, pos.coluna - 1);
            if (tab.ValidaPos(pos) && podeMov(pos))
            {
                aux[pos.linha, pos.coluna] = true;
            }
            return aux;
        }
        private bool podeMov(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
