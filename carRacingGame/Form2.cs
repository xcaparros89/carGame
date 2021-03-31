﻿using System;
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

            //explosion.Visible = false; // hide the explosion image

            trafficSpeed = 5; // set the traffic back to default

            roadSpeed = 5; // set the road speed back to default

            score = 0; // reset score to 0

            //player.Left = 161; // reset player left
            //player.Top = 286; // reset player top

            //carLeft = false; // reset the moving left to false
            //carRight = false; // reset the moving right to false


            // move the AI to default position this will be off the screen
            //AI1.Left = 66;
            //AI1.Top = -120;

            //AI2.Left = 294;
            //AI2.Top = -185;

            //reset the road to their default position
            //roadTrack2.Left = -3;
            //roadTrack2.Top = -222;
            //roadTrack1.Left = -2;
            //roadTrack1.Top = -638;

            //start the timer
            timer1.Start();


        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            coin(gamespeed);
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

        void coin(int speed)
        {
            Random r = new Random();
            int x;
            PictureBox[] coinsArr = { coin1, coin2, coin3, coin4 };
            foreach (PictureBox coin in coinsArr)
            {
                if (coin.Top >= 500)
                {
                    x = r.Next(0, 200);
                    coin.Location = new Point(x, -50);
                    coin.Visible = true;
                }
                else if (speed < 5 && speed > 0)
                {
                    coin.Top += speed / 2 + 1;
                }
                else if (speed > 4)
                {
                    coin.Top += 5;
                }
            }
        }
        void enemy(int speed)
        {
            Random r = new Random();
            int x;
            int carImage;
            PictureBox[] enemyCarsArr = { carEnemy1, carEnemy2, carEnemy3, carEnemy4, carEnemy5 };
            foreach (PictureBox enemyCar in enemyCarsArr)
            {
                if (enemyCar.Top >= 500)
                {
                    x = r.Next(0, 200);
                    enemyCar.Location = new Point(x, -50);
                    //carImage = r.Next(1, 5);
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

        void collisionCheckEnemy()
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

        void collisionCheckCoin()
        {
            PictureBox[] coinsArr = { coin1, coin2, coin3, coin4 };
            foreach (PictureBox coin in coinsArr)
            {
                if (car1.Bounds.IntersectsWith(coin.Bounds) && coin.Visible)
                {
                    score += 1;
                    scoreLabel.Text = $"coins = {score}";
                    coin.Visible = false; 
                }
            }
        }

        private void something(object sender, KeyEventArgs e)
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

        private void startButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
