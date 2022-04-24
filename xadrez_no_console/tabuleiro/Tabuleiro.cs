﻿namespace tabuleiro
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

        public void PutPecas(Peca pec, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = pec;
            pec.posicao = pos;
        }

    }
}
