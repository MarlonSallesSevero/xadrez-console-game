using System;
using tabuleiro;
using System.Collections.Generic;


namespace xadrez
{
    internal class PartidaXadrez
    {
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor atualPlayer { get; private set; }
        public bool finished { get; private set; }
        private HashSet<Peca> pecas { get; set; }
        private HashSet<Peca> capturdas { get; set; }

        public PartidaXadrez()
        {
            this.tab = new Tabuleiro(8, 8);
            this.turno = 1;
            this.atualPlayer = Cor.Branca;
            this.finished = false;
            this.pecas = new HashSet<Peca>();
            this.capturdas = new HashSet<Peca>();
            ColocarPecasXadrez();
        }
        public void ExeMov(Posicao origin, Posicao destiny)
        {
            Peca p = tab.RemovePeca(origin);
            p.incremQtdMov();
            Peca pecaCapturada = tab.RemovePeca(destiny);
            tab.PutPecas(p, destiny);
            if (pecaCapturada != null)
            {
                capturdas.Add(pecaCapturada);
            }
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExeMov(origem, destino);
            turno++;
            mudaPlayer();
        }

        private void mudaPlayer()
        {
            if (atualPlayer == Cor.Branca)
            {
                atualPlayer = Cor.Preto;
            }
            else
            {
                atualPlayer = Cor.Branca;
            }
        }

        public HashSet<Peca> PecasCapturdas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca item in aux)
            {
                if (item.cor == cor)
                {
                    aux.Add(item);
                }
            }
            return aux;
        }

        public HashSet<Peca> PecasInGame(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca item in aux)
            {
                if (item.cor == cor)
                {
                    aux.Add(item);
                }
            }
            aux.ExceptWith(PecasCapturdas(cor));
            return aux;        }
        public void ValidarPosOrigem(Posicao origem)
        {
            if (tab.peca(origem) == null)
            {
                throw new TabException("Nao existe peça na posição de origem escolhida!");
            }

            if (atualPlayer != tab.peca(origem).cor)
            {
                throw new TabException("A peça de origem escolhida não é sua!");
            }

            if (!tab.peca(origem).ExistMovPossiveis())
            {
                throw new TabException("Não existe movimentos possiveis!");
            }
        }

        public void ValidaPosDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).CanMoveTo(destino))
            {
                throw new TabException("Posicao de destino invalida!");
            }
        }

        public void ColocarNewPeca(char coll, int n, Peca peca)
        {
            tab.PutPecas(peca, new PosicaoXadrez(coll, n).ToPosicao());
        }

        private void ColocarPecasXadrez()
        {

            ColocarNewPeca('c', 1, new Torre(tab, Cor.Branca));
            ColocarNewPeca('c', 2, new Torre(tab, Cor.Branca));
            ColocarNewPeca('d', 2, new Rei(tab, Cor.Branca));
            ColocarNewPeca('e', 2, new Rei(tab, Cor.Branca));
            ColocarNewPeca('e', 1, new Torre(tab, Cor.Branca));
            ColocarNewPeca('d', 1, new Torre(tab, Cor.Branca));

            ColocarNewPeca('c', 7, new Torre(tab, Cor.Preto));
            ColocarNewPeca('c', 8, new Rei(tab, Cor.Preto));
            ColocarNewPeca('d', 7, new Rei(tab, Cor.Preto));
            ColocarNewPeca('e', 7, new Torre(tab, Cor.Preto));
            ColocarNewPeca('e', 8, new Torre(tab, Cor.Preto));
            ColocarNewPeca('d', 8, new Torre(tab, Cor.Preto));
        }
    }
}
