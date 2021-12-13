namespace 手機
{
    partial class Record
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
            this.call_list = new System.Windows.Forms.ListBox();
            this.name_title = new System.Windows.Forms.Label();
            this.r_name = new System.Windows.Forms.Label();
            this.r_length = new System.Windows.Forms.Label();
            this.l_title = new System.Windows.Forms.Label();
            this.r_time = new System.Windows.Forms.Label();
            this.t_title = new System.Windows.Forms.Label();
            this.delete_all = new System.Windows.Forms.PictureBox();
            this.choose_Delete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.delete_all)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choose_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // call_list
            // 
            this.call_list.FormattingEnabled = true;
            this.call_list.ItemHeight = 12;
            this.call_list.Location = new System.Drawing.Point(54, 25);
            this.call_list.Name = "call_list";
            this.call_list.ScrollAlwaysVisible = true;
            this.call_list.Size = new System.Drawing.Size(216, 244);
            this.call_list.TabIndex = 0;
            this.call_list.SelectedIndexChanged += new System.EventHandler(this.call_list_SelectedIndexChanged);
            // 
            // name_title
            // 
            this.name_title.AutoSize = true;
            this.name_title.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name_title.Location = new System.Drawing.Point(66, 299);
            this.name_title.Name = "name_title";
            this.name_title.Size = new System.Drawing.Size(63, 17);
            this.name_title.TabIndex = 1;
            this.name_title.Text = "通話對象:";
            // 
            // r_name
            // 
            this.r_name.AutoSize = true;
            this.r_name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.r_name.Location = new System.Drawing.Point(136, 299);
            this.r_name.Name = "r_name";
            this.r_name.Size = new System.Drawing.Size(62, 21);
            this.r_name.TabIndex = 2;
            this.r_name.Text = "無 名氏";
            // 
            // r_length
            // 
            this.r_length.AutoSize = true;
            this.r_length.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.r_length.Location = new System.Drawing.Point(136, 331);
            this.r_length.Name = "r_length";
            this.r_length.Size = new System.Drawing.Size(36, 21);
            this.r_length.TabIndex = 4;
            this.r_length.Text = "0秒";
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l_title.Location = new System.Drawing.Point(66, 331);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(63, 17);
            this.l_title.TabIndex = 3;
            this.l_title.Text = "通話長度:";
            // 
            // r_time
            // 
            this.r_time.AutoSize = true;
            this.r_time.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.r_time.Location = new System.Drawing.Point(70, 392);
            this.r_time.Name = "r_time";
            this.r_time.Size = new System.Drawing.Size(200, 21);
            this.r_time.TabIndex = 6;
            this.r_time.Text = "1900年1月1日 0時0分0秒";
            // 
            // t_title
            // 
            this.t_title.AutoSize = true;
            this.t_title.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.t_title.Location = new System.Drawing.Point(66, 365);
            this.t_title.Name = "t_title";
            this.t_title.Size = new System.Drawing.Size(63, 17);
            this.t_title.TabIndex = 5;
            this.t_title.Text = "通話時間:";
            // 
            // delete_all
            // 
            this.delete_all.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delete_all.Image = global::手機.Properties.Resources.icons8_trash_can_96;
            this.delete_all.Location = new System.Drawing.Point(185, 439);
            this.delete_all.Name = "delete_all";
            this.delete_all.Size = new System.Drawing.Size(40, 40);
            this.delete_all.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delete_all.TabIndex = 12;
            this.delete_all.TabStop = false;
            this.delete_all.Click += new System.EventHandler(this.delete_all_Click);
            // 
            // choose_Delete
            // 
            this.choose_Delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choose_Delete.Image = global::手機.Properties.Resources.icons8_delete_256;
            this.choose_Delete.Location = new System.Drawing.Point(89, 439);
            this.choose_Delete.Name = "choose_Delete";
            this.choose_Delete.Size = new System.Drawing.Size(40, 40);
            this.choose_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.choose_Delete.TabIndex = 11;
            this.choose_Delete.TabStop = false;
            this.choose_Delete.Click += new System.EventHandler(this.choose_Delete_Click);
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 510);
            this.Controls.Add(this.delete_all);
            this.Controls.Add(this.choose_Delete);
            this.Controls.Add(this.r_time);
            this.Controls.Add(this.t_title);
            this.Controls.Add(this.r_length);
            this.Controls.Add(this.l_title);
            this.Controls.Add(this.r_name);
            this.Controls.Add(this.name_title);
            this.Controls.Add(this.call_list);
            this.Name = "Record";
            this.Text = "Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Record_FormClosing);
            this.Load += new System.EventHandler(this.Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delete_all)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choose_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        public System.Windows.Forms.ListBox call_list;
        private System.Windows.Forms.Label name_title;
        private System.Windows.Forms.Label r_name;
        private System.Windows.Forms.Label r_length;
        private System.Windows.Forms.Label l_title;
        private System.Windows.Forms.Label r_time;
        private System.Windows.Forms.Label t_title;
        private System.Windows.Forms.PictureBox choose_Delete;
        private System.Windows.Forms.PictureBox delete_all;
    }
}