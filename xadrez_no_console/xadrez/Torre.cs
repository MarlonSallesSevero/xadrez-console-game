using tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        private bool podeMov(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }

        public override bool[,] movPossiveis()
        {
            bool[,] aux = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);
            //Acima
            pos.defineValues(posicao.linha - 1, posicao.coluna);
            while (tab.ValidaPos(pos) && podeMov(pos))
            {
                aux[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            //abaixo
            pos.defineValues(posicao.linha + 1, posicao.coluna);
            while (tab.ValidaPos(pos) && podeMov(pos))
            {
                aux[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            //direita
            pos.defineValues(posicao.linha, posicao.coluna + 1);
            while (tab.ValidaPos(pos) && podeMov(pos))
            {
                aux[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            //esquerda
            pos.defineValues(posicao.linha, posicao.coluna - 1);
            while (tab.ValidaPos(pos) && podeMov(pos))
            {
                aux[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }
            return aux;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
