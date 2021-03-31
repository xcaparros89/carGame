
namespace carRacingGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.centralLine1 = new System.Windows.Forms.PictureBox();
            this.centralLine2 = new System.Windows.Forms.PictureBox();
            this.centralLine3 = new System.Windows.Forms.PictureBox();
            this.centralLine4 = new System.Windows.Forms.PictureBox();
            this.leftLine = new System.Windows.Forms.PictureBox();
            this.rightLine = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.carEnemy2 = new System.Windows.Forms.PictureBox();
            this.carEnemy3 = new System.Windows.Forms.PictureBox();
            this.carEnemy4 = new System.Windows.Forms.PictureBox();
            this.carEnemy1 = new System.Windows.Forms.PictureBox();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.carEnemy5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gameScreenPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.centralLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEnemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEnemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEnemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gameScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(153, 484);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(62, 15);
            this.scoreLabel.TabIndex = 32;
            this.scoreLabel.Text = "Coins = 0";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.BurlyWood;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.startButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.Sienna;
            this.startButton.Location = new System.Drawing.Point(153, 515);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 27);
            this.startButton.TabIndex = 33;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // centralLine1
            // 
            this.centralLine1.BackColor = System.Drawing.Color.White;
            this.centralLine1.Location = new System.Drawing.Point(184, 13);
            this.centralLine1.Name = "centralLine1";
            this.centralLine1.Size = new System.Drawing.Size(10, 72);
            this.centralLine1.TabIndex = 16;
            this.centralLine1.TabStop = false;
            // 
            // centralLine2
            // 
            this.centralLine2.BackColor = System.Drawing.Color.White;
            this.centralLine2.Location = new System.Drawing.Point(184, 149);
            this.centralLine2.Name = "centralLine2";
            this.centralLine2.Size = new System.Drawing.Size(10, 72);
            this.centralLine2.TabIndex = 17;
            this.centralLine2.TabStop = false;
            // 
            // centralLine3
            // 
            this.centralLine3.BackColor = System.Drawing.Color.White;
            this.centralLine3.Location = new System.Drawing.Point(184, 273);
            this.centralLine3.Name = "centralLine3";
            this.centralLine3.Size = new System.Drawing.Size(10, 72);
            this.centralLine3.TabIndex = 18;
            this.centralLine3.TabStop = false;
            // 
            // centralLine4
            // 
            this.centralLine4.BackColor = System.Drawing.Color.White;
            this.centralLine4.Location = new System.Drawing.Point(184, 408);
            this.centralLine4.Name = "centralLine4";
            this.centralLine4.Size = new System.Drawing.Size(10, 72);
            this.centralLine4.TabIndex = 19;
            this.centralLine4.TabStop = false;
            // 
            // leftLine
            // 
            this.leftLine.BackColor = System.Drawing.Color.White;
            this.leftLine.Location = new System.Drawing.Point(-4, -1);
            this.leftLine.Name = "leftLine";
            this.leftLine.Size = new System.Drawing.Size(10, 471);
            this.leftLine.TabIndex = 20;
            this.leftLine.TabStop = false;
            // 
            // rightLine
            // 
            this.rightLine.BackColor = System.Drawing.Color.White;
            this.rightLine.Location = new System.Drawing.Point(378, -1);
            this.rightLine.Name = "rightLine";
            this.rightLine.Size = new System.Drawing.Size(10, 471);
            this.rightLine.TabIndex = 21;
            this.rightLine.TabStop = false;
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = global::carRacingGame.Properties.Resources.car1;
            this.car1.Location = new System.Drawing.Point(160, 344);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(55, 82);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 22;
            this.car1.TabStop = false;
            // 
            // carEnemy2
            // 
            this.carEnemy2.BackColor = System.Drawing.Color.Transparent;
            this.carEnemy2.Image = global::carRacingGame.Properties.Resources.car3;
            this.carEnemy2.Location = new System.Drawing.Point(100, 147);
            this.carEnemy2.Name = "carEnemy2";
            this.carEnemy2.Size = new System.Drawing.Size(55, 82);
            this.carEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carEnemy2.TabIndex = 23;
            this.carEnemy2.TabStop = false;
            // 
            // carEnemy3
            // 
            this.carEnemy3.BackColor = System.Drawing.Color.Transparent;
            this.carEnemy3.Image = global::carRacingGame.Properties.Resources.car4;
            this.carEnemy3.Location = new System.Drawing.Point(233, 344);
            this.carEnemy3.Name = "carEnemy3";
            this.carEnemy3.Size = new System.Drawing.Size(55, 82);
            this.carEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carEnemy3.TabIndex = 24;
            this.carEnemy3.TabStop = false;
            // 
            // carEnemy4
            // 
            this.carEnemy4.BackColor = System.Drawing.Color.Transparent;
            this.carEnemy4.Image = global::carRacingGame.Properties.Resources.car5;
            this.carEnemy4.Location = new System.Drawing.Point(305, 251);
            this.carEnemy4.Name = "carEnemy4";
            this.carEnemy4.Size = new System.Drawing.Size(55, 82);
            this.carEnemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carEnemy4.TabIndex = 25;
            this.carEnemy4.TabStop = false;
            // 
            // carEnemy1
            // 
            this.carEnemy1.BackColor = System.Drawing.Color.Transparent;
            this.carEnemy1.Image = global::carRacingGame.Properties.Resources.car2;
            this.carEnemy1.Location = new System.Drawing.Point(27, 55);
            this.carEnemy1.Name = "carEnemy1";
            this.carEnemy1.Size = new System.Drawing.Size(55, 82);
            this.carEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carEnemy1.TabIndex = 26;
            this.carEnemy1.TabStop = false;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.gameOverLabel.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverLabel.ForeColor = System.Drawing.Color.Sienna;
            this.gameOverLabel.Location = new System.Drawing.Point(87, 185);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(211, 44);
            this.gameOverLabel.TabIndex = 27;
            this.gameOverLabel.Text = "Game Over";
            // 
            // carEnemy5
            // 
            this.carEnemy5.BackColor = System.Drawing.Color.Transparent;
            this.carEnemy5.Image = global::carRacingGame.Properties.Resources.car6;
            this.carEnemy5.Location = new System.Drawing.Point(97, -90);
            this.carEnemy5.Name = "carEnemy5";
            this.carEnemy5.Size = new System.Drawing.Size(55, 82);
            this.carEnemy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carEnemy5.TabIndex = 28;
            this.carEnemy5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Image = global::carRacingGame.Properties.Resources.coin2;
            this.pictureBox1.Location = new System.Drawing.Point(87, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Image = global::carRacingGame.Properties.Resources.coin2;
            this.pictureBox2.Location = new System.Drawing.Point(120, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // gameScreenPanel
            // 
            this.gameScreenPanel.BackColor = System.Drawing.Color.Gray;
            this.gameScreenPanel.Controls.Add(this.pictureBox2);
            this.gameScreenPanel.Controls.Add(this.pictureBox1);
            this.gameScreenPanel.Controls.Add(this.carEnemy5);
            this.gameScreenPanel.Controls.Add(this.car1);
            this.gameScreenPanel.Controls.Add(this.gameOverLabel);
            this.gameScreenPanel.Controls.Add(this.carEnemy1);
            this.gameScreenPanel.Controls.Add(this.carEnemy4);
            this.gameScreenPanel.Controls.Add(this.carEnemy3);
            this.gameScreenPanel.Controls.Add(this.carEnemy2);
            this.gameScreenPanel.Controls.Add(this.rightLine);
            this.gameScreenPanel.Controls.Add(this.leftLine);
            this.gameScreenPanel.Controls.Add(this.centralLine4);
            this.gameScreenPanel.Controls.Add(this.centralLine3);
            this.gameScreenPanel.Controls.Add(this.centralLine2);
            this.gameScreenPanel.Controls.Add(this.centralLine1);
            this.gameScreenPanel.Location = new System.Drawing.Point(0, 1);
            this.gameScreenPanel.Name = "gameScreenPanel";
            this.gameScreenPanel.Size = new System.Drawing.Size(385, 470);
            this.gameScreenPanel.TabIndex = 0;
            this.gameScreenPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gameScreenPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(384, 652);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gameScreenPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.centralLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centralLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEnemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEnemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEnemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gameScreenPanel.ResumeLayout(false);
            this.gameScreenPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox centralLine1;
        private System.Windows.Forms.PictureBox centralLine2;
        private System.Windows.Forms.PictureBox centralLine3;
        private System.Windows.Forms.PictureBox centralLine4;
        private System.Windows.Forms.PictureBox leftLine;
        private System.Windows.Forms.PictureBox rightLine;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox carEnemy2;
        private System.Windows.Forms.PictureBox carEnemy3;
        private System.Windows.Forms.PictureBox carEnemy4;
        private System.Windows.Forms.PictureBox carEnemy1;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.PictureBox carEnemy5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel gameScreenPanel;
    }
}

