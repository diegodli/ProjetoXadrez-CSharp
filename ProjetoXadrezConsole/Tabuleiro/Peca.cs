﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab,Cor cor)
        {
            this.posicao = null;
            this.cor = cor;  
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        public void IncrementarQtdMovimentos()
        {
            qteMovimentos++;
        }


    }
}
