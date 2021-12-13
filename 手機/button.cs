using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 手機
{
    public partial class button : Button
    {
        private int x;
        private int y;
        public button()
        {
            InitializeComponent();
            Tag = 0;
            Size = new System.Drawing.Size(30, 30);
        }
        private int is_bomb;
        public int X
        {
            get
            { return x; }
            set
            { x = value; }
        }
        public int Y
        {
            get
            { return y; }
            set
            { y = value; }
        }
        public int Youlei
        {
            get
            { return is_bomb; }
            set
            { is_bomb = value; }
        }
        public button(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
