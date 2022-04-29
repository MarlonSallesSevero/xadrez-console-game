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

        public bool ExistMovPossiveis()
        {
            bool[,] mat = movPossiveis();
            for(int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if(mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public bool CanMoveTo(Posicao pos)
        {
            return movPossiveis()[pos.linha, pos.coluna];
        }
        public abstract bool[,] movPossiveis();
        
        public void incremQtdMov()
        {
            qtdMoviment++;
        }
    }
}
