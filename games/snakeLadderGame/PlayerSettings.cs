using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games.snakeLadderGame
{
    internal static class PlayerSettings
    {
        public static int CheckPlayerHeight(int num,int currentTop, out int range,out string direction)
        {
            
            if(num>=0&&num<=9)
            {
                range = 0;
                direction = "left";
                return 556;
            }
            if (num >= 10&& num <= 19)
            {
                range = 10;
                direction = "right";
                return 496;
            }
            if (num >= 20&& num <= 29)
            {
                range = 20;
                direction = "left";
                return 436;
            }
            if (num >= 30& num <= 39)
            {
                range = 30;
                direction = "right";
                return 376;
            }
            if (num >= 40&& num <= 49)
            {
                range = 40;
                direction = "left";
                return 316;
            }
            if (num >= 50&& num <= 59)
            {
                range = 50;
                direction = "right";
                return 256;
            }
            if (num >= 60&& num <= 69)
            {
                range = 60;
                direction = "left";
                return 196;
            }
            if (num >= 70&& num <= 79)
            {
                range = 70;
                direction = "right";
                return 136;
            }
            if (num >= 80&& num <= 89)
            {
                range = 80;
                direction = "left";
                return 76;
            }
            if(num >= 90&& num <= 99)
            {
                range = 90;
                direction = "right";
                return 16;
            }
            range = 0;
            direction = "left";
            return 0;
        }

        public static int checkSnakeTrap(int position)
        {
            int num = 0;
            switch(position)
            {
                case 16:
                    num = 6;
                    break;
                case 61:
                    num = 18;
                    break;
                case 63:
                    num = 59;
                    break;
                case 86:
                    num = 23;
                    break;
                case 53:
                    num = 32;
                    break;
                case 92:
                    num = 72;
                    break;
                case 94:
                    num = 74;
                    break;
                case 97:
                    num = 78;
                    break;

            }

            return num;
        }

    }
}
