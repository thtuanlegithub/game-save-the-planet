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

namespace IT008_Game_SaveThePlanet
{
    public partial class ModeForm : Form
    {
        public ModeForm()
        {
            InitializeComponent();
        }

        private void labelBack_MouseMove(object sender, MouseEventArgs e)
        {
            labelBack.ForeColor = Color.DarkGray;
        }

        private void labelBack_MouseLeave(object sender, EventArgs e)
        {
            labelBack.ForeColor = Color.Snow;
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnEasy_MouseMove(object sender, MouseEventArgs e)
        {
            btnEasy.ForeColor = Color.FromArgb(251, 90, 83);
        }

        private void btnEasy_MouseLeave(object sender, EventArgs e)
        {
            btnEasy.ForeColor = Color.FromArgb(252, 39, 39);
        }

        private void btnMedium_MouseMove(object sender, MouseEventArgs e)
        {
            btnMedium.ForeColor = Color.FromArgb(252, 217, 109);
        }

        private void btnMedium_MouseLeave(object sender, EventArgs e)
        {
            btnMedium.ForeColor = Color.FromArgb(251, 203, 53);
        }

        private void btnHard_MouseMove(object sender, MouseEventArgs e)
        {
            btnHard.ForeColor = Color.FromArgb(34, 162, 209);
        }

        private void btnHard_MouseLeave(object sender, EventArgs e)
        {
            btnHard.ForeColor = Color.FromArgb(4, 149, 255);
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            File.WriteAllText("dataMode.txt", "easy");
            MenuForm f = new MenuForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            File.WriteAllText("dataMode.txt", "medium");
            MenuForm f = new MenuForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            File.WriteAllText("dataMode.txt", "hard");
            MenuForm f = new MenuForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
