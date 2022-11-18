using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008_Game_SaveThePlanet
{
    internal class Explode
    {
        public Bitmap bitmap = new Bitmap("explode.png");
        public Point location;
        public Explode(Point location)
        {
            this.location = location;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(bitmap, location.X, location.Y, bitmap.Width, bitmap.Height);
        }
    }
}
