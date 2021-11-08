using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GALINHO
{
    class TabuleiroJogoGalo
    {
        protected char[,] casas; // 
        protected string ganhou; // X - 1 player O -2 player N - niguem E - empate

        public TabuleiroJogoGalo()
        {
            ganhou = "N";
            casas = new char[3,3]{ { 'N', 'N', 'N' },
                                    { 'N', 'N', 'N' }, 
                                    { 'N', 'N', 'N' } };
            
        }

        public string testarVencedor()
        {

            /*falta desenvolver */
            return "N";
            return "X";
            return "O";
        }

        public bool verificarCasaVazia(int lin, int col)
        {
            if (casas[lin-1,col-1]=='N') // casa vazia
                return true;
            return false;
        }

        public void jogarCasa(int lin, int col, int jog)
        {
            if (jog == 1)
                casas[lin - 1, col - 1] = 'X';
            if (jog == 2)
                casas[lin - 1, col - 1] = 'O';
        }

    }
}
