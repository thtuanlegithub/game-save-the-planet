using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008_Game_SaveThePlanet
{
    public class Enemy
    {
        public Bitmap bitmap = new Bitmap("jet2.png");
       
        public Point location;
        public Enemy(Point location)
        {
            this.location = location;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(bitmap, location.X, location.Y,bitmap.Width,bitmap.Height);
        }
        
        public void Down()
        {
            location.Y += 5;
        }
        public void Up()
        {
            location.Y -= 5;
        }
        public string toString()
        {
            return location.X.ToString() + "/" + location.Y.ToString();
        }
    }
}
