namespace tabuleiro
{
    internal abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMoviment { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            qtdMoviment = 0;
        }

        public abstract bool[,] movPossiveis();
        
        public void incremQtdMov()
        {
            qtdMoviment++;
        }
    }
}
