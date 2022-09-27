using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games.FunnyBirdGame
{
    public partial class FunnyBird : Form
    {
        int gravity = 10;
        int speed = 8;
        int score = 0;
        int counter = 3;
        
        public FunnyBird()
        {
            InitializeComponent();
            
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            //moving the bird verticaly
            this.bird.Top += gravity;
            //moving the pipes to the left of the screen
            this.bottomPipe.Left -= speed;
            this.topPipe.Left -= speed;
            this.myScore.Text = "Score: "+ score;
            //returning the pipes back again to the screen
            if (bottomPipe.Left<-50)
            {
                bottomPipe.Left = 600;
                this.score++;
            }
            if (topPipe.Left < -80)
            {
                topPipe.Left = 650;
                this.score++;
            }
            //We need to check with each interval if the bird boundries hit any of the ground or the pipes boundries
            //if so we will stop the game and print game over and the score
            bool birdWithTopCheck = this.bird.Bounds.IntersectsWith(this.topPipe.Bounds);
            bool birdWithBottomCheck = this.bird.Bounds.IntersectsWith(this.bottomPipe.Bounds);
            bool birdWithGround = this.bird.Bounds.IntersectsWith(this.ground.Bounds);
            if(birdWithBottomCheck||birdWithGround||birdWithTopCheck|| this.bird.Top<0)
            {
                endGame();
            }
            gameHarder(score);
        }
        //This function is responsible for making the game more harder
        private void gameHarder(int currentScore)
        {
            switch (currentScore)
            {
                case 12:
                    this.speed = 12;
                    break;
                case 17:
                    this.speed = 15;
                    break;
                case 20:
                    this.bird.Size = new Size(70, 60);
                    break;
            }
        }
        //Controling the key down event on space key to raise the bird up
        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -10;
            }
        }
        //controlling the key up event to let the bird go down
        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        //game is ended when the user hit the boundries 
        private void endGame()
        {
            timer1.Stop();
            this.myScore.Text += " Game Over!!!";
            counter = 3;
            this.retry.Visible = true;
            this.exitApp.Visible = true;
        }

        //exitting the game when pressing exit button
        private void FunnyBird_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //this timer is responsible for giving the user 3 second to start playing
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.label1.Text = (counter - 1).ToString();
            counter--;
            if(counter==0)
            {
                timer2.Stop();
                this.label1.Text = "";
                timer1.Enabled = true;
                this.label2.Visible = false;
            }
        }

        private void retry_Click(object sender, EventArgs e)
        {
            resetAllSettings();
            this.retry.Visible = false;
            this.exitApp.Visible = false;
            this.timer2.Start();
            this.label1.Text = (counter - 1).ToString();
            counter--;
            if (counter == 0)
            {
                timer2.Stop();
                this.label1.Text = "";
                timer1.Enabled = true;
            }
        }
        //This function is used for resetting the locations of all the elements in order to start again after game over
        private void resetAllSettings()
        {
            this.score = 0;
            this.speed = 8;
            this.bird.Left = 30;
            this.bird.Top = 200;
            this.bottomPipe.Left = 276;
            this.topPipe.Left = 437;
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
