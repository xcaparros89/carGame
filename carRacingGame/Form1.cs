using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gameOverLabel.Visible = false;
            timer1.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline((gamespeed+1)/2);
            enemy(gamespeed);
            collisionCheck();
        }

        Random r = new Random();
        int x, y;        
        void enemy(int speed)
        {
            PictureBox[] enemyCarsArr = { carEnemy1, carEnemy2, carEnemy3, carEnemy4, carEnemy5 };
            foreach (PictureBox enemyCar in enemyCarsArr)
            {
                if (enemyCar.Top >= 500)
                {
                    x = r.Next(0, 200);
                    enemyCar.Location = new Point(x, -50);
                }
                else if (speed < 5 && speed > 0)
                {
                    enemyCar.Top += speed / 2 + 1;
                }
                else if (speed > 4)
                {
                    enemyCar.Top += 5;
                }
            }
        }
        
        void collisionCheck()
        {
            PictureBox[] enemyCarsArr = { carEnemy1, carEnemy2, carEnemy3, carEnemy4, carEnemy5 };
            foreach (PictureBox enemyCar in enemyCarsArr)
            {
                if (car1.Bounds.IntersectsWith(enemyCar.Bounds))
                {
                    timer1.Enabled = false;
                    gameOverLabel.Visible = true;
                }
            }
        }
        void moveline(int speed)
        {
            PictureBox[] centralLinesArr = { centralLine1, centralLine2, centralLine3, centralLine4 };
            foreach (PictureBox line in centralLinesArr)
            {
                if(line.Top >= 500)
                {
                    line.Top = -50;
                }
                else
                {
                    line.Top += speed;
                }

            }
        }
        int gamespeed = 0;

        private void gameScreenPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            scoreLabel.Visible = false;
            if (e.KeyCode == Keys.Left && car1.Left - gamespeed > 5)
            {
                car1.Left -= gamespeed;
            }
            if (e.KeyCode == Keys.Right && car1.Right + gamespeed < 380)
            {
                car1.Left += gamespeed;
            }
            if (e.KeyCode == Keys.Up && gamespeed<11)
            {
                gamespeed += 1;
            }
            if (e.KeyCode == Keys.Down && gamespeed>0)
            {
                gamespeed -= 1;
            }

        }
    }
}
