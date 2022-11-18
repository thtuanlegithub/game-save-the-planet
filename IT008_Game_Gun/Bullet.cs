using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT008_Game_SaveThePlanet
{
    internal class Bullet
    {
        public Bitmap bitmap = new Bitmap("fire3.png");
        public Point location;
        public Bullet(Point location)
        {
            this.location = location;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(bitmap, location.X, location.Y, bitmap.Width, bitmap.Height);
        }
        public void Up()
        {
            location.Y -= 10;
        }
    }
}
