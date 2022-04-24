using System;
using tabuleiro;

namespace xadrez
{
    internal class PartidaXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno { get; set; }
        private Cor atualPlayer { get; set; }
        public bool finished { get; private set; }

        public PartidaXadrez()
        {
            this.tab = new Tabuleiro(8, 8);
            this.turno = 1;
            this.atualPlayer = Cor.Branca;
            this.finished = false;
            ColocarPecasXadrez();
        }

        public void ExeMov(Posicao origin, Posicao destiny)
        {
            Peca p = tab.RemovePeca(origin);
            p.incremQtdMov();
            Peca pecaCapturada = tab.RemovePeca(destiny);
            tab.PutPecas(p, destiny);   
        }

        private void ColocarPecasXadrez()
        {
            tab.PutPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
        }
    }
}
