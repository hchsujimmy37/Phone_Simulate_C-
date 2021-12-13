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
    public partial class setting : Form
    {
        private static int bomb_number = 99, row = 16, col = 30;
        public setting()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar == '\b'))
            { e.Handled = true; }

        }

        private void shezhi_Load(object sender, EventArgs e)
        {
            textBox1.Text = bomb_number.ToString();
            textBox2.Text = col.ToString();
            textBox3.Text = row.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("部分欄位未輸入值");
                textBox1.Focus();
                return;
            }
            if (int.Parse(textBox2.Text) * int.Parse(textBox3.Text) <= (int.Parse(textBox1.Text)))
            {
                MessageBox.Show("無法建立遊戲，因地雷數不可行");
                textBox1.Focus();
                return;
            }
            if (int.Parse(textBox1.Text) > 400 || int.Parse(textBox1.Text) < 10 || int.Parse(textBox2.Text) > 30 || int.Parse(textBox3.Text) > 16)
            {
                MessageBox.Show("地雷範圍為10-400，長最大16，寬最大30，請輸入正確數值");
                textBox1.Text = string.Empty; textBox2.Text = string.Empty; textBox3.Text = string.Empty;
            }
            else
            {
                Program.form.Leishu = int.Parse(textBox1.Text);
                Program.form.Lie = int.Parse(textBox2.Text);
                Program.form.Hang = int.Parse(textBox3.Text);
                bomb_number = int.Parse(textBox1.Text);
                col = int.Parse(textBox2.Text);
                row = int.Parse(textBox3.Text);
                Program.form.resetting();
                this.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.form.Leishu = 10;
            bomb_number = 10;
            Program.form.Lie = 8;
            col = 8;
            Program.form.Hang = 8;
            row = 8;
            Program.form.resetting();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.form.Leishu = 40;
            bomb_number = 40;
            Program.form.Lie = 16;
            col = 16;
            Program.form.Hang = 16;
            row = 16;
            Program.form.resetting();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.form.Leishu = 99;
            bomb_number = 99;
            Program.form.Lie = 30;
            col = 30;
            Program.form.Hang = 16;
            row = 16;
            Program.form.resetting();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form.Leishu = 99;
            bomb_number = 99;
            Program.form.Lie = 30;
            col = 30;
            Program.form.Hang = 16;
            row = 16;
            Program.form.resetting();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
