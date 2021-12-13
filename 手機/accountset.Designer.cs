namespace 手機
{
    partial class accountset
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
            this.idtitle = new System.Windows.Forms.Label();
            this.id_input = new System.Windows.Forms.TextBox();
            this.pw_input = new System.Windows.Forms.TextBox();
            this.pwtitle = new System.Windows.Forms.Label();
            this.pw_re = new System.Windows.Forms.TextBox();
            this.pw_re_title = new System.Windows.Forms.Label();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.phone_title = new System.Windows.Forms.Label();
            this.star_1 = new System.Windows.Forms.Label();
            this.star_2 = new System.Windows.Forms.Label();
            this.star_3 = new System.Windows.Forms.Label();
            this.surname_input = new System.Windows.Forms.TextBox();
            this.surname_title = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.name_title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sign_input = new System.Windows.Forms.TextBox();
            this.sign_title = new System.Windows.Forms.Label();
            this.star_4 = new System.Windows.Forms.Label();
            this.star_5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.messageDataSet = new 手機.messageDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.messageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idtitle
            // 
            this.idtitle.AutoSize = true;
            this.idtitle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.idtitle.Location = new System.Drawing.Point(99, 86);
            this.idtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idtitle.Name = "idtitle";
            this.idtitle.Size = new System.Drawing.Size(52, 25);
            this.idtitle.TabIndex = 0;
            this.idtitle.Text = "帳號";
            // 
            // id_input
            // 
            this.id_input.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.id_input.Location = new System.Drawing.Point(177, 86);
            this.id_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(234, 29);
            this.id_input.TabIndex = 1;
            this.id_input.TextChanged += new System.EventHandler(this.id_input_TextChanged);
            this.id_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_input_KeyPress);
            // 
            // pw_input
            // 
            this.pw_input.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pw_input.Location = new System.Drawing.Point(177, 154);
            this.pw_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pw_input.Name = "pw_input";
            this.pw_input.PasswordChar = '*';
            this.pw_input.Size = new System.Drawing.Size(234, 29);
            this.pw_input.TabIndex = 3;
            this.pw_input.TextChanged += new System.EventHandler(this.pw_input_TextChanged);
            this.pw_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pw_input_KeyPress);
            // 
            // pwtitle
            // 
            this.pwtitle.AutoSize = true;
            this.pwtitle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pwtitle.Location = new System.Drawing.Point(99, 153);
            this.pwtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwtitle.Name = "pwtitle";
            this.pwtitle.Size = new System.Drawing.Size(52, 25);
            this.pwtitle.TabIndex = 2;
            this.pwtitle.Text = "密碼";
            // 
            // pw_re
            // 
            this.pw_re.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pw_re.Location = new System.Drawing.Point(177, 219);
            this.pw_re.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pw_re.Name = "pw_re";
            this.pw_re.PasswordChar = '*';
            this.pw_re.Size = new System.Drawing.Size(234, 29);
            this.pw_re.TabIndex = 5;
            this.pw_re.TextChanged += new System.EventHandler(this.pw_re_TextChanged);
            this.pw_re.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pw_re_KeyPress);
            // 
            // pw_re_title
            // 
            this.pw_re_title.AutoSize = true;
            this.pw_re_title.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pw_re_title.Location = new System.Drawing.Point(21, 219);
            this.pw_re_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pw_re_title.Name = "pw_re_title";
            this.pw_re_title.Size = new System.Drawing.Size(132, 25);
            this.pw_re_title.TabIndex = 4;
            this.pw_re_title.Text = "再次輸入密碼";
            // 
            // phone_input
            // 
            this.phone_input.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.phone_input.Location = new System.Drawing.Point(177, 360);
            this.phone_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(234, 29);
            this.phone_input.TabIndex = 7;
            // 
            // phone_title
            // 
            this.phone_title.AutoSize = true;
            this.phone_title.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.phone_title.Location = new System.Drawing.Point(99, 360);
            this.phone_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone_title.Name = "phone_title";
            this.phone_title.Size = new System.Drawing.Size(52, 25);
            this.phone_title.TabIndex = 6;
            this.phone_title.Text = "手機";
            // 
            // star_1
            // 
            this.star_1.AutoSize = true;
            this.star_1.ForeColor = System.Drawing.Color.Red;
            this.star_1.Location = new System.Drawing.Point(152, 86);
            this.star_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.star_1.Name = "star_1";
            this.star_1.Size = new System.Drawing.Size(16, 18);
            this.star_1.TabIndex = 8;
            this.star_1.Text = "*";
            // 
            // star_2
            // 
            this.star_2.AutoSize = true;
            this.star_2.ForeColor = System.Drawing.Color.Red;
            this.star_2.Location = new System.Drawing.Point(152, 153);
            this.star_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.star_2.Name = "star_2";
            this.star_2.Size = new System.Drawing.Size(16, 18);
            this.star_2.TabIndex = 9;
            this.star_2.Text = "*";
            // 
            // star_3
            // 
            this.star_3.AutoSize = true;
            this.star_3.ForeColor = System.Drawing.Color.Red;
            this.star_3.Location = new System.Drawing.Point(152, 219);
            this.star_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.star_3.Name = "star_3";
            this.star_3.Size = new System.Drawing.Size(16, 18);
            this.star_3.TabIndex = 10;
            this.star_3.Text = "*";
            // 
            // surname_input
            // 
            this.surname_input.Location = new System.Drawing.Point(177, 280);
            this.surname_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surname_input.Name = "surname_input";
            this.surname_input.Size = new System.Drawing.Size(78, 29);
            this.surname_input.TabIndex = 12;
            // 
            // surname_title
            // 
            this.surname_title.AutoSize = true;
            this.surname_title.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.surname_title.Location = new System.Drawing.Point(99, 280);
            this.surname_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surname_title.Name = "surname_title";
            this.surname_title.Size = new System.Drawing.Size(52, 25);
            this.surname_title.TabIndex = 11;
            this.surname_title.Text = "姓氏";
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(348, 280);
            this.name_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(104, 29);
            this.name_input.TabIndex = 14;
            // 
            // name_title
            // 
            this.name_title.AutoSize = true;
            this.name_title.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name_title.Location = new System.Drawing.Point(266, 280);
            this.name_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_title.Name = "name_title";
            this.name_title.Size = new System.Drawing.Size(52, 25);
            this.name_title.TabIndex = 13;
            this.name_title.Text = "名字";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 708);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "送出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sign_input
            // 
            this.sign_input.Location = new System.Drawing.Point(177, 450);
            this.sign_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sign_input.Multiline = true;
            this.sign_input.Name = "sign_input";
            this.sign_input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sign_input.Size = new System.Drawing.Size(362, 230);
            this.sign_input.TabIndex = 17;
            // 
            // sign_title
            // 
            this.sign_title.AutoSize = true;
            this.sign_title.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sign_title.Location = new System.Drawing.Point(60, 450);
            this.sign_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sign_title.Name = "sign_title";
            this.sign_title.Size = new System.Drawing.Size(92, 25);
            this.sign_title.TabIndex = 16;
            this.sign_title.Text = "個性簽名";
            // 
            // star_4
            // 
            this.star_4.AutoSize = true;
            this.star_4.ForeColor = System.Drawing.Color.Red;
            this.star_4.Location = new System.Drawing.Point(152, 280);
            this.star_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.star_4.Name = "star_4";
            this.star_4.Size = new System.Drawing.Size(16, 18);
            this.star_4.TabIndex = 18;
            this.star_4.Text = "*";
            // 
            // star_5
            // 
            this.star_5.AutoSize = true;
            this.star_5.ForeColor = System.Drawing.Color.Red;
            this.star_5.Location = new System.Drawing.Point(322, 280);
            this.star_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.star_5.Name = "star_5";
            this.star_5.Size = new System.Drawing.Size(16, 18);
            this.star_5.TabIndex = 19;
            this.star_5.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(174, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "帳號、密碼只能輸入英文或數字，星號為必填";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(426, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(426, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(422, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 23;
            // 
            // messageDataSet
            // 
            this.messageDataSet.DataSetName = "messageDataSet";
            this.messageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.messageDataSet;
            this.bindingSource1.Position = 0;
            // 
            // accountset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 778);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.star_5);
            this.Controls.Add(this.star_4);
            this.Controls.Add(this.sign_input);
            this.Controls.Add(this.sign_title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.name_title);
            this.Controls.Add(this.surname_input);
            this.Controls.Add(this.surname_title);
            this.Controls.Add(this.star_3);
            this.Controls.Add(this.star_2);
            this.Controls.Add(this.star_1);
            this.Controls.Add(this.phone_input);
            this.Controls.Add(this.phone_title);
            this.Controls.Add(this.pw_re);
            this.Controls.Add(this.pw_re_title);
            this.Controls.Add(this.pw_input);
            this.Controls.Add(this.pwtitle);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.idtitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "accountset";
            this.Text = "accountset";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.accountset_FormClosing);
            this.Load += new System.EventHandler(this.accountset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idtitle;
        public System.Windows.Forms.TextBox id_input;
        public System.Windows.Forms.TextBox pw_input;
        private System.Windows.Forms.Label pwtitle;
        public System.Windows.Forms.TextBox pw_re;
        private System.Windows.Forms.Label pw_re_title;
        public System.Windows.Forms.TextBox phone_input;
        private System.Windows.Forms.Label phone_title;
        private System.Windows.Forms.Label star_1;
        private System.Windows.Forms.Label star_2;
        private System.Windows.Forms.Label star_3;
        public System.Windows.Forms.TextBox surname_input;
        private System.Windows.Forms.Label surname_title;
        public System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label name_title;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox sign_input;
        private System.Windows.Forms.Label sign_title;
        private System.Windows.Forms.Label star_4;
        private System.Windows.Forms.Label star_5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private messageDataSet messageDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}