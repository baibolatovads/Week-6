using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
   public class Food:GameObject
    {
        public Food(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {

        }
        public static Point FoodCreate()
        {
            Point Food = new Point();
            bool exit = false;
            while (!exit) { }
            Random R = new Random();
            Food.X = R.Next(1, 35);
            Food.Y = R.Next(1, 35);
            if (Game.field[Food.X,Food.Y] != true)
            {
                exit = false;
            }

            return Food;
        }
    }
}
