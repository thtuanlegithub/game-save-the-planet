namespace IT008_Game_SaveThePlanet
{
    partial class ModeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeForm));
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.labelSelect = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Transparent;
            this.btnHard.FlatAppearance.BorderSize = 0;
            this.btnHard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnHard.Location = new System.Drawing.Point(152, 502);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(294, 64);
            this.btnHard.TabIndex = 6;
            this.btnHard.Text = "HARD";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            this.btnHard.MouseLeave += new System.EventHandler(this.btnHard_MouseLeave);
            this.btnHard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnHard_MouseMove);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.Transparent;
            this.btnMedium.FlatAppearance.BorderSize = 0;
            this.btnMedium.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMedium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(203)))), ((int)(((byte)(53)))));
            this.btnMedium.Location = new System.Drawing.Point(152, 405);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(294, 64);
            this.btnMedium.TabIndex = 7;
            this.btnMedium.Text = "MEDIUM";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            this.btnMedium.MouseLeave += new System.EventHandler(this.btnMedium_MouseLeave);
            this.btnMedium.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMedium_MouseMove);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.Transparent;
            this.btnEasy.FlatAppearance.BorderSize = 0;
            this.btnEasy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEasy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnEasy.Location = new System.Drawing.Point(152, 315);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(294, 64);
            this.btnEasy.TabIndex = 8;
            this.btnEasy.Text = "EASY";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            this.btnEasy.MouseLeave += new System.EventHandler(this.btnEasy_MouseLeave);
            this.btnEasy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEasy_MouseMove);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.BackColor = System.Drawing.Color.Transparent;
            this.labelSelect.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold);
            this.labelSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.labelSelect.Location = new System.Drawing.Point(78, 128);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(476, 54);
            this.labelSelect.TabIndex = 3;
            this.labelSelect.Text = "SELECT YOUR MODE";
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.Transparent;
            this.labelBack.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.Color.Snow;
            this.labelBack.Location = new System.Drawing.Point(12, 9);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(76, 26);
            this.labelBack.TabIndex = 9;
            this.labelBack.Text = "BACK";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            this.labelBack.MouseLeave += new System.EventHandler(this.labelBack_MouseLeave);
            this.labelBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelBack_MouseMove);
            // 
            // ModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 801);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.labelSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save the Planet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Label labelBack;
    }
}