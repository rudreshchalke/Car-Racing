using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
            
            exit.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coin(gamespeed);
            count();
        }
        Random r  = new Random();
        int x, y;

        //coins
        void coin(int speed)
        {
            //coin1
            if(coin1.Top >= 500)
            {
                y = r.Next(0, 100);
                coin1.Location = new Point(y, 0);
                coin1.Visible = true;
            }
            else
            {
                coin1.Top += speed;
            }

            //coin2
            if (coin2.Top >= 500)
            {
                y = r.Next(101, 200);
                coin2.Location = new Point(y, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            //coin3
            if (coin3.Top >= 500)
            {
                y = r.Next(201, 300);
                coin3.Location = new Point(y, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            //coin4
            if (coin4.Top >= 500)
            {
                y = r.Next(301, 400);
                coin4.Location = new Point(y, 0);
            }
            else
            {
                coin4.Top += speed;
            }
        }
        void enemy(int speed)
        {
            //enemy1
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 100);
                enemy1.Location = new Point(x,0);
            }
            else
            {
                enemy1.Top += speed;
            }
            //enemy2
            if (enemy2.Top >= 500)
            {
                x = r.Next(120, 180);

                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }
            //enemy3
            if (enemy3.Top >= 500)
            {
                x = r.Next(300, 380);

                enemy3.Location = new Point(x,0);
            }
            else
            {
                enemy3.Top += speed;
            }
        }
        //coin count
        int cunt = 0;
        void count()
        {
            if(car.Bounds.IntersectsWith(coin1.Bounds))
            {
                cunt++;
                cnt.Text = cunt.ToString();
                y = r.Next(0, 100);
                coin1.Location = new Point(y, 0);
            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                cunt++;
                cnt.Text = cunt.ToString();
                y = r.Next(101, 200);
                coin2.Location = new Point(y, 0);
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                cunt++;
                cnt.Text = cunt.ToString();
                y = r.Next(201, 300);
                coin3.Location = new Point(y, 0);
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                cunt++;
                cnt.Text = cunt.ToString();
                y = r.Next(301, 400);
                coin4.Location = new Point(y, 0);
            }
        }
        

        //gameover
        void gameover()
        {
            if(car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible=true;
                exit.Visible=true;
               
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                
                exit.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                exit.Visible = true;
            }
        }

        void moveline(int speed)
        {
            if(pictureBox1.Top >=500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
            //pictureBox1.Top += speed;
            //pictureBox2.Top += speed;
            //pictureBox3.Top += speed;
            //pictureBox4.Top += speed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int gamespeed = 0;

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //left
            if(e.KeyCode==Keys.Left)
            {
                if(car.Left>0)
                car.Left += -10;
            }
            //right
            if(e.KeyCode==Keys.Right)
            {
                if(car.Right<380)
                car.Left += 10;
            }
            //up
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }
            //down
            if(e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                { gamespeed--; }
            }
        }
    }
}
