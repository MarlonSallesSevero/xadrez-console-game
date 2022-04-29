namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas { get; set; }
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linhas, int colunas)
        {
            return pecas[linhas, colunas];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool ExistPecas(Posicao pos)
        {
            PosValida(pos);
            return peca(pos) != null;
        }

        public void PutPecas(Peca pec, Posicao pos)
        {
            if (ExistPecas(pos))
            {
                throw new TabException("Já Existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = pec;
            pec.posicao = pos;
        }

        public Peca RemovePeca(Posicao p)
        {
            if (peca(p) == null)
            {
                return null;
            }
            Peca aux = peca(p);
            aux.posicao = null;
            pecas[p.linha, p.coluna] = null;
            return aux;
        }
        public bool ValidaPos(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }
        public void PosValida(Posicao pos)
        {
            if (!ValidaPos(pos))
            {
                throw new TabException("Posição Invalida!");
            }
        }
    }
}
