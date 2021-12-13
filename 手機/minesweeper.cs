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
    public partial class minesweeper : Form
    {
        public minesweeper()
        {
            InitializeComponent();
        }
        private string p_ask = System.Environment.CurrentDirectory + "\\image\\ask.bmp";
        private string p_face = System.Environment.CurrentDirectory + "\\image\\face.bmp";
        private string siqu = System.Environment.CurrentDirectory + "\\image\\sile.jpg";
        private string shengli = System.Environment.CurrentDirectory + "\\image\\烟花.wav";
        private string shengyin = System.Environment.CurrentDirectory + "\\image\\爆炸声.wav";
        private string shibai = System.Environment.CurrentDirectory + "\\image\\shibai.bmp";
        private string flag = System.Environment.CurrentDirectory + "\\image\\flag.bmp";
        private string dileiimage = System.Environment.CurrentDirectory + "\\imag\\lei.bmp";
        private Timer timer1 = new Timer();
        private int time_play = 0;
        private int bomb = 99;
        private bool over = false;
        private int mine_row = 16;
        private int mine_col = 30;
        private int remain;

        public int Leishu
        {
            get
            { return bomb; }
            set
            {
                bomb = value;
            }

        }
        public int Hang
        {
            get
            { return mine_row; }
            set
            {
                mine_row = value;
            }
        }
        public int Lie
        {
            get
            { return mine_col; }
            set
            {
                mine_col = value;
            }
        }

        public button[,] button = new button[16, 30];


        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 設置地雷數ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting shezhi1 = new setting();
            shezhi1.ShowDialog();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Image = Image.FromFile(p_face);
            Program.form = this; remain = Leishu;
            label4.Text = "";
            groupBox1.Location = new Point(26, 26);
            groupBox1.Text = "";
            groupBox1.Size = new System.Drawing.Size(908, 488);
            groupBox1.FlatStyle = FlatStyle.Standard;
            lei.Text = "剩餘" + remain.ToString() + "顆";
            this.Location = new Point(20, 20);
            timer1.Enabled = true;
            Leizheng();
            Bulei();
            this.StartPosition = FormStartPosition.Manual;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time_play++;
            if (time_play < 60)
                label4.Text = time_play.ToString() + "秒";
            else
                label4.Text = (time_play / 60).ToString() + "分" + (time_play % 60).ToString() + "秒";

        }
        private void Leizheng()
        {
            for (int i = 0; i < mine_col; i++)
            {
                for (int j = 0; j < mine_row; j++)
                {
                    button[j, i] = new button();
                    button[j, i].Location = new Point(3 + i * 30, 6 + j * 30);
                    button[j, i].X = j;
                    button[j, i].Y = i;
                    button[j, i].Youlei = 0;
                    button[j, i].Font = new System.Drawing.Font("宋体", button[j, i].Font.Size, button[j, i].Font.Style);


                    groupBox1.Controls.Add(button[j, i]);
                    button[j, i].MouseUp += new MouseEventHandler(bt_MouseUp);
                }
            }
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (i >= mine_row || j >= mine_col)
                    {
                        button[i, j].Enabled = false;
                        button[i, j].Visible = false;
                    }
                    else
                    {
                        button[i, j].Enabled = true;
                        button[i, j].Visible = true;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            resetting();
        }
        private void bt_MouseUp(object sender, MouseEventArgs e)
        {
            if (!over)
            {
                int x, y;
                button b = (button)sender;
                x = b.X;
                y = b.Y;
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        if (Convert.ToInt16(button[x, y].Tag) == 0)
                        {
                            if (button[x, y].Youlei == 0)
                            {
                                button[x, y].Enabled = false;
                                button[x, y].Text = Getdilei(x, y).ToString();
                                Saolei(x, y);
                                if (Win())
                                {

                                    Showlei();
                                    timer1.Enabled = false;
                                    SoundPlayer sound = new SoundPlayer(shengli);
                                    sound.Play();
                                    MessageBox.Show("恭喜你獲勝了！", "成功");
                                    over = true;
                                }

                            }
                            else
                            {
                                button[x, y].BackgroundImage = Image.FromFile(shibai);
                                SoundPlayer sound = new SoundPlayer(shengyin);
                                sound.Play();
                                timer1.Enabled = false;
                                b.Enabled = false;
                                b.BackgroundImage = Image.FromFile(shibai);
                                xianshi();
                                button1.Image = Image.FromFile(siqu);
                                button1.ImageAlign = ContentAlignment.MiddleRight;
                                MessageBox.Show("很可惜，你輸了！", "失敗");

                                over = true;

                            }
                        }
                        break;
                    case MouseButtons.Right:

                        if (Convert.ToInt16(button[x, y].Tag) == 1)
                        {
                            button[x, y].Tag = 2;
                            button[x, y].BackgroundImage = Image.FromFile(p_ask);

                        }
                        else if (Convert.ToInt16(button[x, y].Tag) == 2)
                        {
                            button[x, y].Tag = 0;
                            remain++;
                            button[x, y].BackgroundImage = null;
                        }
                        else
                        {
                            button[x, y].Tag = 1;
                            button[x, y].BackgroundImage = Image.FromFile(flag);
                            remain--;

                        }
                        lei.Text = "剩餘" + remain.ToString() + "顆";
                        if (Win())
                        {
                            SoundPlayer sound = new SoundPlayer(shengli);
                            sound.Play();
                            MessageBox.Show("恭喜你獲勝了!!", "成功");
                            timer1.Enabled = false;
                            over = true;
                        }
                        break;

                }
            }
            else
                return;


        }
        private void Bulei()
        {
            Random rand = new Random();
            for (int i = 0; i < bomb; i++)
            {

                int position_x = rand.Next(mine_row);
                int position_y = rand.Next(mine_col);
                if (button[position_x, position_y].Youlei == 0)
                {
                    button[position_x, position_y].Youlei = 1;

                }
                else
                    i = i - 1;
            }

        }
        private int Getdilei(int row, int col)
        {
            int i, j;
            int around = 0;
            int minRow = (row == 0) ? 0 : row - 1;
            int maxRow = row + 2;
            int minCol = (col == 0) ? 0 : col - 1;
            int maxCol = col + 2;
            for (i = minRow; i < maxRow; i++)
            {
                for (j = minCol; j < maxCol; j++)
                {
                    if (!(i >= 0 && i < mine_row && j >= 0 && j < mine_col))
                        continue;
                    if (button[i, j].Youlei == 1) around++;
                }
            }
            return around;
        }
        private void Saolei(int row, int col)

        {

            int minrow1 = (row == 0) ? 0 : row - 1;
            int mincol1 = (col == 0) ? 0 : col - 1;
            int maxrow1 = row + 2;
            int maxcol1 = col + 2;
            int leishuliang = Getdilei(row, col);
            if (leishuliang == 0)
            {
                button[row, col].Enabled = false;
                for (int m = minrow1; m < maxrow1; m++)
                {
                    for (int n = mincol1; n < maxcol1; n++)
                    {
                        if (!(m >= 0 && m < mine_row && n >= 0 && n < mine_col))
                            continue;
                        if (!(m == row && n == col) && button[m, n].Enabled == true && Convert.ToInt16(button[m, n].Tag) == 0)
                            Saolei(m, n);
                        if (Convert.ToInt16(button[m, n].Tag) == 0)
                            button[m, n].Enabled = false;
                        button[m, n].Text = Getdilei(m, n).ToString();
                        if (button[m, n].Text == "0")
                            button[m, n].Text = string.Empty;
                    }

                }
            }

        }
        private bool Win()
        {
            int zongshu = 0;
            for (int i = 0; i < mine_row; i++)
            {
                for (int j = 0; j < mine_col; j++)
                {
                    if (button[i, j].Youlei == 1 && Convert.ToInt16(button[i, j].Tag) == 1)
                        zongshu++;

                }

            }
            if (zongshu == bomb && remain == 0)
                return true;
            else
                return false;

        }

        private void Showlei()
        {
            for (int i = 0; i < mine_row; i++)
            {
                for (int j = 0; j < mine_col; j++)
                    if (button[i, j].Youlei == 1)
                    {

                        button[i, j].BackgroundImage = Image.FromFile(dileiimage);
                    }

            }

        }

        private void xianshi()
        {
            int l = 0;
            for (int i = 0; i < mine_row; i++)
            {
                for (int j = 0; j < mine_col; j++)
                {
                    if (button[i, j].Youlei == 1)
                    {
                        button[i, j].BackgroundImage = Image.FromFile(shibai);
                        l++;
                    }
                }
            }

        }

        public void resetting()
        {
            for (int i = 0; i < mine_row; i++)
            {
                for (int j = 0; j < mine_col; j++)
                {
                    button[i, j].Tag = 0;
                    button[i, j].Enabled = true;
                    button[i, j].Text = string.Empty;
                    button[i, j].BackgroundImage = null;
                    if (button[i, j].Youlei == 1)
                        button[i, j].Youlei = 0;
                }

            }
            Bulei();
            time_play = 0;
            over = false;
            remain = bomb;
            lei.Text = "剩餘  " + remain.ToString() + "顆";
            button1.Image = Image.FromFile(p_face);
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (i >= mine_row || j >= mine_col)
                    {
                        button[i, j].Enabled = false;
                        button[i, j].Visible = false;
                    }
                    else
                    {
                        button[i, j].Enabled = true;
                        button[i, j].Visible = true;
                    }
                }
            }

        }

        private void 關於此遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("圖片、部分原始碼:www.manongjc.com/article/42633.html", "來源");
        }

        private void 遊戲規則ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string messagestring = "遊戲說明:";
            messagestring += "1、左鍵點選不是地雷的格子。\n";
            messagestring += "2、右鍵以旗子標是地雷。\n";
            messagestring += "3、出現的數字表示當格周圍有幾個地雷";
            MessageBox.Show(messagestring, "說明");
        }

        private void 遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void 遊戲ToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void 協助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void 協助ToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            timer1.Start();
        }
        bool time_stop = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (time_stop == false)
            {
                timer1.Stop();
                MessageBox.Show("時間已經成功暫停");
                time_stop = true;
                button2.Text = "resume";
            }
            else
            {
                timer1.Start();
                time_stop = false;
                button2.Text = "stop";
            }
        }

        private void minesweeper_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            e.Cancel = true;
            Hide();
            f1.Show();

        }
    }
}
