namespace 手機
{
    partial class minesweeper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設置地雷數ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.協助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於此遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.遊戲規則ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.lei = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.遊戲ToolStripMenuItem,
            this.協助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 遊戲ToolStripMenuItem
            // 
            this.遊戲ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.遊戲ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設置地雷數ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.遊戲ToolStripMenuItem.Name = "遊戲ToolStripMenuItem";
            this.遊戲ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.遊戲ToolStripMenuItem.Text = "遊戲";
            this.遊戲ToolStripMenuItem.DropDownClosed += new System.EventHandler(this.遊戲ToolStripMenuItem_DropDownClosed);
            this.遊戲ToolStripMenuItem.Click += new System.EventHandler(this.遊戲ToolStripMenuItem_Click);
            // 
            // 設置地雷數ToolStripMenuItem
            // 
            this.設置地雷數ToolStripMenuItem.Image = global::手機.Properties.Resources.mine1_jpg;
            this.設置地雷數ToolStripMenuItem.Name = "設置地雷數ToolStripMenuItem";
            this.設置地雷數ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.設置地雷數ToolStripMenuItem.Text = "設置地雷數";
            this.設置地雷數ToolStripMenuItem.Click += new System.EventHandler(this.設置地雷數ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 協助ToolStripMenuItem
            // 
            this.協助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.關於此遊戲ToolStripMenuItem,
            this.遊戲規則ToolStripMenuItem});
            this.協助ToolStripMenuItem.Name = "協助ToolStripMenuItem";
            this.協助ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.協助ToolStripMenuItem.Text = "協助";
            this.協助ToolStripMenuItem.DropDownClosed += new System.EventHandler(this.協助ToolStripMenuItem_DropDownClosed);
            this.協助ToolStripMenuItem.Click += new System.EventHandler(this.協助ToolStripMenuItem_Click);
            // 
            // 關於此遊戲ToolStripMenuItem
            // 
            this.關於此遊戲ToolStripMenuItem.Image = global::手機.Properties.Resources.mine1_jpg;
            this.關於此遊戲ToolStripMenuItem.Name = "關於此遊戲ToolStripMenuItem";
            this.關於此遊戲ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.關於此遊戲ToolStripMenuItem.Text = "關於踩地雷";
            this.關於此遊戲ToolStripMenuItem.Click += new System.EventHandler(this.關於此遊戲ToolStripMenuItem_Click);
            // 
            // 遊戲規則ToolStripMenuItem
            // 
            this.遊戲規則ToolStripMenuItem.Image = global::手機.Properties.Resources.bangzhu;
            this.遊戲規則ToolStripMenuItem.Name = "遊戲規則ToolStripMenuItem";
            this.遊戲規則ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.遊戲規則ToolStripMenuItem.Text = "查看幫助";
            this.遊戲規則ToolStripMenuItem.Click += new System.EventHandler(this.遊戲規則ToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 2;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(1024, 124);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(0, 12);
            this.timelabel.TabIndex = 3;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(1098, 112);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 12);
            this.time.TabIndex = 5;
            // 
            // lei
            // 
            this.lei.AutoSize = true;
            this.lei.Location = new System.Drawing.Point(989, 277);
            this.lei.Name = "lei";
            this.lei.Size = new System.Drawing.Size(0, 12);
            this.lei.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(994, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(37, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(996, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 35);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::手機.Properties.Resources.mine1_jpg;
            this.pictureBox2.Location = new System.Drawing.Point(996, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::手機.Properties.Resources.shizhong;
            this.pictureBox1.Location = new System.Drawing.Point(996, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(991, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lei);
            this.Controls.Add(this.time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1100, 600);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "minesweeper";
            this.Text = "踩地雷";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.minesweeper_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設置地雷數ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 協助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於此遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 遊戲規則ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label lei;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}