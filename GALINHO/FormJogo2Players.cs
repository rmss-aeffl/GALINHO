using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GALINHO
{
    public partial class FormJogo2Players : Form
    {
        private TabuleiroJogoGalo tab;
        private int jogador = 1;
        public FormJogo2Players()
        {
            InitializeComponent();
        }

        private void jogando_casa(PictureBox pictureBox)
        {
            int linha=1;
            int coluna=1;

            if (pictureBox.Name == "pictureBox1") { linha = 1; coluna = 1; }
            if (pictureBox.Name == "pictureBox2") { linha = 1; coluna = 2; }
            if (pictureBox.Name == "pictureBox3") { linha = 1; coluna = 3; }
            if (pictureBox.Name == "pictureBox4") { linha = 2; coluna = 1; }
            if (pictureBox.Name == "pictureBox5") { linha = 2; coluna = 2; }
            if (pictureBox.Name == "pictureBox6") { linha = 2; coluna = 3; }
            if (pictureBox.Name == "pictureBox7") { linha = 3; coluna = 1; }
            if (pictureBox.Name == "pictureBox8") { linha = 3; coluna = 2; }
            if (pictureBox.Name == "pictureBox9") { linha = 3; coluna = 3; }

            if (tab.verificarCasaVazia(linha, coluna) == true)
            {
               tab.jogarCasa(linha, coluna, jogador);
                if (jogador == 1)
                    pictureBox.Image = Image.FromFile("x.png");
                else
                    pictureBox.Image = Image.FromFile("o.png");
                if (jogador == 1) 
                    jogador = 2;
                else if (jogador == 2)
                    jogador = 1;
            }

            if (tab.testarVencedor() == "E")
                MessageBox.Show("Empate");
            if (tab.testarVencedor() == "X")
                MessageBox.Show("Player 1 Ganhou");
            if (tab.testarVencedor() == "O")
                MessageBox.Show("Player 2 Ganhou");
            label1.Text = "É a vez do jogador " + jogador.ToString() +
                            " ( " +  ((jogador == 1) ? "X" : "O") + " )";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            jogando_casa(pictureBox1);

        }

        private void FormJogo2Players_Load(object sender, EventArgs e)
        {
            tab = new TabuleiroJogoGalo();
            label1.Text = "É a vez do jogador " + jogador.ToString() +
                          " ( " + ((jogador == 1) ? "X" : "O") + " )";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            jogando_casa(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            jogando_casa(pictureBox3);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            jogando_casa(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            jogando_casa(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            jogando_casa(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            jogando_casa(pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            jogando_casa(pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            jogando_casa(pictureBox9);
        }
    }
}
