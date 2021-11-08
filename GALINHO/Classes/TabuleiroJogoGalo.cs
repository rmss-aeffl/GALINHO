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
        protected int n_jogadas =0;

        public TabuleiroJogoGalo()
        {
            ganhou = "N";
            casas = new char[3,3]{ { 'N', 'N', 'N' },
                                    { 'N', 'N', 'N' }, 
                                    { 'N', 'N', 'N' } };
            
        }

        public string testarVencedor()
        {

            /* LINHAS */
            if (casas[0, 0] == casas[0, 1] && casas[0, 1] == casas[0, 2]) return casas[0, 0].ToString();
            if (casas[1, 0] == casas[1, 1] && casas[1, 1] == casas[1, 2]) return casas[1, 0].ToString();
            if (casas[2, 0] == casas[2, 1] && casas[2, 1] == casas[2, 2]) return casas[2, 0].ToString();

            /* COLUNAS */
            if (casas[0, 0] == casas[1, 0] && casas[1, 0] == casas[2, 0]) return casas[0, 0].ToString();
            if (casas[0, 1] == casas[1, 1] && casas[1, 1] == casas[2, 1]) return casas[0, 1].ToString();
            if (casas[0, 2] == casas[1, 2] && casas[1, 2] == casas[2, 2]) return casas[0, 2].ToString();


            /* DIAGONAL */
            if (casas[0, 0] == casas[1, 1] && casas[1, 1] == casas[2, 2]) return casas[0, 0].ToString();
            if (casas[0, 2] == casas[1, 1] && casas[1, 1] == casas[2, 0]) return casas[0, 0].ToString();


            if (n_jogadas == 9)
                return "E";
            return "N";
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
            n_jogadas++;
        }

    }
}
