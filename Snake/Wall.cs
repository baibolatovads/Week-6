using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall : GameObject
    {
        public Wall(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {

        }

        public void LoadLevel(GameLevel level)
        {
            string fname = "";
            string fname2 = "";

            switch (level)
            {
                case GameLevel.First:
                    fname = @"C:\Users\User_PC\Documents\PP2\Student\week 5\Snake\\Level1.txt";
                    break;
                case GameLevel.Second:
                    fname2 = @"C:\Users\User_PC\Documents\PP2\Student\week 5\Snake\\Level2_1.txt";
                    break;
                case GameLevel.Bonus:
                    break;
                default:
                    break;
            }

            FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            int y = 0;

            while ((line = sr.ReadLine()) != null)
            {
                for (int x = 0; x < line.Length; ++x)
                {
                    if (line[x] == '#')
                    {
                        this.body.Add(new Point { X = x, Y = y });
                    }
                }
                y++;
            }

            sr.Close();
            fs.Close();
        }
    }
}