namespace 手機
{
    partial class friend
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
            this.f_Name = new System.Windows.Forms.Label();
            this.name_title = new System.Windows.Forms.Label();
            this.f_phone = new System.Windows.Forms.Label();
            this.p_title = new System.Windows.Forms.Label();
            this.friend_list = new System.Windows.Forms.ListBox();
            this.join_fri = new System.Windows.Forms.PictureBox();
            this.modify_friend = new System.Windows.Forms.PictureBox();
            this.accept_accept = new System.Windows.Forms.PictureBox();
            this.callface = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.join_fri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_friend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accept_accept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callface)).BeginInit();
            this.SuspendLayout();
            // 
            // f_Name
            // 
            this.f_Name.AutoSize = true;
            this.f_Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.f_Name.Location = new System.Drawing.Point(138, 217);
            this.f_Name.Name = "f_Name";
            this.f_Name.Size = new System.Drawing.Size(62, 21);
            this.f_Name.TabIndex = 6;
            this.f_Name.Text = "無 名氏";
            // 
            // name_title
            // 
            this.name_title.AutoSize = true;
            this.name_title.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name_title.Location = new System.Drawing.Point(79, 218);
            this.name_title.Name = "name_title";
            this.name_title.Size = new System.Drawing.Size(46, 21);
            this.name_title.TabIndex = 5;
            this.name_title.Text = "姓名:";
            // 
            // f_phone
            // 
            this.f_phone.AutoSize = true;
            this.f_phone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.f_phone.Location = new System.Drawing.Point(138, 249);
            this.f_phone.Name = "f_phone";
            this.f_phone.Size = new System.Drawing.Size(60, 21);
            this.f_phone.TabIndex = 8;
            this.f_phone.Text = "09999";
            // 
            // p_title
            // 
            this.p_title.AutoSize = true;
            this.p_title.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p_title.Location = new System.Drawing.Point(79, 250);
            this.p_title.Name = "p_title";
            this.p_title.Size = new System.Drawing.Size(46, 21);
            this.p_title.TabIndex = 7;
            this.p_title.Text = "手機:";
            // 
            // friend_list
            // 
            this.friend_list.FormattingEnabled = true;
            this.friend_list.ItemHeight = 12;
            this.friend_list.Location = new System.Drawing.Point(52, 283);
            this.friend_list.Name = "friend_list";
            this.friend_list.Size = new System.Drawing.Size(229, 148);
            this.friend_list.TabIndex = 9;
            this.friend_list.SelectedIndexChanged += new System.EventHandler(this.friend_list_SelectedIndexChanged);
            // 
            // join_fri
            // 
            this.join_fri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.join_fri.Image = global::手機.Properties.Resources.icons8_plus_96;
            this.join_fri.Location = new System.Drawing.Point(214, 449);
            this.join_fri.Name = "join_fri";
            this.join_fri.Size = new System.Drawing.Size(40, 40);
            this.join_fri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.join_fri.TabIndex = 12;
            this.join_fri.TabStop = false;
            this.join_fri.Click += new System.EventHandler(this.join_fri_Click);
            // 
            // modify_friend
            // 
            this.modify_friend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modify_friend.Image = global::手機.Properties.Resources.pencil_edit_button;
            this.modify_friend.Location = new System.Drawing.Point(142, 449);
            this.modify_friend.Name = "modify_friend";
            this.modify_friend.Size = new System.Drawing.Size(40, 40);
            this.modify_friend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.modify_friend.TabIndex = 11;
            this.modify_friend.TabStop = false;
            this.modify_friend.Click += new System.EventHandler(this.modify_friend_Click);
            // 
            // accept_accept
            // 
            this.accept_accept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accept_accept.Image = global::手機.Properties.Resources.accept;
            this.accept_accept.Location = new System.Drawing.Point(71, 449);
            this.accept_accept.Name = "accept_accept";
            this.accept_accept.Size = new System.Drawing.Size(40, 40);
            this.accept_accept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.accept_accept.TabIndex = 10;
            this.accept_accept.TabStop = false;
            this.accept_accept.Click += new System.EventHandler(this.accept_accept_Click);
            // 
            // callface
            // 
            this.callface.Image = global::手機.Properties.Resources._void;
            this.callface.Location = new System.Drawing.Point(52, 30);
            this.callface.Name = "callface";
            this.callface.Size = new System.Drawing.Size(229, 160);
            this.callface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.callface.TabIndex = 4;
            this.callface.TabStop = false;
            // 
            // friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 510);
            this.Controls.Add(this.join_fri);
            this.Controls.Add(this.modify_friend);
            this.Controls.Add(this.accept_accept);
            this.Controls.Add(this.friend_list);
            this.Controls.Add(this.f_phone);
            this.Controls.Add(this.p_title);
            this.Controls.Add(this.f_Name);
            this.Controls.Add(this.name_title);
            this.Controls.Add(this.callface);
            this.Name = "friend";
            this.Text = "friend";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.friend_FormClosing);
            this.Load += new System.EventHandler(this.friend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.join_fri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_friend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accept_accept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label f_Name;
        private System.Windows.Forms.Label name_title;
        private System.Windows.Forms.PictureBox callface;
        private System.Windows.Forms.Label f_phone;
        private System.Windows.Forms.Label p_title;
        public System.Windows.Forms.ListBox friend_list;
        private System.Windows.Forms.PictureBox accept_accept;
        private System.Windows.Forms.PictureBox modify_friend;
        private System.Windows.Forms.PictureBox join_fri;
    }
}