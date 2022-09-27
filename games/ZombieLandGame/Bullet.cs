﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace games.ZombieLandGame
{
    internal class Bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;
        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void makeBullet(Form form)
        {
            bullet.BackColor = Color.White;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();
            form.Controls.Add(bullet);

            bulletTimer.Interval= speed;
            bulletTimer.Tick += new EventHandler(BulletTimeEvent);
            bulletTimer.Start();
        }
        private void BulletTimeEvent(object sender, EventArgs e)
        {
            if(direction=="left")
            {
                bullet.Left -= speed;
            }
            if(direction=="right")
            {
                bullet.Left += speed;
            }
            if(direction=="up")
            {
                bullet.Top -= speed;
            }
            if(direction=="down")
            {
                bullet.Top += speed;
            }

            if(bullet.Left<10 || bullet.Left>850 ||bullet.Top<10||bullet.Top>600)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }
    }
}
