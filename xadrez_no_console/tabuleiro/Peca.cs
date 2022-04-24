namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMoviment { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posica, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            qtdMoviment = 0;
        }
    }
}
