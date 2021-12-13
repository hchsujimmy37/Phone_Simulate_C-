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
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 f1)
        {

            InitializeComponent();
            this.f1 = f1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // 取消關閉作業
            Hide();          // 隱藏視窗
        }
    }
    }

