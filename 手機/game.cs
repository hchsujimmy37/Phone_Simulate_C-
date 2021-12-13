using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace 手機
{
    public partial class game : Form
    {
        public game(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }
        SoundPlayer player2;
      
       
        int time = 0;
        int bye = 0;
        int number = 0;
        int number1 = 0;
        public bool run = false;
        int timing = 150;
        Form1 f1;
        List<PictureBox> pplist1 = new List<PictureBox>();
        List<PictureBox> pplist2 = new List<PictureBox>();
        private void game_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            player2 = new SoundPlayer("./explore.wav");
            ship.SizeMode = PictureBoxSizeMode.Zoom;
            timer1.Enabled = true;
        }

        private void game_FormClosing(object sender, FormClosingEventArgs e)
        {
            run = false;
            e.Cancel = true; // 取消關閉作業
            Hide();          // 隱藏視窗e.Cancel = true; // 取消關閉作業
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timing--;
            if (timing >= 0)
            { label1.Text = "時間:" + timing; }
            if (timing == 0)
            {
                run = false;
                MessageBox.Show("恭喜成功躲過炸彈 免於爆炸");
                this.Hide();
            }
            if (run == true)
            {
                Random random = new Random();
                time++;
                if (time % 10 == 0)
                {
                    int x = random.Next(0, 420);
                    int y = -10;
                    PictureBox temp = new PictureBox();
                    pplist1.Add(temp);
                    pplist1[number].Size = new Size(30, 30);
                    pplist1[number].SizeMode = PictureBoxSizeMode.Zoom;
                    pplist1[number].Image = Image.FromFile("./bomb.png");
                    pplist1[number].BackgroundImage = Image.FromFile("./bbb.jpg");
                    pplist1[number].Location = new Point(x, y);
                    this.Controls.Add(pplist1[number]);
                    number++;
                }
                if (time % 15 == 0)
                {
                    int x = random.Next(0, 420);
                    int y = 500;
                    PictureBox temp1 = new PictureBox();
                    pplist2.Add(temp1);
                    pplist2[number1].Size = new Size(30, 30);
                    pplist2[number1].SizeMode = PictureBoxSizeMode.Zoom;
                    pplist2[number1].Image = Image.FromFile("./bomb.png");
                    pplist2[number1].BackgroundImage = Image.FromFile("./bbb.jpg");
                    pplist2[number1].Location = new Point(x, y);
                    this.Controls.Add(pplist2[number1]);
                    number1++;
                }
                foreach (PictureBox pb in pplist2)
                {
                    pb.Top = pb.Top - 5 - time / 10;
                    if (pb.Bottom >= ship.Top + 3 && pb.Top + 3 <= ship.Bottom)
                    {
                        if (pb.Right >= ship.Left + 3 && pb.Left + 3 <= ship.Left)
                        {
                            timer1.Enabled = false;
                            run = false;
                            pictureBox1.Show();
                            player2.PlayLooping();
                            timer2.Enabled = true;

                        }
                        if (pb.Left + 3 <= ship.Right && pb.Right >= 3 + ship.Right)
                        {
                            timer1.Enabled = false;
                            run = false;
                            player2.PlayLooping();
                            pictureBox1.Show();
                            timer2.Enabled = true;
                        }
                    }
                    if (pb.Left + 3 <= ship.Right && pb.Right >= 3 + ship.Left)
                    {
                        if (pb.Top + 3 <= ship.Bottom && pb.Bottom >= 3 + ship.Bottom)
                        {
                            timer1.Enabled = false;
                            run = false;

                            player2.PlayLooping();
                            pictureBox1.Show();
                            timer2.Enabled = true;
                        }
                        if (pb.Bottom >= 3 + ship.Top && pb.Top + 3 <= ship.Top)
                        {
                            timer1.Enabled = false;
                            run = false;
                            player2.PlayLooping();
                            pictureBox1.Show();
                            timer2.Enabled = true;
                        }
                    }
                }
                foreach (PictureBox pb in pplist1)
                {
                    pb.Top = pb.Top + 5 + time / 30;
                    if (pb.Bottom >= ship.Top + 3 && pb.Top + 3 <= ship.Bottom)
                    {
                        if (pb.Right >= ship.Left + 3 && pb.Left + 3 <= ship.Left)
                        {
                            timer1.Enabled = false;
                            run = false;
                            player2.PlayLooping();
                            pictureBox1.Show();
                            timer2.Enabled = true;
                        }
                        if (pb.Left + 3 <= ship.Right && pb.Right >= 3 + ship.Right)
                        {
                            timer1.Enabled = false;
                            run = false;
                            player2.PlayLooping();
                            pictureBox1.Show();
                            timer2.Enabled = true;

                        }
                    }
                    if (pb.Left + 3 <= ship.Right && pb.Right >= 3 + ship.Left)
                    {
                        if (pb.Top + 3 <= ship.Bottom && pb.Bottom >= 3 + ship.Bottom)
                        {
                            timer1.Enabled = false;
                            run = false;
                            player2.PlayLooping();
                            pictureBox1.Show();
                            timer2.Enabled = true;
                        }
                        if (pb.Bottom >= 3 + ship.Top && pb.Top + 3 <= ship.Top)
                        {
                            timer1.Enabled = false;
                            run = false;
                            player2.PlayLooping();
                            pictureBox1.Show();
                            timer2.Enabled = true;
                        }
                    }
                }
            }
        }

        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            if (run == true)
            {
                if (e.KeyData == Keys.Up && ship.Top > 0)
                { ship.Top -= ship.Height / 4; }
                if (e.KeyData == Keys.Down && ship.Bottom < 600)
                { ship.Top += ship.Height / 2; }
                if (e.KeyData == Keys.Left && ship.Left > 0)
                { ship.Left -= ship.Width / 2; }
                if (e.KeyData == Keys.Right && ship.Right < 420)
                { ship.Left += ship.Width / 2; }
            }
        }

        private void ship_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bye++;
            if(bye==30)
            { Environment.Exit(Environment.ExitCode); }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
