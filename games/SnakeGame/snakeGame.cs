using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games.SnakeGame
{
    public partial class snakeGame : Form
    {
        private List<Circle> snake = new List<Circle>();
        private Circle food = new Circle();
        int maxWidth;
        int maxHeight;
        int gameScore;
        int myHighScore;
        Random rand = new Random();
        bool goLeft, goRight, goUp, goDown;
        public snakeGame()
        {
            InitializeComponent();
            new Settings();
        }

        private void HandligKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && Settings.directions!="right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }

        }

        private void HandlingKeyUp(object sender, KeyEventArgs e)
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
        }

        private void HandlingGameStart(object sender, EventArgs e)
        {
            RestartGame();

        }

        private void HandlingTimerEvent(object sender, EventArgs e)
        {
            //Settings the directions
            if(goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }

            for(int i=snake.Count-1;i>=0;i--)
            {
                if(i==0)
                {
                    switch(Settings.directions)
                    {
                        case "left":
                            snake[i].X--;
                            break;
                        case "right":
                            snake[i].X++;
                            break;
                        case "down":
                            snake[i].Y++;
                            break;
                        case "up":
                            snake[i].Y--;
                            break;
                    }
                    //controlling the part that if the snake reached the end of the screen it has to come from the other side
                    if(snake[i].X<0)
                    {
                        snake[i].X = maxWidth;
                    }
                    if (snake[i].X>maxWidth)
                    {
                        snake[i].X = 0;
                    }
                    if (snake[i].Y < 0)
                    {
                        snake[i].Y = maxHeight;
                    }
                    if (snake[i].Y > maxHeight)
                    {
                        snake[i].Y = 0;
                    }

                    if (snake[i].X == food.X && snake[i].Y==food.Y)
                    {
                        EatFood();
                    }
                    for(int j=1;j<snake.Count;j++)
                    {
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {   
                    //in order to let all circles follow each other
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }

                myBoundries.Invalidate();

            }
        }

        private void UpdatePictureBox(object sender, PaintEventArgs e)
        {
            //Here is the paint event which is linked to the picture box
            Graphics canvas = e.Graphics;
            Brush snakeColor;
            for(int i = 0; i < snake.Count; i++)
            {
                if(i==0)
                {
                    snakeColor = Brushes.White;
                }
                else
                {
                    snakeColor = Brushes.DarkGreen;
                }
                //creating the ellipse boundry of the snake and updating
                canvas.FillEllipse(snakeColor,new Rectangle(
                    //Here we will define the x,y of the snake object
                    snake[i].X * Settings.width,
                    snake[i].Y * Settings.height,
                    Settings.width,Settings.height
                    ));
            }
            canvas.FillEllipse(Brushes.Red, new Rectangle(
            //Here we will define the x,y of the snake object
            food.X * Settings.width,
            food.Y * Settings.height,
            Settings.width, Settings.height
            ));
        }

        private void snakeGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RestartGame()
        {
            //controlling the snake position
            maxWidth = myBoundries.Width / Settings.width - 1;
            maxHeight = myBoundries.Height / Settings.height - 1;
            snake.Clear();
            startBtn.Enabled = false;
            gameScore = 0;
            this.score.Text = "Score: " + gameScore;

            //Creating the snake body
            //placing the snake body at the middle of the screen
            Circle head = new Circle { X=10,Y=5};
            //Adding the head of the snake to the body
            snake.Add(head);
            //Creating 10 more circles as the initial body of the snake
            for(int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                snake.Add(body);
            }
            //Creating the food whch will be a circle also
            //but the food must be in a random position
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            myTimer.Start();

        }

        private void EatFood()
        {
            gameScore += 1;
            score.Text = "Score: " + gameScore;
            Circle body = new Circle
            {
                X = snake[snake.Count - 1].X,
                Y = snake[snake.Count - 1].Y
            };
            snake.Add(body);
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

        }

        private void GameOver()
        {
            myTimer.Stop();
            startBtn.Enabled = true;
            if(gameScore>myHighScore)
            {
                myHighScore = gameScore;
                highScore.Text = "High Score: " + myHighScore;
            }
        }
    }
}
