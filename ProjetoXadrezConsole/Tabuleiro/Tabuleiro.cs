using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linha { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linha, int colunas, Peca[,] pecas)
        {
            this.linha = linha;
            this.colunas = colunas;
            this.pecas = pecas;
        }
    }
}
