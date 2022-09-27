using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games.snakeLadderGame
{
    public delegate void checkLadderIntersection(PictureBox p);
    public partial class snakeLadder : Form
    {
        Random ran = new Random();
        int step = 57;
        bool playerTurn = true;
        //Two memberdata to know the position of the player
        int playerOneDiceTotal=0;
        int playerTwoDiceTotal=0;
        string playerOneDirection;
        string playerTwoDirection;
        
        public snakeLadder()
        {
            InitializeComponent();
        }

        private void rollingBtn_Click(object sender, EventArgs e)
        {
            this.diceBtn.Visible = true;
            this.rollingTimer.Start();
            

        }

        private void rollingTimer_Tick(object sender, EventArgs e)
        {
            
            //this.rollingTimer.Stop();
        }
        int playerTrapPosition = 0;
        private void stopBtn_Click(object sender, EventArgs e)
        {
            this.rollingTimer.Stop();
            this.diceNumber.Text = (ran.Next(1, 7)).ToString();
            //(ran.Next(1,6)).ToString()
            this.diceBtn.Visible = false;
            int IncrementingWhenGoingUp;
            int IncrementingWhenGoingUpTwo;
            int playerHeight;
            int playerHeightTwo;
            
            if (playerTurn)
            {
                playerOneDiceTotal += int.Parse(this.diceNumber.Text);
                int playerCureentHeight = this.playerOne.Top;
                playerHeight = PlayerSettings.CheckPlayerHeight(playerOneDiceTotal, playerCureentHeight, out IncrementingWhenGoingUp,out playerOneDirection);
                int leftPostion = (playerOneDiceTotal - IncrementingWhenGoingUp) * step;
                if (playerOneDirection=="left")
                {
                    this.playerOne.Left = leftPostion;
                }
                else
                {
                    int rightPosition = this.pictureBox1.Width - leftPostion-57;
                    this.playerOne.Left = rightPosition;
                }
                this.playerOne.Top = playerHeight;
                playerTrapPosition = playerOneDiceTotal;
                //Those steps are for checking on snakes trap
                this.animationTimer.Start();
                playerTurn = false;
                this.ladderTimer.Start();
                checkForWinner(this.playerOne);
            }
            else
            {
                playerTwoDiceTotal += int.Parse((this.diceNumber.Text));
                int playerCureentHeight = this.playerTwo.Top;
                playerHeightTwo = PlayerSettings.CheckPlayerHeight(playerTwoDiceTotal, playerCureentHeight, out IncrementingWhenGoingUpTwo, out playerTwoDirection);
                int leftPostion = (playerTwoDiceTotal - IncrementingWhenGoingUpTwo) * step;
                if (playerTwoDirection == "left")
                {
                    this.playerTwo.Left = leftPostion;
                }
                else
                {
                    int rightPosition = this.pictureBox1.Width - leftPostion - 57;
                    this.playerTwo.Left = rightPosition;
                }
                this.playerTwo.Top = playerHeightTwo;
                playerTrapPosition = playerTwoDiceTotal;
                this.animationTimer.Start();
                playerTurn = true;
                this.ladderTimer.Start();
                checkForWinner(this.playerTwo);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            int position= PlayerSettings.checkSnakeTrap(playerTrapPosition); ;
            PictureBox player = new PictureBox(); ;
            if(!playerTurn&&position!=0)
            {
                player = this.playerOne;
                playerOneDiceTotal = position;
            }
            else if (playerTurn && position!=0)
            {
                player = this.playerTwo;
                playerTwoDiceTotal = position;
                
            }
            

            if (position!=0)
            {
                switch (position)
                {
                    case 6:
                        player.Left = this.strap7.Left;
                        player.Top = this.strap7.Top;
                        break;
                    case 18:
                        player.Left = this.strap19.Left;
                        player.Top = this.strap19.Top;
                        break;
                    case 59:
                        player.Left = this.strap60.Left;
                        player.Top = this.strap60.Top;
                        break;
                    case 23:
                        player.Left = this.strap24.Left;
                        player.Top = this.strap24.Top;
                        break;
                    case 32:
                        player.Left = this.strap34.Left;
                        player.Top = this.strap34.Top;
                        break;
                    case 72:
                        player.Left = this.strap73.Left;
                        player.Top = this.strap73.Top;
                        break;
                    case 74:
                        player.Left = this.strap75.Left;
                        player.Top = this.strap75.Top;
                        break;
                    case 78:
                        player.Left = this.strap97.Left;
                        player.Top = this.strap97.Top;
                        break;

                }
            }

            this.animationTimer.Stop();
        }

        //Controlling the ladder position
        //this function is terribale but it will be inhanced
        private void checkLadder(PictureBox player,ref int currentCounters)
        {
            if(player.Bounds.IntersectsWith(ladder1.Bounds))
            {
                player.Left = ladder38.Left;
                player.Top = ladder38.Top;
                currentCounters = 38;
            }
            else if (player.Bounds.IntersectsWith(ladder4.Bounds))
            {
                player.Left = ladder14.Left;
                player.Top = ladder14.Top;
                currentCounters = 14;
            }
            else if (player.Bounds.IntersectsWith(ladder9.Bounds))
            {
                player.Left = ladder31.Left;
                player.Top = ladder31.Top;
                currentCounters = 31;
            }
            else if (player.Bounds.IntersectsWith(ladder28.Bounds))
            {
                player.Left = ladder84.Left;
                player.Top = ladder84.Top;
                currentCounters = 84;
            }
            else if (player.Bounds.IntersectsWith(ladder21.Bounds))
            {
                player.Left = ladder42.Left;
                player.Top = ladder42.Top;
                currentCounters = 42;
            }
            else if (player.Bounds.IntersectsWith(ladder51.Bounds))
            {
                player.Left = ladder67.Left;
                player.Top = ladder67.Top;
                currentCounters = 67;
            }
            else if (player.Bounds.IntersectsWith(ladder71.Bounds))
            {
                player.Left = ladder91.Left;
                player.Top = ladder91.Top;
                currentCounters = 91;
            }
            else if (player.Bounds.IntersectsWith(ladder80.Bounds))
            {
                player.Left = ladder100.Left;
                player.Top = ladder100.Top;
                currentCounters = 100;
            }

            checkForWinner(player);

        }

        private void ladderTimer_Tick(object sender, EventArgs e)
        {
            
            if(!playerTurn)
            {
                checkLadder(this.playerOne, ref playerOneDiceTotal);

            }
            else
            {
                checkLadder(this.playerTwo, ref playerTwoDiceTotal);
            }
            this.ladderTimer.Stop();
            
        }

        private void checkForWinner(PictureBox player)
        {
            if (player.Bounds.IntersectsWith(ladder100.Bounds))
            {
                this.rollingBtn.Enabled = false;
                this.stopBtn.Enabled = false;
                if(!playerTurn)
                {
                    this.label1.Text = "Player 1 is the winner :)";
                }
                else
                {
                    this.label1.Text = "Player 2 is the winner :)";
                }
                this.label1.Visible = true;
            }

                

        }

        private void snakeLadder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
