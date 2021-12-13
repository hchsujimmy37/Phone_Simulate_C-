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
    public partial class Form4 : Form
    {
        Form1 f1;
        public int which;
        public Form4()
        {
            Form1 f1 = new Form1(this);
            this.f1 = f1;
            InitializeComponent();
            oppo.SizeMode = PictureBoxSizeMode.Zoom;
            samsung.SizeMode = PictureBoxSizeMode.Zoom;
            apple.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            which = 1;
            this.Hide();
            f1.Show();
            
        }

        private void apple_Click(object sender, EventArgs e)
        {
            which = 2;
            this.Hide();
            f1.Show();
        }

        private void samsung_Click(object sender, EventArgs e)
        {
           
            which = 3;
            this.Hide();
            f1.Show();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
