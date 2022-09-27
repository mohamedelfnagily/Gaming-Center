using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace games.SnakeGame
{
    //This class is responsible for tracking the x,y position of the snake body
    //where the snake body will be a list of circles
    internal class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Circle()
        {
            this.X = 0;
            this.Y = 0;
        }
    }
}
