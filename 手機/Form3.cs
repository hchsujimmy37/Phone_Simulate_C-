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
    public partial class Form3 : Form
    {
        public Form3(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }
        Form1 f1;
        string show = "";
        string temp = "";
        string before = "";
        double answer = 0;
        bool first = true;
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (before == "+")
            {
                answer = answer + Int32.Parse(temp);
            }
            if (before == "-")
            {
                answer = answer - Int32.Parse(temp);
            }
            if (before == "*")
            {
                answer = answer * Int32.Parse(temp);
            }
            if (before == "/")
            {
                answer = answer / Int32.Parse(temp);
            }
            if(before=="")
            {
                answer = Int32.Parse(temp);
            }
            answer = Math.Pow(answer, 0.5);
            show = answer.ToString();
            textBox1.Text = show;
            first = true;
            temp = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                temp = "1";
                show = "1";
                textBox1.Text = show;
            }
            else
            {
                temp += "1";
                show += "1";
                textBox1.Text = show;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                temp = "2";
                show = "2";
                textBox1.Text = show;
            }
            else
            {
                temp += "2";
                show += "2";
                textBox1.Text = show;
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                temp = "3";
                show = "3";
                textBox1.Text = show;
            }
            else
            {
                temp += "3";
                show += "3";
                textBox1.Text = show;
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                temp = "4";
                show = "4";
                textBox1.Text = show;
            }
            else
            {
                temp += "4";
                show += "4";
                textBox1.Text = show;
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                temp = "5";
                show = "5";
                textBox1.Text = show;
            }
            else
            {
                temp += "5";
                show += "5";
                textBox1.Text = show;
            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                temp = "6";
                show = "6";
                textBox1.Text = show;
            }
            else
            {
                temp += "6";
                show += "6";
                textBox1.Text = show;
            }
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                temp = "7";
                show = "7";
                textBox1.Text = show;
            }
            else
            {
                temp += "7";
                show += "7";
                textBox1.Text = show;
            }
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                temp = "8";
                show = "8";
                textBox1.Text = show;
            }
            else
            {
                temp += "8";
                show += "8";
                textBox1.Text = show;
            }
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                temp = "9";
                show = "9";
                textBox1.Text = show;
            }
            else
            {
                temp += "9";
                show += "9";
                textBox1.Text = show;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                temp += 0;
                show += 0;
                textBox1.Text = show;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (first == true)
            {
                before = "+";
                answer = Int32.Parse(temp);
                first = false;
                show += "+";
                textBox1.Text = show;
            }
            else
            {
                if (before == "+")
                {
                    answer = answer + Int32.Parse(temp);
                }
                if (before == "-")
                {
                    answer = answer - Int32.Parse(temp);
                }
                if (before == "*")
                {
                    answer = answer * Int32.Parse(temp);
                }
                if (before == "/")
                {
                    answer = answer / Int32.Parse(temp);
                }
                show = answer.ToString() + "+";
                textBox1.Text = show;
            }
            before = "+";
            temp = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (first == true)
            {
                before = "-";
                answer = Int32.Parse(temp);
                first = false;
                show += "-";
                textBox1.Text = show;
            }
            else
            {
                if (before == "+")
                {
                    answer = answer + Int32.Parse(temp);
                }
                if (before == "-")
                {
                    answer = answer - Int32.Parse(temp);
                }
                if (before == "*")
                {
                    answer = answer * Int32.Parse(temp);
                }
                if (before == "/")
                {
                    answer = answer / Int32.Parse(temp);
                }
                show = answer.ToString() + "-";
                textBox1.Text = show;
            }
            before = "-";
            temp = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (first == true)
            {
                before = "*";
                answer = Int32.Parse(temp);
                first = false;
                show += "*";
                textBox1.Text = show;
            }
            else
            {
                if (before == "+")
                {
                    answer = answer + Int32.Parse(temp);
                }
                if (before == "-")
                {
                    answer = answer - Int32.Parse(temp);
                }
                if (before == "*")
                {
                    answer = answer * Int32.Parse(temp);
                }
                if (before == "/")
                {
                    answer = answer / Int32.Parse(temp);
                }
                show = answer.ToString() + "*";
                textBox1.Text = show;
            }
            before = "*";
            temp = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (first == true)
            {
                before = "/";
                answer = Int32.Parse(temp);
                first = false;
                show += "/";
                textBox1.Text = show;
            }
            else
            {
                if (before == "+")
                {
                    answer = answer + Int32.Parse(temp);
                }
                if (before == "-")
                {
                    answer = answer - Int32.Parse(temp);
                }
                if (before == "*")
                {
                    answer = answer * Int32.Parse(temp);
                }
                if (before == "/")
                {
                    answer = answer / Int32.Parse(temp);
                }
                show = answer.ToString() + "/";
                textBox1.Text = show;
            }
            before = "/";
            temp = "";

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (first == true)
            {

                answer = Int32.Parse(temp);
                show = answer.ToString();
            }
            else
            {
                if (before == "+")
                {
                    answer = answer + Int32.Parse(temp);
                }
                if (before == "-")
                {
                    answer = answer - Int32.Parse(temp);
                }
                if (before == "*")
                {
                    answer = answer * Int32.Parse(temp);
                }
                if (before == "/")
                {
                    answer = answer / Int32.Parse(temp);
                }
                show = answer.ToString();
            }
            temp = answer.ToString();
            before = "";
            textBox1.Text = show;
            first = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            answer = 0;
            show = "0";
            temp = "";
            textBox1.Text = show;
            first = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // 取消關閉作業
            Hide();          // 隱藏視窗e.Cancel = true; // 取消關閉作業
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (before == "/")
            {
                answer = answer / Int32.Parse(temp);
            }
            answer = answer * 100;
            show = answer.ToString();
            textBox1.Text = show;
            first = true;
            temp = "";
        }
    }
    }

