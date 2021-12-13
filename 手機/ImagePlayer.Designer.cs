namespace 手機
{
    partial class ImagePlayer
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
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.Prev_btn = new System.Windows.Forms.Button();
            this.Next_btn = new System.Windows.Forms.Button();
            this.PhotoList = new System.Windows.Forms.ListBox();
            this.Open_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PhotoBox
            // 
            this.PhotoBox.Location = new System.Drawing.Point(-1, 0);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(1068, 544);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoBox.TabIndex = 0;
            this.PhotoBox.TabStop = false;
            // 
            // Prev_btn
            // 
            this.Prev_btn.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Prev_btn.Location = new System.Drawing.Point(1065, 490);
            this.Prev_btn.Name = "Prev_btn";
            this.Prev_btn.Size = new System.Drawing.Size(108, 54);
            this.Prev_btn.TabIndex = 1;
            this.Prev_btn.Text = "Prev";
            this.Prev_btn.UseVisualStyleBackColor = true;
            this.Prev_btn.Click += new System.EventHandler(this.Prev_btn_Click);
            // 
            // Next_btn
            // 
            this.Next_btn.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Next_btn.Location = new System.Drawing.Point(1171, 490);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(92, 54);
            this.Next_btn.TabIndex = 2;
            this.Next_btn.Text = "Next";
            this.Next_btn.UseVisualStyleBackColor = true;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // PhotoList
            // 
            this.PhotoList.FormattingEnabled = true;
            this.PhotoList.ItemHeight = 12;
            this.PhotoList.Location = new System.Drawing.Point(1065, 0);
            this.PhotoList.Name = "PhotoList";
            this.PhotoList.Size = new System.Drawing.Size(198, 448);
            this.PhotoList.TabIndex = 3;
            this.PhotoList.SelectedIndexChanged += new System.EventHandler(this.PhotoList_SelectedIndexChanged);
            // 
            // Open_btn
            // 
            this.Open_btn.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Open_btn.ForeColor = System.Drawing.Color.Blue;
            this.Open_btn.Location = new System.Drawing.Point(1065, 445);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(198, 52);
            this.Open_btn.TabIndex = 4;
            this.Open_btn.Text = "Open";
            this.Open_btn.UseVisualStyleBackColor = true;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // ImagePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 541);
            this.Controls.Add(this.Open_btn);
            this.Controls.Add(this.PhotoList);
            this.Controls.Add(this.Next_btn);
            this.Controls.Add(this.Prev_btn);
            this.Controls.Add(this.PhotoBox);
            this.Name = "ImagePlayer";
            this.Text = "ImagePlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImagePlayer_FormClosing);
            this.Load += new System.EventHandler(this.ImagePlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.Button Prev_btn;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.ListBox PhotoList;
        private System.Windows.Forms.Button Open_btn;
    }
}