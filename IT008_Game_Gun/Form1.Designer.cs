namespace IT008_Game_SaveThePlanet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.timerEnemyAppear = new System.Windows.Forms.Timer(this.components);
            this.timerEnemyFly = new System.Windows.Forms.Timer(this.components);
            this.timerBullet = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScoreNum = new System.Windows.Forms.Label();
            this.timerPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.labelBack = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayer.Image")));
            this.pictureBoxPlayer.Location = new System.Drawing.Point(247, 714);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(95, 84);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer.TabIndex = 0;
            this.pictureBoxPlayer.TabStop = false;
            this.pictureBoxPlayer.Visible = false;
            // 
            // timerEnemyAppear
            // 
            this.timerEnemyAppear.Enabled = true;
            this.timerEnemyAppear.Interval = 1500;
            this.timerEnemyAppear.Tick += new System.EventHandler(this.timerEnemyAppear_Tick);
            // 
            // timerEnemyFly
            // 
            this.timerEnemyFly.Enabled = true;
            this.timerEnemyFly.Interval = 60;
            this.timerEnemyFly.Tick += new System.EventHandler(this.timerEnemyFly_Tick);
            // 
            // timerBullet
            // 
            this.timerBullet.Enabled = true;
            this.timerBullet.Interval = 10;
            this.timerBullet.Tick += new System.EventHandler(this.timerBullet_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Snow;
            this.labelScore.Location = new System.Drawing.Point(221, 4);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(109, 32);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score:";
            // 
            // labelScoreNum
            // 
            this.labelScoreNum.AutoSize = true;
            this.labelScoreNum.BackColor = System.Drawing.Color.Transparent;
            this.labelScoreNum.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreNum.ForeColor = System.Drawing.Color.White;
            this.labelScoreNum.Location = new System.Drawing.Point(328, 5);
            this.labelScoreNum.Name = "labelScoreNum";
            this.labelScoreNum.Size = new System.Drawing.Size(91, 32);
            this.labelScoreNum.TabIndex = 2;
            this.labelScoreNum.Text = "           ";
            // 
            // timerPlayerMove
            // 
            this.timerPlayerMove.Enabled = true;
            this.timerPlayerMove.Interval = 15;
            this.timerPlayerMove.Tick += new System.EventHandler(this.timerPlayerMove_Tick);
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.Transparent;
            this.labelBack.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.Color.Snow;
            this.labelBack.Location = new System.Drawing.Point(59, 9);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(76, 26);
            this.labelBack.TabIndex = 1;
            this.labelBack.Text = "BACK";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            this.labelBack.MouseLeave += new System.EventHandler(this.labelBack_MouseLeave);
            this.labelBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelBack_MouseMove);
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.BackColor = System.Drawing.Color.Transparent;
            this.labelPause.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPause.ForeColor = System.Drawing.Color.Snow;
            this.labelPause.Location = new System.Drawing.Point(451, 11);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(87, 26);
            this.labelPause.TabIndex = 1;
            this.labelPause.Text = "PAUSE";
            this.labelPause.Click += new System.EventHandler(this.labelPause_Click);
            this.labelPause.MouseLeave += new System.EventHandler(this.labelPause_MouseLeave);
            this.labelPause.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPause_MouseMove);
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.labelGameOver.Font = new System.Drawing.Font("Algerian", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelGameOver.Location = new System.Drawing.Point(29, 357);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(531, 96);
            this.labelGameOver.TabIndex = 3;
            this.labelGameOver.Text = "GAME OVER";
            this.labelGameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 801);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelScoreNum);
            this.Controls.Add(this.labelPause);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxPlayer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save the Planet";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Timer timerEnemyAppear;
        private System.Windows.Forms.Timer timerEnemyFly;
        private System.Windows.Forms.Timer timerBullet;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScoreNum;
        private System.Windows.Forms.Timer timerPlayerMove;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Label labelGameOver;
    }
}

