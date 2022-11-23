using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;

namespace IT008_Game_SaveThePlanet
{
    public partial class Form1 : Form
    {
        public bool newgame = true;
        public string mode = File.ReadAllText("dataMode.txt");
        public Form1(bool newgame)
        {
            InitializeComponent();
            if (mode != File.ReadAllText("dataMode.txt"))
            {
                newgame = true;
            }
            if (newgame)
            {
                mode = File.ReadAllText("dataMode.txt");
                if (mode == "easy")
                {
                    timerEnemyAppear.Interval = 2000;
                    timerEnemyFly.Interval = 60;
                }
                else if(mode == "medium")
                {
                    timerEnemyAppear.Interval = 1500;
                    timerEnemyFly.Interval = 50;
                }
                else if(mode == "hard")
                {
                    timerEnemyAppear.Interval = 500;
                    timerEnemyFly.Interval = 40;
                }
                string scoreContinue = File.ReadAllText("dataContinueScore.txt");
                string scoreHighest = File.ReadAllText("dataHighScore.txt");
                int scoreC = int.Parse(scoreContinue);
                int scoreH = 0;
                if (scoreHighest.Length > 0)
                {
                    scoreH = int.Parse(scoreHighest);
                }
                if (scoreC > scoreH)
                {
                    File.WriteAllText("dataHighScore.txt", scoreC.ToString());
                }
                initPlayer();
            }
            else
            {
                loadData();
            }
            labelScoreNum.Text = score.ToString();
        }
        Player player;
        public void initPlayer()
        {
            player = new Player(pictureBoxPlayer.Location);
        }
        List<Enemy> listEnemy = new List<Enemy>();
        List<Bullet> listBullet = new List<Bullet>();
        private void loadData()
        {
            //score
            string[] strScore = File.ReadAllLines("dataContinueScore.txt");
            score = int.Parse(strScore[0]);
            //enemy
            string[] listEnemyJoin = File.ReadAllLines("dataContinueEnemy.txt");
            for(int i = 0; i < listEnemyJoin.Length; i++)
            {
                string[] listEnemySplit = listEnemyJoin[i].Split('/');
                int x = int.Parse(listEnemySplit[0]);
                int y = int.Parse(listEnemySplit[1]);
                Point p = new Point(x, y);
                Enemy enemy = new Enemy(p);
                listEnemy.Add(enemy);
            }
            //player
            string[] listPlayerJoin = File.ReadAllLines("dataContinuePlayer.txt");
            string[] listPlayerSplit = listPlayerJoin[0].Split('/');
            int playerX = int.Parse(listPlayerSplit[0]);
            int playerY = int.Parse(listPlayerSplit[1]);
            Point playerLocation = new Point(playerX, playerY);
            player = new Player(playerLocation);

            //bullet
            string[] listBulletJoin = File.ReadAllLines("dataContinueBullet.txt");
            for(int i = 0; i < listBulletJoin.Length; i++)
            {
                string[] listBulletSplit = listBulletJoin[i].Split('/');
                int x = int.Parse(listBulletSplit[0]);
                int y = int.Parse(listBulletSplit[1]);
                Point p = new Point(x, y);
                Bullet bullet = new Bullet(p);
                listBullet.Add(bullet);
            }
        }
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
                    timerBullet.Stop();
                    timerEnemyAppear.Stop();
                    timerEnemyFly.Stop();
                    timerPlayerMove.Stop();
                    labelGameOver.BringToFront();
                    labelGameOver.Visible = true;
                }
            }
            this.Invalidate();
        }
        private int score = 0;
        private bool checkCollide(Enemy enemy, Player player)
        {
            bool res = false;

            int x1PT, x2PT, y1PT, y2PT;
            int x1TT, x2TT, y1TT, y2TT;

            x1PT = player.location.X;
            x2PT = player.location.X + player.bitmap.Width;
            y1PT = player.location.Y;
            y2PT = player.location.Y + player.bitmap.Height;

            x1TT = enemy.location.X;
            x2TT = enemy.location.X + enemy.bitmap.Width;
            y1TT = enemy.location.Y;
            y2TT = enemy.location.Y + enemy.bitmap.Height;
            if (x1PT < x2TT && x1TT < x2PT && y1PT < y2TT && y1TT < y2PT)
                res = true;

            return res;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            player.Draw(g);
           
            for (int i = 0; i < listEnemy.Count; i++)
            {
                listEnemy[i].Draw(g);
                if (i >= 0
                    &&
                    checkCollide(listEnemy[i], player)
                    /*listEnemy[i].location.X + 20 > player.location.X 
                    &&
                    listEnemy[i].location.X < player.location.X + 55
                    &&
                    listEnemy[i].location.Y + 55  > player.location.Y
                    &&
                    listEnemy[i].location.Y - 55 < player.location.Y*/
                    )
                {
                    timerBullet.Stop();
                    timerEnemyAppear.Stop();
                    timerEnemyFly.Stop();
                    timerPlayerMove.Stop();
                    labelGameOver.BringToFront();
                    labelGameOver.Visible = true;
                }
                for(int j = 0; j < listBullet.Count; j++)
                {
                    listBullet[j].Draw(g);
                     if (i>=0 && j>=0
                        &&
                        listEnemy[i].location.X + 60 > listBullet[j].location.X
                        &&
                        listEnemy[i].location.X - 45 < listBullet[j].location.X
                        && 
                        listEnemy[i].location.Y + 45 > listBullet[j].location.Y
                        &&
                        listEnemy[i].location.Y - 45 < listBullet[j].location.Y
                        )
                    {
                        Explode explode = new Explode(listEnemy[i].location);
                        explode.Draw(g);
                        score += 5;
                        labelScoreNum.Text = score.ToString();
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
            Point p = new Point(x, 35);
            Enemy enemy = new Enemy(p);
            listEnemy.Add(enemy);
        }
        private bool left = false;
        private bool right = false;
        private bool up = false;
        private bool down = false;
        private bool space = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Right)
            {
                right = true;
                left = false;
                down = false;
                up = false;
               // space = false;
            }
            else if (e.KeyData == Keys.Left)
            {
                right = false;
                left = true;
                down = false;
                up = false;
                //space = false;
            }
            else if(e.KeyData == Keys.Up)
            {
                right = false;
                left = false;
                down = false;
                up = true;
                //space = false;
            }
            else if(e.KeyData == Keys.Down)
            {
                right = false;
                left = false;
                down = true;
                up = false;
                //space = false;
            }
            else if(e.KeyData == Keys.Space)
            {
                /* right = false;
                 left = false;
                 down = false;
                 up = false;*/
                createBullet();
            }
            else if(e.KeyData == Keys.Escape)
            {
                //lưu trạng thái hiện tại vào file
                string[] strEnemyJoin = new string[listEnemy.Count];
                string[] strBulletJoin = new string[listBullet.Count];
                string[] strPlayerJoin = new string[1];
                string[] strScore = new string[1];
                strScore[0] = labelScoreNum.Text;
                strPlayerJoin[0] = player.toString();
                for(int i = 0; i < listEnemy.Count; i++)
                {
                    strEnemyJoin[i] = listEnemy[i].toString();
                }
                for(int i = 0; i < listBullet.Count; i++)
                {
                    strBulletJoin[i] = listBullet[i].toString();
                }
                File.WriteAllLines("dataContinueScore.txt", strScore);
                File.WriteAllLines("dataContinueEnemy.txt", strEnemyJoin);
                File.WriteAllLines("dataContinueBullet.txt", strBulletJoin);
                File.WriteAllLines("dataContinuePlayer.txt", strPlayerJoin);
                //trở lại form menu
                MenuForm f = new MenuForm();
                this.Hide();
                f.ShowDialog();
                this.Close();
                
            }
        }
        private void createBullet()
        {
            Point p = new Point(player.location.X+25, player.location.Y);
            Bullet bullet = new Bullet(p);
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

        private void timerPlayerMove_Tick(object sender, EventArgs e)
        {
            if(left)
            {
                if (player.location.X > 0)
                    player.location.X -= 10;
            }
            if(right)
            {
                if (player.location.X < this.ClientSize.Width - 95)
                    player.location.X += 10;
            }
            if (up)
            {
                if (player.location.Y > 0)
                    player.location.Y -= 10;
            }
            if (down)
            {
                if (player.location.Y < this.ClientSize.Height - 84)
                    player.location.Y += 10;
            }
            
            this.Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (space)
            {
                space = false;
            }
            if (left)
            {
                left = false;
            }
            if (right)
            {
                right = false;
            }
            if (up)
            {
                up = false;
            }
            if (down)
            {
                down = false;
            }
        }

        

        private void labelBack_Click(object sender, EventArgs e)
        {
            //lưu trạng thái hiện tại vào file
            string[] strEnemyJoin = new string[listEnemy.Count];
            string[] strBulletJoin = new string[listBullet.Count];
            string[] strPlayerJoin = new string[1];
            string[] strScore = new string[1];
            strScore[0] = labelScoreNum.Text;
            strPlayerJoin[0] = player.toString();
            for (int i = 0; i < listEnemy.Count; i++)
            {
                strEnemyJoin[i] = listEnemy[i].toString();
            }
            for (int i = 0; i < listBullet.Count; i++)
            {
                strBulletJoin[i] = listBullet[i].toString();
            }
            File.WriteAllLines("dataContinueScore.txt", strScore);
            File.WriteAllLines("dataContinueEnemy.txt", strEnemyJoin);
            File.WriteAllLines("dataContinueBullet.txt", strBulletJoin);
            File.WriteAllLines("dataContinuePlayer.txt", strPlayerJoin);
            //trở lại form menu
            MenuForm f = new MenuForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        
        private void labelPause_Click(object sender, EventArgs e)
        {
            if (labelPause.Text == "PAUSE")
            {
                timerBullet.Stop();
                timerEnemyAppear.Stop();
                timerEnemyFly.Stop();
                timerPlayerMove.Stop();
                labelPause.Text = "CONTINUE";
            }
            else
            {
                timerBullet.Start();
                timerEnemyAppear.Start();
                timerEnemyFly.Start();
                timerPlayerMove.Start();
                labelPause.Text = "PAUSE";
            }
        }

        private void labelPause_MouseLeave(object sender, EventArgs e)
        {
            labelPause.ForeColor = Color.Snow;
        }

        private void labelPause_MouseMove(object sender, MouseEventArgs e)
        {
            labelPause.ForeColor = Color.DarkGray;
        }

        private void labelBack_MouseMove(object sender, MouseEventArgs e)
        {
            labelBack.ForeColor = Color.DarkGray;
        }

        private void labelBack_MouseLeave(object sender, EventArgs e)
        {
            labelBack.ForeColor = Color.Snow;
        }
    }
}
