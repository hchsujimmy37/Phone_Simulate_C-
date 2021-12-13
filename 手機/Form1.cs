using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 手機
{
    public partial class Form1 : Form
    {
        game game;
        Form4 f4;
        Form3 f3;
        Form2 f2;
        Form5 f5;
        music mc;
        Form6 f6;
        AppLock applock;
        sirisystem si;
        main mess=new main();
        int number = 0;
      
        public Form1(Form4 f4)
        {
            game game = new game(this);
            this.game = game;
            sirisystem si = new sirisystem(this);
            this.si = si;
            music mc = new music(this);
            this.mc = mc;
            Form3 f3 = new 手機.Form3(this);
            this.f3 = f3;
            Form2 f2 = new Form2(this);
            this.f2 = f2;
            this.f4 = f4;
            Form5 f5 = new Form5(this);
            this.f5 = f5;
            InitializeComponent();
            Form6 f6 = new 手機.Form6(this);
            this.f6 = f6;
            AppLock applock = new AppLock(this);
            this.applock = applock;
            timer1.Enabled=true;

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // 取消關閉作業
            Hide();          // 隱藏視窗
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            siri.Hide();
            siri.SizeMode = PictureBoxSizeMode.Zoom;
            speaking.SizeMode = PictureBoxSizeMode.Zoom;
            string tt;
            string date;
            date = DateTime.Now.ToShortDateString();
            tt = DateTime.Now.ToShortTimeString();
            time.Text = tt;
            label1.Text = date;
            phone.SizeMode = PictureBoxSizeMode.Zoom;
            mail.SizeMode = PictureBoxSizeMode.Zoom;
            media.SizeMode = PictureBoxSizeMode.Zoom;
            caculator.SizeMode = PictureBoxSizeMode.Zoom;
            
        }
       
        public void timer1_Tick(object sender, EventArgs e)
        {
            if(f4.which==3)
            {
                if (game.run == false)
                { number++; }
                if(number==100)
                {
                    MessageBox.Show("手機要爆炸了 躲過炸彈讓手機免於爆炸");
                    MessageBox.Show("用上下左右鍵來躲避炸彈");
                    game.run = true;
                    game.Show();
                }
            }
            if (f4.which==2)
            {
                siri.Show();
            }
            if (f4.which == 1)
            {
                number++;
                if (number %83==0&&number%2!=0)
                {
                    
                    f2.Show();
                }
                if (number%166==0)
                {

                    f5.Show();
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void caculator_Click(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.ncku.edu.tw/");
        }

        private void map_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.tw/maps/@23.546162,120.6402133,8z?hl=zh-TW");
        }

        private void media_Click(object sender, EventArgs e)
        {
            mc.Show();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
            timer1.Enabled = false;
            e.Cancel = true; // 取消關閉作業
            Environment.Exit(Environment.ExitCode);
        }

        private void speaking_Click(object sender, EventArgs e)
        {
            f6.Show();
        }

        private void speaking_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void speaking_MouseUp(object sender, MouseEventArgs e)
        {
         
        }

        private void mail_Click(object sender, EventArgs e)
        {
            mess.Show(this);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            siri.Image = Image.FromFile("./RED.png");
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            si.Show();
            siri.Image = Image.FromFile("./白點.png");
            
        }
        call cal = new call();
        private void phone_Click(object sender, EventArgs e)
        {
            cal.Show(this);
            Hide();
        }
        minesweeper ms = new minesweeper();
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            ms.Show(this);
            Hide();
        }
        MediaPlayer mp = new MediaPlayer();
        ImagePlayer ip = new ImagePlayer();
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            mp.Show(this);
            Hide();
        }

        private void MediaPlayer_Click(object sender, EventArgs e)
        {
            ip.Show(this);
            Hide();
        }

        private void LockBox_Click(object sender, EventArgs e)
        {
            applock.Show(this);
            Hide();
        }
    }
    }

