using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008_Game_SaveThePlanet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initPlayer();
        }
        Player player;
        public void initPlayer()
        {
            player = new Player(pictureBoxPlayer.Location);
        }
        List<Enemy> listEnemy = new List<Enemy>();
        List<Bullet> listBullet = new List<Bullet>();
        private void timerEnemyAppear_Tick(object sender, EventArgs e)
        {
            createEnemy();
            //this.Invalidate();
        }
        private void timerEnemyFly_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listEnemy.Count; i++)
            {

                if (listEnemy[i].location.Y < this.ClientSize.Height - 80)
                {
                    listEnemy[i].Down();
                }
                else
                {
                    listEnemy.RemoveAt(i);
                    i--;
                }
            }
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            player.Draw(g);
           
            for (int i = 0; i < listEnemy.Count; i++)
            {
                listEnemy[i].Draw(g);
                for(int j = 0; j < listBullet.Count; j++)
                {
                    listBullet[j].Draw(g);
                    if (listEnemy[i].location.X + 60 > listBullet[j].location.X
                        &&
                        listEnemy[i].location.X - 45 < listBullet[j].location.X
                        && 
                        listEnemy[i].location.Y + 45 > listBullet[j].location.Y)
                    {
                        Explode explode = new Explode(listEnemy[i].location);
                        explode.Draw(g);
                        if (listEnemy.Count>0)
                        {
                            listEnemy.RemoveAt(i);
                            i--;
                        }
                        if (listBullet.Count>0)
                        {
                            listBullet.RemoveAt(j);
                            j--;
                        }
                    }
                }
            }
            
        }

        private void createEnemy()
        {
            Random rd1 = new Random();
            int x = rd1.Next(0, this.ClientSize.Width-90);
            Point p = new Point(x, 0);
            Enemy enemy = new Enemy(p);
            listEnemy.Add(enemy);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Right)
            {
                if (player.location.X < this.ClientSize.Width - 95)
                    player.location.X += 20;
            }
            else if (e.KeyData == Keys.Left)
            {
                if (player.location.X > 0)
                    player.location.X -= 20;
            }
            else if(e.KeyData == Keys.Up)
            {
                if(player.location.Y>0)
                    player.location.Y -= 20;
            }
            else if(e.KeyData == Keys.Down)
            {
                if(player.location.Y<this.ClientSize.Height-84)
                    player.location.Y += 20;
            }
            else if(e.KeyData == Keys.Space)
            {
                createBullet();
            }
        }
        private void createBullet()
        {
            Bullet bullet = new Bullet(player.location);
            listBullet.Add(bullet);
        }
        
        private void timerBullet_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < listBullet.Count; i++)
            {
                if (listBullet[i].location.Y > 0)
                {
                    listBullet[i].location.Y -= 5;
                }
                else
                {
                    if (listBullet.Count > 0 && i<listBullet.Count && i >= 0)
                    {
                        listBullet.RemoveAt(i);
                        i--;
                    }
                }
            }
            this.Validate();
        }
    }
}
