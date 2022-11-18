using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT008_Game_SaveThePlanet
{
    public class Player
    {
        public Bitmap bitmap = new Bitmap("player.png");
        public Point location;
        public Player(Point location)
        {
            this.location = location; 
        }
        public Player(int X)
        {
            location.X = X;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(bitmap, location.X, location.Y, bitmap.Width, bitmap.Height);
        }
        public void Right()
        {
            location.X += 5;
        }
        public void Left()
        {
            location.Y -= 5;
        }
    }
}
