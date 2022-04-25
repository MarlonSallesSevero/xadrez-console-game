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
            //PECAS 01
            /*tab.PutPecas(new Peao(tab, Cor.Branca), new PosicaoXadrez('a', 2).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Branca), new PosicaoXadrez('b', 2).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Branca), new PosicaoXadrez('f', 2).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Branca), new PosicaoXadrez('g', 2).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Branca), new PosicaoXadrez('h', 2).ToPosicao());*/
            tab.PutPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('a', 1).ToPosicao());
            tab.PutPecas(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());
            /*tab.PutPecas(new Cavalo(tab, Cor.Branca), new PosicaoXadrez('b', 1).ToPosicao());
            tab.PutPecas(new Bispo(tab, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
            //tab.PutPecas(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());
            tab.PutPecas(new Rainha(tab, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            tab.PutPecas(new Bispo(tab, Cor.Branca), new PosicaoXadrez('f', 1).ToPosicao());
            tab.PutPecas(new Cavalo(tab, Cor.Branca), new PosicaoXadrez('g', 1).ToPosicao());
            tab.PutPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('h', 1).ToPosicao());*/
            //PECAS 02
           /* tab.PutPecas(new Peao(tab, Cor.Preto), new PosicaoXadrez('a', 7).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Preto), new PosicaoXadrez('b', 7).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Preto), new PosicaoXadrez('c', 7).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Preto), new PosicaoXadrez('d', 7).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Preto), new PosicaoXadrez('e', 7).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Preto), new PosicaoXadrez('f', 7).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Preto), new PosicaoXadrez('g', 7).ToPosicao());
            tab.PutPecas(new Peao(tab, Cor.Preto), new PosicaoXadrez('h', 7).ToPosicao());
            tab.PutPecas(new Torre(tab, Cor.Preto), new PosicaoXadrez('a', 8).ToPosicao());
            tab.PutPecas(new Cavalo(tab, Cor.Preto), new PosicaoXadrez('b', 8).ToPosicao());
            tab.PutPecas(new Bispo(tab, Cor.Preto), new PosicaoXadrez('c', 8).ToPosicao());
            tab.PutPecas(new Rei(tab, Cor.Preto), new PosicaoXadrez('d', 8).ToPosicao());
            tab.PutPecas(new Rainha(tab, Cor.Preto), new PosicaoXadrez('e', 8).ToPosicao());
            tab.PutPecas(new Bispo(tab, Cor.Preto), new PosicaoXadrez('f', 8).ToPosicao());
            tab.PutPecas(new Cavalo(tab, Cor.Preto), new PosicaoXadrez('g', 8).ToPosicao());
            tab.PutPecas(new Torre(tab, Cor.Preto), new PosicaoXadrez('h', 8).ToPosicao());*/
        }
    }
}
