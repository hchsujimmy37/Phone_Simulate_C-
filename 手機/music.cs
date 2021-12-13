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
    public partial class music : Form
    {
        Form1 f1;
        public music(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        string name="awaken";
        SoundPlayer player1;
        TrackBar[] track = new TrackBar[10];
        PictureBox[] pp1 = new PictureBox[17];
        PictureBox[] pp2 = new PictureBox[17];
        PictureBox[] pp3 = new PictureBox[17];
        PictureBox[] pp4 = new PictureBox[17];
        PictureBox[] pp5 = new PictureBox[17];
        PictureBox[] pp6 = new PictureBox[17];
        PictureBox[] pp7 = new PictureBox[17];
        PictureBox[] pp8 = new PictureBox[17];
        PictureBox[] pp9 = new PictureBox[17];
        PictureBox[] pp10 = new PictureBox[17];
        int score = 0;//score要設在外面  time裡的才會跑

        private void button1_Click(object sender, EventArgs e)
        {
            player1.PlayLooping();
            timer1.Enabled = true;
            for (int i = 8; i < 17; i++)
            {
                pp1[i].Hide();
                pp2[i].Hide();
                pp3[i].Hide();
                pp4[i].Hide();
                pp5[i].Hide();
                pp6[i].Hide();
                pp7[i].Hide();
                pp8[i].Hide();
                pp9[i].Hide();
                pp10[i].Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             player1 = new SoundPlayer("./" + name + ".wav");
            timer1.Enabled = false;
            tkbR.Minimum = 0;
            tkbG.Minimum = 0;
            tkbB.Minimum = 0;
            tkbR.Maximum = 255;
            tkbB.Maximum = 255;
            tkbG.Maximum = 255;
            tkbR.Value = 128; //設定各滑動軸初值
            tkbG.Value = 128;
            tkbB.Value = 128;
            lblcolor.BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
            for (int i = 0; i < 17; i++)
            {
                pp1[i] = new PictureBox();
                pp2[i] = new PictureBox();
                pp3[i] = new PictureBox();
                pp4[i] = new PictureBox();
                pp5[i] = new PictureBox();
                pp6[i] = new PictureBox();
                pp7[i] = new PictureBox();
                pp8[i] = new PictureBox();
                pp9[i] = new PictureBox();
                pp10[i] = new PictureBox();
                pp1[i].Size = new Size(54, 10);
                pp1[i].Location = new Point(12, 235 - i * 14);
                pp1[i].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                tabPage1.Controls.Add(pp1[i]);
                pp2[i].Size = new Size(54, 10);
                pp2[i].Location = new Point(82, 235 - i * 14);
                pp2[i].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                tabPage1.Controls.Add(pp2[i]);
                pp3[i].Size = new Size(54, 10);
                pp3[i].Location = new Point(152, 235 - i * 14);
                pp3[i].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                tabPage1.Controls.Add(pp3[i]);
                pp4[i].Size = new Size(54, 10);
                pp4[i].Location = new Point(222, 235 - i * 14);
                pp4[i].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                tabPage1.Controls.Add(pp4[i]);
                pp5[i].Size = new Size(54, 10);
                pp5[i].Location = new Point(292, 235 - i * 14);
                pp5[i].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                tabPage1.Controls.Add(pp5[i]);
                pp6[i].Size = new Size(54, 10);
                pp6[i].Location = new Point(362, 235 - i * 14);
                pp6[i].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                tabPage1.Controls.Add(pp6[i]);
                pp7[i].Size = new Size(54, 10);
                pp7[i].Location = new Point(432, 235 - i * 14);
                pp7[i].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                tabPage1.Controls.Add(pp7[i]);
                pp8[i].Size = new Size(54, 10);
                pp8[i].Location = new Point(502, 235 - i * 14);
                pp8[i].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                tabPage1.Controls.Add(pp8[i]);
                pp9[i].Size = new Size(54, 10);
                pp9[i].Location = new Point(572, 235 - i * 14);
                pp9[i].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                tabPage1.Controls.Add(pp9[i]);
                pp10[i].Size = new Size(54, 10);
                pp10[i].Location = new Point(642, 235 - i * 14);
                pp10[i].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                tabPage1.Controls.Add(pp10[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                track[i] = new TrackBar();
                track[i].TickStyle = TickStyle.Both;
                track[i].Orientation = Orientation.Vertical;
                track[i].Location = new Point(17 + 70 * i, 250);
                track[i].Size = new Size(69, 184);
                track[i].Minimum = 4;
                track[i].Maximum = 15;
                tabPage1.Controls.Add(track[i]);
                track[i].Value = 8;
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lblcolor.BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
        }

        private void tkbG_Scroll(object sender, ScrollEventArgs e)
        {
            lblcolor.BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
        }

        private void tkbB_Scroll(object sender, ScrollEventArgs e)
        {
            lblcolor.BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int d = 0; d < 17; d++)
            {
                pp1[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp2[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp3[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp4[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp5[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp6[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp7[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp8[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp9[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp10[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
            }
            score++;
            for (int i = 0; i < 10; i++)
            {
                if (i == 8)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp9[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp9[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp9[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp9[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp9[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp9[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp9[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp9[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp9[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 7)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp8[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp8[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp8[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp8[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp8[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp8[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp8[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp8[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp8[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 6)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp7[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp7[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp7[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp7[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp7[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp7[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp7[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp7[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp7[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 9)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp10[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp10[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp10[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp10[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp10[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp10[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp10[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp10[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp10[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 5)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp6[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp6[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp6[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp6[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp6[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp6[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp6[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp6[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp6[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 4)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp5[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp5[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp5[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp5[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp5[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp5[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp5[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp5[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp5[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 3)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp4[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp4[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp4[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp4[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp4[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp4[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp4[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp4[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp4[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 2)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp3[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp3[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp3[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp3[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp3[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp3[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp3[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp3[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp3[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 1)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp2[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp2[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp2[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp2[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp2[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp2[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp2[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp2[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp2[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 0)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp1[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp1[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp1[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp1[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp1[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp1[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp1[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp1[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp1[m - 2].Show();
                            }
                        }

                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            player1.Stop();
        }

   

private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            player1 = new SoundPlayer("./music/" + name + ".wav");
            player1.PlayLooping();
            timer1.Enabled = true;
            for (int i = 8; i < 17; i++)
            {
                pp1[i].Hide();
                pp2[i].Hide();
                pp3[i].Hide();
                pp4[i].Hide();
                pp5[i].Hide();
                pp6[i].Hide();
                pp7[i].Hide();
                pp8[i].Hide();
                pp9[i].Hide();
                pp10[i].Hide();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            player1.Stop();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            for (int d = 0; d < 17; d++)
            {
                pp1[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp2[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp3[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp4[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp5[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp6[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp7[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp8[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp9[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
                pp10[d].BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
            }
            score++;
            for (int i = 0; i < 10; i++)
            {
                if (i == 8)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp9[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp9[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp9[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp9[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp9[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp9[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp9[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp9[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp9[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 7)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp8[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp8[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp8[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp8[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp8[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp8[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp8[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp8[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp8[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 6)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp7[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp7[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp7[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp7[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp7[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp7[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp7[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp7[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp7[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 9)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp10[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp10[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp10[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp10[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp10[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp10[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp10[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp10[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp10[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 5)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp6[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp6[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp6[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp6[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp6[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp6[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp6[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp6[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp6[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 4)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp5[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp5[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp5[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp5[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp5[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp5[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp5[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp5[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp5[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 3)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp4[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp4[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp4[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp4[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp4[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp4[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp4[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp4[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp4[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 2)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp3[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp3[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp3[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp3[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp3[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp3[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp3[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp3[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp3[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 1)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp2[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp2[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp2[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp2[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp2[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp2[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp2[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp2[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp2[m - 2].Show();
                            }
                        }
                    }
                }
                if (i == 0)
                {
                    for (int m = 4; m < 16; m++)
                    {
                        if (track[i].Value == m)
                        {
                            for (int k = m + 2; k < 17; k++)
                            {
                                pp1[k].Hide();
                            }
                            if (score % 8 == 0)
                            {
                                for (int n = 2; n < m; n++)
                                {
                                    pp1[n].Show();
                                }
                            }
                            if (score % 8 == 1)
                            {
                                pp1[m].Show();
                            }
                            if (score % 8 == 2)
                            {
                                pp1[m + 1].Show();
                            }
                            if (score % 8 == 3)
                            {
                                pp1[m + 1].Hide();
                            }
                            if (score % 8 == 4)
                            {
                                pp1[m].Hide();
                            }
                            if (score % 8 == 5)
                            {
                                pp1[m - 1].Hide();
                            }
                            if (score % 8 == 6)
                            {
                                pp1[m - 2].Hide();
                            }
                            if (score % 8 == 7)
                            {
                                pp1[m - 2].Show();
                            }
                        }

                    }
                }
            }
        }

        private void tkbR_Scroll(object sender, ScrollEventArgs e)
        {
            lblcolor.BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
        }

        private void tkbG_Scroll_1(object sender, ScrollEventArgs e)
        {
            lblcolor.BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
        }

        private void tkbB_Scroll_1(object sender, ScrollEventArgs e)
        {
            lblcolor.BackColor = Color.FromArgb(tkbR.Value, tkbG.Value, tkbB.Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = comboBox1.Text;
          player1 = new SoundPlayer("./music/"+name+".wav");
        }

        private void music_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // 取消關閉作業
            Hide();          // 隱藏視窗
        }
    }
    }
