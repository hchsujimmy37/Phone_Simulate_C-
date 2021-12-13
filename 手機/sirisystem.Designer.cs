namespace 手機
{
    partial class sirisystem
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.siri1 = new System.Windows.Forms.PictureBox();
            this.user1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.siri1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 126);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 204);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 126);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 204);
            this.textBox2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(211, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 33);
            this.button4.TabIndex = 14;
            this.button4.Text = "repeat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(455, 342);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "stop";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // siri1
            // 
            this.siri1.Image = global::手機.Properties.Resources.siri;
            this.siri1.Location = new System.Drawing.Point(438, 12);
            this.siri1.Name = "siri1";
            this.siri1.Size = new System.Drawing.Size(115, 93);
            this.siri1.TabIndex = 12;
            this.siri1.TabStop = false;
            // 
            // user1
            // 
            this.user1.Image = global::手機.Properties.Resources.user;
            this.user1.Location = new System.Drawing.Point(106, 12);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(115, 93);
            this.user1.TabIndex = 11;
            this.user1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(91, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "說話";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button5_Click);
            // 
            // sirisystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 426);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.siri1);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "sirisystem";
            this.Text = "sirisystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sirisystem_FormClosing_1);
            this.Load += new System.EventHandler(this.sirisystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siri1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox siri1;
        private System.Windows.Forms.PictureBox user1;
        private System.Windows.Forms.Button button2;
    }
}