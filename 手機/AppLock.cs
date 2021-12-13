using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace 手機
{
    public partial class AppLock : Form
    {
        private Form1 form1;
        private bool[] isSelect = new bool[9] { false, false, false, false, false, false, false, false, false };
        private int[] order = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private PictureBox[] AllLock = new PictureBox[9];
        private int times = 0;
        private int[,] ZeroCross = new int[4, 4] { { 0, 2, 6, 8 }, { 2, 0, 6, 8 }, { 6, 0, 2, 8 }, { 8, 0, 6, 2 } };
        private int[,] OneCross = new int[4, 2] { { 1, 7 }, { 3, 5 }, { 5, 3 }, { 7, 1 } };
        private bool IsStart = false;
        private bool IsReset = false;
        private bool isEnter = false;
        private int enter_times = 0;
        public AppLock(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            AllLock[0] = pictureBox1;
            AllLock[1] = pictureBox2;
            AllLock[2] = pictureBox3;
            AllLock[3] = pictureBox4;
            AllLock[4] = pictureBox5;
            AllLock[5] = pictureBox6;
            AllLock[6] = pictureBox7;
            AllLock[7] = pictureBox8;
            AllLock[8] = pictureBox9;
        }

        private void AppLock_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            FindStart(0, isSelect[0]);
            IsReset = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            FindStart(1, isSelect[1]);
            IsReset = false;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            FindStart(2, isSelect[2]);
            IsReset = false;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            FindStart(3, isSelect[3]);
            IsReset = false;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            FindStart(4, isSelect[4]);
            IsReset = false;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            FindStart(5, isSelect[5]);
            IsReset = false;
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            FindStart(6, isSelect[6]);
            IsReset = false;
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            FindStart(7, isSelect[7]);
            IsReset = false;
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            IsReset = false;
            FindStart(8, isSelect[8]);

        }
        private void DrawBorder(int number, bool selected, bool reset)
        {
            if (selected == false && reset == false)
            {
                isSelect[number] = true;
                System.Drawing.Graphics oGraphics = AllLock[number].CreateGraphics();
                oGraphics.DrawEllipse(new Pen(Color.Red, 4), 0, 0, AllLock[number].Width, AllLock[number].Height);
                times += 1;
                order[number] = times;
            }

            if (reset == true)
            {
                System.Drawing.Graphics oGraphics = AllLock[number].CreateGraphics();
                oGraphics.DrawEllipse(new Pen(Color.White, 4), 0, 0, AllLock[number].Width, AllLock[number].Height);

            }
        }
        private void FindStart(int number, bool selected)
        {
            IsReset = false;
            if (IsStart == false)
            {
                IsStart = true;
                DrawBorder(number, isSelect[number], IsReset);
            }

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            IsReset = false;
            if (IsStart)
            {
                DrawBorder(0, isSelect[0], IsReset);
            }
            DrawLine(Color.Red);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            IsReset = false;
            if (IsStart)
            {
                DrawBorder(1, isSelect[1], IsReset);
            }
            DrawLine(Color.Red);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            IsReset = false;
            if (IsStart)
            {
                DrawBorder(2, isSelect[2], IsReset);
            }
            DrawLine(Color.Red);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            IsReset = false;
            if (IsStart)
            {
                DrawBorder(3, isSelect[3], IsReset);
            }
            DrawLine(Color.Red);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            IsReset = false;
            if (IsStart)
            {
                DrawBorder(4, isSelect[4], IsReset);
            }
            DrawLine(Color.Red);
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            IsReset = false;
            if (IsStart)
            {
                DrawBorder(5, isSelect[5], IsReset);
            }
            DrawLine(Color.Red);
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            IsReset = false;
            if (IsStart)
            {
                DrawBorder(6, isSelect[6], IsReset);
            }
            DrawLine(Color.Red);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            IsReset = false;
            if (IsStart)
            {
                DrawBorder(7, isSelect[7], IsReset);
            }
            DrawLine(Color.Red);
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            IsReset = false;
            if (IsStart)
            {
                DrawBorder(8, isSelect[8], IsReset);
            }
            DrawLine(Color.Red);
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            IsStart = false;
            IsReset = true;
            times = 0;
            for (int i = 0; i < 9; ++i)
            {
                isSelect[i] = false;
                order[i] = 0;
                DrawBorder(i, isSelect[i], IsReset);
            }
            ClearLine();
        }
        private void DrawLine(Color color)
        {
            int i = 1;
            while (i < times)
            {
                for (int j = 0; j < 9; ++j)
                {
                    for (int k = 0; k < 9; ++k)
                    {
                        if (order[j] == i && order[k] == i + 1)
                        {
                            Graphics g = this.CreateGraphics();
                            g.DrawLine(new Pen(color, 4), AllLock[j].Location.X + AllLock[j].Width / 2, AllLock[j].Location.Y + AllLock[j].Height / 2, AllLock[k].Location.X + AllLock[k].Width / 2, AllLock[k].Location.Y + AllLock[k].Height / 2);
                        }
                    }
                }
                i += 1;
            }
        }
        private void ClearLine()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
        }
        private void Enter_btn_Click(object sender, EventArgs e)
        {
            IsStart = false;
            if (times < 4)
            {
                MessageBox.Show(this, "請輸入4個點以上");
                label1.Text = "請新增圖形驗證碼";
                EnterClear();
                isEnter = false;
                times = 0;
                enter_times = 0;
            }
            else if (times >= 4 && enter_times == 0)
            {
                times = 0;
                enter_times += 1;
                label1.Text = "請輸入圖形驗證碼";
                int sort = 1;
                StreamWriter str = new StreamWriter("./Lock.txt");
                while (sort <= order.Max())
                {
                    int index = order.ToList().IndexOf(sort);
                    str.WriteLine(index.ToString());
                    sort += 1;
                }
                EnterClear();
                isEnter = true;
                str.Close();
                Reset_btn.Hide();
                isEnter = false;
                times = 0;
            }
            else if (enter_times>0 && times >3) {
                times = 0;
                StreamReader str = new StreamReader("./Lock.txt");
                int sort = 1;
                int[] compare = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                string line = "";
                while ((line=str.ReadLine()) != null) {
                    
                    compare[Int32.Parse(line)] = sort;
                    sort += 1;
                }
                int compare_times = 0;
                for (int i = 0; i< 9; ++i) {
                    if (order[i] != compare[i])
                    {
                        continue;
                    }
                    else {
                        compare_times += 1;
                    }
                }
                if (compare_times == 9)
                {
                    MessageBox.Show("Success");
                    EnterClear();
                    form1.Show();
                    Hide();
                }
                else {
                    MessageBox.Show("Fail");
                    EnterClear();
                }
                
            }

        }
        private void EnterClear()
        {
            isEnter = true;
            IsReset = false;
            ClearLine();
            for (int i = 0; i < 9; ++i)
            {
                isSelect[i] = true;
                order[i] = 0;
                DrawBorder(i, isSelect[i], isEnter);
                isSelect[i] = false;
            }
            
        }

        private void AppLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            e.Cancel = true;
            MessageBox.Show("請先繪製圖形");
        }
    }
}
