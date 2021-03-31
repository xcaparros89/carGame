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
    public partial class Form2 : Form
    {
        //global variables
        int carSpeed = 5;
        int roadSpeed = 5;
        int gamespeed = 0;
        bool carLeft;
        bool carRight;
        int trafficSpeed = 5;
        int score = 0;
        Random rnd = new Random();
        public Form2()
        {
            InitializeComponent();
            gameOverLabel.Visible = false;
            timer1.Stop();
        }
        private void Reset()
        {
            startButton.Enabled = false; // disable the button when game is running
            startButton.Text = "Start";
            gameOverLabel.Visible = false;
            //explosion.Visible = false; // hide the explosion image

            trafficSpeed = 5; // set the traffic back to default

            roadSpeed = 5; // set the road speed back to default

            score = 0; // reset score to 0

            car1.Location =  new Point(154, 321);
            carEnemy1.Location =  new Point(12, 32);
            carEnemy2.Location = new Point(85, 124);
            carEnemy3.Location = new Point(218, 321);
            carEnemy4.Location = new Point(290, 228);
            carEnemy5.Location = new Point(155, -68);

            coin1.Location = new Point(43, 321);
            coin2.Location = new Point(100, 228);
            coin3.Location = new Point(290, 124);
            coin4.Location = new Point(100, 32);
            coin5.Location = new Point(273, -68);

            centralLine1.Location = new Point(173, -16);
            centralLine2.Location = new Point(173, 120);
            centralLine3.Location = new Point(173, 244);
            centralLine4.Location = new Point(173, 379);

            //start the timer
            timer1.Start();


        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            moveObjDown(gamespeed);
            collisionCheckCoin();
            collisionCheckEnemy();
        }
        void moveline(int speed)
        {
            PictureBox[] centralLinesArr = { centralLine1, centralLine2, centralLine3, centralLine4 };
            foreach (PictureBox line in centralLinesArr)
            {
                if (line.Top >= 500)
                {
                    line.Top = -50;
                }
                else if(speed == 1)
                {
                    line.Top += speed;
                }
                else
                {
                    line.Top += speed/2;
                }

            }
        }

 

        void moveObjDown(int speed)
        {
            Random r = new Random();
            int xCar;
            int xCoin;
            PictureBox[] coinsArr = { coin1, coin2, coin3, coin4, coin5 };
            PictureBox[] enemyCarsArr = { carEnemy1, carEnemy2, carEnemy3, carEnemy4, carEnemy5 };
            for (int i = 0; i < enemyCarsArr.Length; i++)
            {
                PictureBox enemyCar = enemyCarsArr[i];
                PictureBox coin = coinsArr[i];

                if (enemyCar.Top >= 500)
                {
                    xCar = r.Next(0, 300);
                    enemyCar.Location = new Point(xCar, -50);
                    if (xCar > 150)
                    {
                        xCoin = r.Next(0, 150);
                        coin.Location = new Point(xCoin, -50);
                    }
                    else
                    {
                        xCoin = r.Next(155, 300);
                        coin.Location = new Point(xCoin, -50);
                    }
                    coin.Visible = true;
                }
                else if (speed < 5 && speed > 0)
                {
                    enemyCar.Top += speed / 2 + 1;
                    coin.Top += speed / 2 + 1;
                }
                else if (speed > 4)
                {
                    enemyCar.Top += 5;
                    coin.Top += 5;
                }

            }
        }

        void collisionCheckEnemy()
        {
            PictureBox[] enemyCarsArr = { carEnemy1, carEnemy2, carEnemy3, carEnemy4, carEnemy5 };
            foreach (PictureBox enemyCar in enemyCarsArr)
            {
                if (car1.Bounds.IntersectsWith(enemyCar.Bounds))
                {
                    timer1.Enabled = false;
                    gameOver();
                }
            }
        }

        void gameOver()
        {
            gameOverLabel.Visible = true;
            startButton.Text = "Try again?";
            startButton.Enabled = true;
        }

        void collisionCheckCoin()
        {
            PictureBox[] coinsArr = { coin1, coin2, coin3, coin4, coin5 };
            foreach (PictureBox coin in coinsArr)
            {
                if (car1.Bounds.IntersectsWith(coin.Bounds) && coin.Visible)
                {
                    score++;
                    scoreLabel.Text = $"coins = {score}";
                    coin.Visible = false; 
                }
            }
        }

        private void something(object sender, KeyEventArgs e)
        {
            if (!gameOverLabel.Visible)
            {
                if (e.KeyCode == Keys.Left && car1.Left - gamespeed > 5)
                {
                    car1.Left -= gamespeed;
                }
                if (e.KeyCode == Keys.Right && car1.Right + gamespeed < 350)
                {
                    car1.Left += gamespeed;
                }
                if (e.KeyCode == Keys.Up && gamespeed < 11)
                {
                    gamespeed += 1;
                }
                if (e.KeyCode == Keys.Down && gamespeed > 0)
                {
                    gamespeed -= 1;
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
