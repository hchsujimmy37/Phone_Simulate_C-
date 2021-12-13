namespace 手機
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.PictureBox();
            this.mail = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.media = new System.Windows.Forms.PictureBox();
            this.caculator = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.map = new System.Windows.Forms.PictureBox();
            this.speaking = new System.Windows.Forms.PictureBox();
            this.siri = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MediaPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.LockBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caculator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speaking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockBox)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("標楷體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time.ForeColor = System.Drawing.Color.Black;
            this.time.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.time.Location = new System.Drawing.Point(39, 19);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(226, 64);
            this.time.TabIndex = 0;
            this.time.Text = "label1";
            this.time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.time.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(116, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // phone
            // 
            this.phone.Image = global::手機.Properties.Resources.圖片1;
            this.phone.Location = new System.Drawing.Point(21, 415);
            this.phone.Margin = new System.Windows.Forms.Padding(2);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(46, 41);
            this.phone.TabIndex = 2;
            this.phone.TabStop = false;
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // mail
            // 
            this.mail.Image = global::手機.Properties.Resources.圖片2;
            this.mail.Location = new System.Drawing.Point(102, 415);
            this.mail.Margin = new System.Windows.Forms.Padding(2);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(46, 41);
            this.mail.TabIndex = 3;
            this.mail.TabStop = false;
            this.mail.Click += new System.EventHandler(this.mail_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // media
            // 
            this.media.BackgroundImage = global::手機.Properties.Resources._80574678_776307826177032_3000502030302183424_n;
            this.media.Image = global::手機.Properties.Resources.圖片3;
            this.media.Location = new System.Drawing.Point(123, 195);
            this.media.Margin = new System.Windows.Forms.Padding(2);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(36, 34);
            this.media.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.media.TabIndex = 4;
            this.media.TabStop = false;
            this.media.Click += new System.EventHandler(this.media_Click);
            // 
            // caculator
            // 
            this.caculator.BackgroundImage = global::手機.Properties.Resources.background;
            this.caculator.Image = global::手機.Properties.Resources.圖片4;
            this.caculator.Location = new System.Drawing.Point(49, 193);
            this.caculator.Margin = new System.Windows.Forms.Padding(2);
            this.caculator.Name = "caculator";
            this.caculator.Size = new System.Drawing.Size(36, 37);
            this.caculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caculator.TabIndex = 6;
            this.caculator.TabStop = false;
            this.caculator.Click += new System.EventHandler(this.caculator_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::手機.Properties.Resources._80574678_776307826177032_3000502030302183424_n;
            this.pictureBox1.Image = global::手機.Properties.Resources.google;
            this.pictureBox1.Location = new System.Drawing.Point(242, 422);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::手機.Properties.Resources._80574678_776307826177032_3000502030302183424_n;
            this.pictureBox2.Image = global::手機.Properties.Resources.facebook;
            this.pictureBox2.Location = new System.Drawing.Point(242, 195);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::手機.Properties.Resources._80574678_776307826177032_3000502030302183424_n;
            this.pictureBox3.Image = global::手機.Properties.Resources.成功;
            this.pictureBox3.Location = new System.Drawing.Point(49, 253);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // map
            // 
            this.map.BackgroundImage = global::手機.Properties.Resources._80574678_776307826177032_3000502030302183424_n;
            this.map.Image = global::手機.Properties.Resources.map;
            this.map.Location = new System.Drawing.Point(123, 253);
            this.map.Margin = new System.Windows.Forms.Padding(2);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(36, 34);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map.TabIndex = 10;
            this.map.TabStop = false;
            this.map.Click += new System.EventHandler(this.map_Click);
            // 
            // speaking
            // 
            this.speaking.BackgroundImage = global::手機.Properties.Resources._80574678_776307826177032_3000502030302183424_n;
            this.speaking.Image = global::手機.Properties.Resources.chatting1;
            this.speaking.Location = new System.Drawing.Point(242, 253);
            this.speaking.Margin = new System.Windows.Forms.Padding(2);
            this.speaking.Name = "speaking";
            this.speaking.Size = new System.Drawing.Size(36, 34);
            this.speaking.TabIndex = 11;
            this.speaking.TabStop = false;
            this.speaking.Click += new System.EventHandler(this.speaking_Click);
            this.speaking.MouseDown += new System.Windows.Forms.MouseEventHandler(this.speaking_MouseDown);
            this.speaking.MouseUp += new System.Windows.Forms.MouseEventHandler(this.speaking_MouseUp);
            // 
            // siri
            // 
            this.siri.BackgroundImage = global::手機.Properties.Resources._80574678_776307826177032_3000502030302183424_n;
            this.siri.Image = global::手機.Properties.Resources.白點;
            this.siri.Location = new System.Drawing.Point(183, 367);
            this.siri.Margin = new System.Windows.Forms.Padding(2);
            this.siri.Name = "siri";
            this.siri.Size = new System.Drawing.Size(33, 30);
            this.siri.TabIndex = 12;
            this.siri.TabStop = false;
            this.siri.Click += new System.EventHandler(this.pictureBox4_Click);
            this.siri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            this.siri.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::手機.Properties.Resources._80574678_776307826177032_3000502030302183424_n;
            this.pictureBox4.Image = global::手機.Properties.Resources.mine;
            this.pictureBox4.Location = new System.Drawing.Point(315, 253);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.BackgroundImage = global::手機.Properties.Resources._80574678_776307826177032_3000502030302183424_n;
            this.MediaPlayer.Image = global::手機.Properties.Resources.小話家;
            this.MediaPlayer.Location = new System.Drawing.Point(315, 422);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.Size = new System.Drawing.Size(36, 34);
            this.MediaPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MediaPlayer.TabIndex = 14;
            this.MediaPlayer.TabStop = false;
            this.MediaPlayer.Click += new System.EventHandler(this.MediaPlayer_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::手機.Properties.Resources.音樂播放;
            this.pictureBox5.Location = new System.Drawing.Point(315, 195);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // LockBox
            // 
            this.LockBox.BackColor = System.Drawing.Color.Transparent;
            this.LockBox.Image = global::手機.Properties.Resources.Lock;
            this.LockBox.Location = new System.Drawing.Point(183, 195);
            this.LockBox.Margin = new System.Windows.Forms.Padding(2);
            this.LockBox.Name = "LockBox";
            this.LockBox.Size = new System.Drawing.Size(33, 34);
            this.LockBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LockBox.TabIndex = 16;
            this.LockBox.TabStop = false;
            this.LockBox.Click += new System.EventHandler(this.LockBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::手機.Properties.Resources._80574678_776307826177032_3000502030302183424_n;
            this.ClientSize = new System.Drawing.Size(405, 499);
            this.Controls.Add(this.LockBox);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.siri);
            this.Controls.Add(this.speaking);
            this.Controls.Add(this.map);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.caculator);
            this.Controls.Add(this.media);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "手機主介面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caculator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speaking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox phone;
        private System.Windows.Forms.PictureBox mail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox media;
        private System.Windows.Forms.PictureBox caculator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.PictureBox speaking;
        private System.Windows.Forms.PictureBox siri;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox MediaPlayer;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox LockBox;
    }
}

