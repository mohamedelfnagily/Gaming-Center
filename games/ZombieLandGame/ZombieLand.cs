using games.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games.ZombieLandGame
{
    public partial class ZombieLand : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int Health = 100;
        int speed = 10;
        int pGold = 10;
        int zombieSpeed = 3;
        int score = 0;
        Random rand = new Random();
        List<PictureBox> zombies = new List<PictureBox>();

        public ZombieLand()
        {
            InitializeComponent();
            restartGame();
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(gameOver==true)
            {
                return;
            }
            if(e.KeyCode== Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }
            if(e.KeyCode==Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }
            if(e.KeyCode==Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;

            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;

            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if(Health>1)
            {
                this.progressBar1.Value = Health;
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.dead;
                mainTimer.Stop();
            }
            this.label2.Text ="Gold: " +pGold;
            this.playerKills.Text = "Kills: " + score;
            if(goLeft==true && player.Left>0)
            {
                player.Left -= speed;
            }
            if(goRight==true && player.Left+player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if(goUp==true && player.Top>40)
            {
                player.Top -= speed;
            }
            if(goDown==true && player.Top+player.Height<this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string) x.Tag=="Gold")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        pGold += 5;
                    }
                }
            }
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string) x.Tag=="zombie")
                {
                    if(this.player.Bounds.IntersectsWith(x.Bounds))
                    {
                        Health -= 1;
                    }
                    if(x.Left>player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }

                foreach(Control bull in this.Controls)
                {
                    if(bull is PictureBox && (string) bull.Tag=="bullet"&& x is PictureBox && (string) x.Tag=="zombie")
                    {
                        if(x.Bounds.IntersectsWith(bull.Bounds))
                        {
                            score++;
                            this.Controls.Remove(bull);
                            ((PictureBox)bull).Dispose();
                            this.Controls.Remove(x);
                            zombies.Remove(((PictureBox)x));
                            makeZombie();
                        }
                    }
                }

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
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
 
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
         
            }
            if (e.KeyCode == Keys.Space && pGold > 0 && gameOver == false)
            {
                pGold--;
                shootBullet(facing);
                if(pGold<1)
                {
                    dropGold();
                }
            }
            if(e.KeyCode==Keys.Enter && gameOver==true)
            {
                restartGame();
            }
        }

        private void ZombieLand_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void shootBullet(string direction)
        {
            Bullet shootbullet = new Bullet();
            shootbullet.direction = direction;
            shootbullet.bulletLeft = player.Left + (player.Width / 2);
            shootbullet.bulletTop = player.Top + (player.Height / 2);
            shootbullet.makeBullet(this);

        }
        private void makeZombie()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = rand.Next(0, 900);
            zombie.Top = rand.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombies.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();
        }

        private void dropGold()
        {
            PictureBox newGold = new PictureBox();
            newGold.Image = Properties.Resources.ammo_Image;
            newGold.SizeMode = PictureBoxSizeMode.AutoSize;
            newGold.Left = rand.Next(10, this.ClientSize.Width - newGold.Width);
            newGold.Top = rand.Next(60, this.ClientSize.Height - newGold.Height);
            newGold.Tag = "Gold";
            this.Controls.Add(newGold);
            newGold.BringToFront();
            player.BringToFront();
        }
        private void restartGame()
        {
            player.Image = Properties.Resources.up;
            foreach(PictureBox zom in zombies)
            {
                this.Controls.Remove(zom);
            }
            zombies.Clear();
            for(int i=0;i<3;i++)
            {
                makeZombie();
            }
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver= false;
            Health = 100;
            score = 0;
            pGold = 10;
            mainTimer.Start();

        }
    }
}
