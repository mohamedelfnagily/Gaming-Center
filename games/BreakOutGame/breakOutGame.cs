using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games.BreakOutGame
{
    public partial class breakOutGame : Form
    {
        bool goRight, goLeft, gameOVer;
        int playerscore;
        int ballX;
        int ballY;
        int playerSpeed;
        Random rand = new Random();
        public breakOutGame()
        {
            InitializeComponent();
            setUpGame();
        }

        private void setUpGame()
        {
            playerscore = 0;
            ballX = 5;
            ballY = 5;
            playerSpeed = 8;
            score.Text = "score" + playerscore;
            mainTimer.Start();
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag=="blocks")
                {
                    
                    x.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                    
                }
            }
        }
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            score.Text = "score: " + playerscore;
            if(goLeft==true && playerBoard.Left>10)
            {
                playerBoard.Left -= playerSpeed;
            }
            if (goRight == true && playerBoard.Left < 520)
            {
                playerBoard.Left += playerSpeed;
            }
            ball.Left += ballX;
            ball.Top += ballY;
            if(ball.Left<10||ball.Left>520)
            {
                ballX = -ballX;
            }
            if(ball.Top<0)
            {
                ballY = -ballY;
            }
            if (ball.Bounds.IntersectsWith(playerBoard.Bounds))
            {
                ballY = rand.Next(5, 12) * -1;
                if(ballX<0)
                {
                    ballX = rand.Next(5, 12) * -1;
                }
                else
                {
                    ballX = rand.Next(5, 12);
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {

                    if(ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerscore += 1;
                        ballY = -ballY;
                        this.Controls.Remove(x);
                    }
                }
            }
            if(playerscore==15)
            {
                isGameOver("You Win!! congratulations :)");
            }
            if(ball.Top>580)
            {
                isGameOver("You Lost!! Hard Luck :(");
            }
        }
        private void isGameOver(string message)
        {
            gameOVer = true;
            mainTimer.Stop();
            score.Text = "Score: " + playerscore + " " + message;
        }

        private void breakOutGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void breakOutGame_Load(object sender, EventArgs e)
        {

        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode==Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }
    }
}
