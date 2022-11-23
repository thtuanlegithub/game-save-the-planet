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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void btnNewGame_MouseLeave(object sender, EventArgs e)
        {
            btnNewGame.ForeColor = Color.FromArgb(252, 39, 39);
        }

        private void btnNewGame_MouseMove(object sender, MouseEventArgs e)
        {
            btnNewGame.ForeColor = Color.FromArgb(251, 90, 83);
        }

        private void btnContinue_MouseLeave(object sender, EventArgs e)
        {
            btnContinue.ForeColor = Color.FromArgb(251, 203, 53);
        }

        private void btnContinue_MouseMove(object sender, MouseEventArgs e)
        {
            btnContinue.ForeColor = Color.FromArgb(252, 217, 109);
        }

        private void btnMode_MouseLeave(object sender, EventArgs e)
        {
            btnMode.ForeColor = Color.FromArgb(251, 125, 0); 
        }

        private void btnMode_MouseMove(object sender, MouseEventArgs e)
        {
            btnMode.ForeColor = Color.FromArgb(251, 154, 35);
        }

        private void btnHighScore_MouseLeave(object sender, EventArgs e)
        {
            btnHighScore.ForeColor = Color.FromArgb(125, 251, 0);  
        }

        private void btnHighScore_MouseMove(object sender, MouseEventArgs e)
        {
            btnHighScore.ForeColor = Color.FromArgb(165, 220, 11);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(true);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            btnHelp.ForeColor = Color.FromArgb(4, 149, 255);
        }

        private void btnHelp_MouseMove(object sender, MouseEventArgs e)
        {
            btnHelp.ForeColor = Color.FromArgb(34, 162, 209);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //mở lại form play
            Form1 f = new Form1(false);
            this.Hide();
            f.ShowDialog();
            this.Close();            
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            ModeForm f = new ModeForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            HighestScoreForm f = new HighestScoreForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm f = new HelpForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
