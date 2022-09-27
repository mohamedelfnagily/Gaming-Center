using games.BreakOutGame;
using games.FunnyBirdGame;
using games.SnakeGame;
using games.snakeLadderGame;
using games.TicTacToeGame;
using games.ZombieLandGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void flyingBirdBtn_Click(object sender, EventArgs e)
        {
            FunnyBird funBird = new FunnyBird();
            funBird.Show();
            this.Close();
        }

        private void zombieLandBtn_Click(object sender, EventArgs e)
        {
            ZombieLand zomLand = new ZombieLand();
            zomLand.Show();
            this.Close();
        }

        private void TicTacBtn_Click(object sender, EventArgs e)
        {
            TicTacGame tictac = new TicTacGame();
            tictac.Show();
            this.Close();
        }

        private void snakeBtn_Click(object sender, EventArgs e)
        {
            snakeGame snake = new snakeGame();
            snake.Show();
            this.Close();
        }

        private void snakeLaderBtn_Click(object sender, EventArgs e)
        {
            snakeLadder snakeladder = new snakeLadder();
            snakeladder.Show();
            this.Close();
        }

        private void breakOutBtn_Click(object sender, EventArgs e)
        {
            breakOutGame breakOut = new breakOutGame();
            breakOut.Show();
            this.Close();
        }

    }
}
