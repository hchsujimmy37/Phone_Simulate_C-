namespace 手機
{
    partial class calling
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
            this.components = new System.ComponentModel.Container();
            this.call_name = new System.Windows.Forms.Label();
            this.call_over = new System.Windows.Forms.PictureBox();
            this.accept_reject = new System.Windows.Forms.PictureBox();
            this.accept_accept = new System.Windows.Forms.PictureBox();
            this.callface = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.call_over)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accept_reject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accept_accept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callface)).BeginInit();
            this.SuspendLayout();
            // 
            // call_name
            // 
            this.call_name.AutoSize = true;
            this.call_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.call_name.Location = new System.Drawing.Point(108, 280);
            this.call_name.Name = "call_name";
            this.call_name.Size = new System.Drawing.Size(48, 24);
            this.call_name.TabIndex = 1;
            this.call_name.Text = "姓名";
            this.call_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // call_over
            // 
            this.call_over.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.call_over.Image = global::手機.Properties.Resources.decline;
            this.call_over.Location = new System.Drawing.Point(125, 363);
            this.call_over.Name = "call_over";
            this.call_over.Size = new System.Drawing.Size(80, 80);
            this.call_over.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.call_over.TabIndex = 4;
            this.call_over.TabStop = false;
            this.call_over.Click += new System.EventHandler(this.call_over_Click);
            // 
            // accept_reject
            // 
            this.accept_reject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accept_reject.Image = global::手機.Properties.Resources.decline;
            this.accept_reject.Location = new System.Drawing.Point(199, 363);
            this.accept_reject.Name = "accept_reject";
            this.accept_reject.Size = new System.Drawing.Size(80, 80);
            this.accept_reject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.accept_reject.TabIndex = 3;
            this.accept_reject.TabStop = false;
            // 
            // accept_accept
            // 
            this.accept_accept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accept_accept.Image = global::手機.Properties.Resources.accept;
            this.accept_accept.Location = new System.Drawing.Point(61, 363);
            this.accept_accept.Name = "accept_accept";
            this.accept_accept.Size = new System.Drawing.Size(80, 80);
            this.accept_accept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.accept_accept.TabIndex = 2;
            this.accept_accept.TabStop = false;
            // 
            // callface
            // 
            this.callface.Image = global::手機.Properties.Resources._void;
            this.callface.Location = new System.Drawing.Point(61, 35);
            this.callface.Name = "callface";
            this.callface.Size = new System.Drawing.Size(218, 228);
            this.callface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.callface.TabIndex = 0;
            this.callface.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // calling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 510);
            this.Controls.Add(this.call_over);
            this.Controls.Add(this.accept_reject);
            this.Controls.Add(this.accept_accept);
            this.Controls.Add(this.call_name);
            this.Controls.Add(this.callface);
            this.Name = "calling";
            this.Text = "calling";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.calling_FormClosing);
            this.Load += new System.EventHandler(this.calling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.call_over)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accept_reject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accept_accept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox callface;
        public System.Windows.Forms.Label call_name;
        private System.Windows.Forms.PictureBox accept_accept;
        private System.Windows.Forms.PictureBox accept_reject;
        private System.Windows.Forms.PictureBox call_over;
        public System.Windows.Forms.Timer timer1;
    }
}