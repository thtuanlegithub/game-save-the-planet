namespace IT008_Game_SaveThePlanet
{
    partial class HighestScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighestScoreForm));
            this.labelHighestScore = new System.Windows.Forms.Label();
            this.labelHighestScoreNum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHighestScore
            // 
            this.labelHighestScore.AutoSize = true;
            this.labelHighestScore.BackColor = System.Drawing.Color.Transparent;
            this.labelHighestScore.Font = new System.Drawing.Font("Algerian", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighestScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(129)))));
            this.labelHighestScore.Location = new System.Drawing.Point(133, 300);
            this.labelHighestScore.Name = "labelHighestScore";
            this.labelHighestScore.Size = new System.Drawing.Size(346, 48);
            this.labelHighestScore.TabIndex = 2;
            this.labelHighestScore.Text = "HIGHEST SCORE";
            // 
            // labelHighestScoreNum
            // 
            this.labelHighestScoreNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHighestScoreNum.AutoSize = true;
            this.labelHighestScoreNum.BackColor = System.Drawing.Color.Transparent;
            this.labelHighestScoreNum.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighestScoreNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(129)))));
            this.labelHighestScoreNum.Location = new System.Drawing.Point(213, 527);
            this.labelHighestScoreNum.Name = "labelHighestScoreNum";
            this.labelHighestScoreNum.Size = new System.Drawing.Size(108, 71);
            this.labelHighestScoreNum.TabIndex = 2;
            this.labelHighestScoreNum.Text = "00";
            this.labelHighestScoreNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.Transparent;
            this.labelBack.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.Color.Snow;
            this.labelBack.Location = new System.Drawing.Point(12, 18);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(76, 26);
            this.labelBack.TabIndex = 10;
            this.labelBack.Text = "BACK";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            this.labelBack.MouseLeave += new System.EventHandler(this.labelBack_MouseLeave);
            this.labelBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelBack_MouseMove);
            // 
            // HighestScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 801);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelHighestScoreNum);
            this.Controls.Add(this.labelHighestScore);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HighestScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save the Planet";
            this.Load += new System.EventHandler(this.HighestScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHighestScore;
        private System.Windows.Forms.Label labelHighestScoreNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBack;
    }
}