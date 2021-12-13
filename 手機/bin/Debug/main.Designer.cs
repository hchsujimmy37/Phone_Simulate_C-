namespace 手機
{
    partial class main
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
            this.title1 = new System.Windows.Forms.Label();
            this.messagesend = new System.Windows.Forms.Button();
            this.themechange = new System.Windows.Forms.Button();
            this.addfriend = new System.Windows.Forms.Button();
            this.accountmod = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.useridtitle = new System.Windows.Forms.Label();
            this.passwordtitle = new System.Windows.Forms.Label();
            this.userid = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.returntomain = new System.Windows.Forms.Button();
            this.Chatting = new System.Windows.Forms.Button();
            this.lastpage_mes = new System.Windows.Forms.Button();
            this.TalkingWindow = new System.Windows.Forms.TextBox();
            this.messagecolumn = new System.Windows.Forms.TextBox();
            this.sending = new System.Windows.Forms.Button();
            this.changebgp = new System.Windows.Forms.Button();
            this.frilist = new System.Windows.Forms.Button();
            this.frireq = new System.Windows.Forms.Button();
            this.frifin = new System.Windows.Forms.Button();
            this.request_not = new System.Windows.Forms.Label();
            this.last_list = new System.Windows.Forms.Button();
            this.check_data = new System.Windows.Forms.Button();
            this.delete_friend = new System.Windows.Forms.Button();
            this.sendreq = new System.Windows.Forms.Button();
            this.receivereq = new System.Windows.Forms.Button();
            this.IDsearch = new System.Windows.Forms.Button();
            this.frisuggestion = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.id_select = new System.Windows.Forms.TextBox();
            this.ShowInformation = new System.Windows.Forms.TextBox();
            this.sendoutid = new System.Windows.Forms.Button();
            this.Friend_join_id = new System.Windows.Forms.Button();
            this.last_page_id = new System.Windows.Forms.Button();
            this.requestlist = new System.Windows.Forms.ListBox();
            this.detailforrequest = new System.Windows.Forms.TextBox();
            this.agreereq = new System.Windows.Forms.Button();
            this.refusereq = new System.Windows.Forms.Button();
            this.last_req = new System.Windows.Forms.Button();
            this.cancelreq = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.messageDataSet1 = new 手機.messageDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.BackColor = System.Drawing.Color.Transparent;
            this.title1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(100, 43);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(143, 24);
            this.title1.TabIndex = 0;
            this.title1.Text = "請輸入帳號密碼";
            // 
            // messagesend
            // 
            this.messagesend.Location = new System.Drawing.Point(137, 125);
            this.messagesend.Name = "messagesend";
            this.messagesend.Size = new System.Drawing.Size(95, 32);
            this.messagesend.TabIndex = 1;
            this.messagesend.Text = "傳送訊息";
            this.messagesend.UseVisualStyleBackColor = true;
            this.messagesend.Click += new System.EventHandler(this.messagesend_Click);
            // 
            // themechange
            // 
            this.themechange.Location = new System.Drawing.Point(137, 187);
            this.themechange.Name = "themechange";
            this.themechange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.themechange.Size = new System.Drawing.Size(95, 32);
            this.themechange.TabIndex = 2;
            this.themechange.Text = "更換主題";
            this.themechange.UseVisualStyleBackColor = true;
            this.themechange.Click += new System.EventHandler(this.friendlist_Click);
            // 
            // addfriend
            // 
            this.addfriend.Location = new System.Drawing.Point(137, 254);
            this.addfriend.Name = "addfriend";
            this.addfriend.Size = new System.Drawing.Size(95, 32);
            this.addfriend.TabIndex = 3;
            this.addfriend.Text = "加入好友";
            this.addfriend.UseVisualStyleBackColor = true;
            this.addfriend.Click += new System.EventHandler(this.addfriend_Click);
            // 
            // accountmod
            // 
            this.accountmod.Location = new System.Drawing.Point(137, 314);
            this.accountmod.Name = "accountmod";
            this.accountmod.Size = new System.Drawing.Size(95, 32);
            this.accountmod.TabIndex = 4;
            this.accountmod.Text = "帳號修改";
            this.accountmod.UseVisualStyleBackColor = true;
            this.accountmod.Click += new System.EventHandler(this.accountmod_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(23, 10);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(64, 19);
            this.logout.TabIndex = 5;
            this.logout.Text = "登出";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // useridtitle
            // 
            this.useridtitle.AutoSize = true;
            this.useridtitle.BackColor = System.Drawing.Color.Transparent;
            this.useridtitle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.useridtitle.ForeColor = System.Drawing.Color.White;
            this.useridtitle.Location = new System.Drawing.Point(59, 132);
            this.useridtitle.Name = "useridtitle";
            this.useridtitle.Size = new System.Drawing.Size(34, 17);
            this.useridtitle.TabIndex = 6;
            this.useridtitle.Text = "帳號";
            // 
            // passwordtitle
            // 
            this.passwordtitle.AutoSize = true;
            this.passwordtitle.BackColor = System.Drawing.Color.Transparent;
            this.passwordtitle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passwordtitle.ForeColor = System.Drawing.Color.White;
            this.passwordtitle.Location = new System.Drawing.Point(61, 173);
            this.passwordtitle.Name = "passwordtitle";
            this.passwordtitle.Size = new System.Drawing.Size(34, 17);
            this.passwordtitle.TabIndex = 7;
            this.passwordtitle.Text = "密碼";
            // 
            // userid
            // 
            this.userid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.userid.Location = new System.Drawing.Point(125, 133);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(148, 22);
            this.userid.TabIndex = 8;
            // 
            // password
            // 
            this.password.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.password.Location = new System.Drawing.Point(126, 173);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(148, 22);
            this.password.TabIndex = 9;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(203, 225);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(70, 23);
            this.login.TabIndex = 10;
            this.login.Text = "登入";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(62, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(225, 316);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // returntomain
            // 
            this.returntomain.Location = new System.Drawing.Point(12, 10);
            this.returntomain.Name = "returntomain";
            this.returntomain.Size = new System.Drawing.Size(75, 23);
            this.returntomain.TabIndex = 12;
            this.returntomain.Text = "回主畫面";
            this.returntomain.UseVisualStyleBackColor = true;
            this.returntomain.Click += new System.EventHandler(this.returntomain_Click);
            // 
            // Chatting
            // 
            this.Chatting.Location = new System.Drawing.Point(125, 426);
            this.Chatting.Name = "Chatting";
            this.Chatting.Size = new System.Drawing.Size(75, 23);
            this.Chatting.TabIndex = 13;
            this.Chatting.Text = "聊天";
            this.Chatting.UseVisualStyleBackColor = true;
            this.Chatting.Click += new System.EventHandler(this.Chatting_Click);
            // 
            // lastpage_mes
            // 
            this.lastpage_mes.Location = new System.Drawing.Point(12, 12);
            this.lastpage_mes.Name = "lastpage_mes";
            this.lastpage_mes.Size = new System.Drawing.Size(75, 23);
            this.lastpage_mes.TabIndex = 14;
            this.lastpage_mes.Text = "上一頁";
            this.lastpage_mes.UseVisualStyleBackColor = true;
            this.lastpage_mes.Click += new System.EventHandler(this.lastpage_mes_Click);
            // 
            // TalkingWindow
            // 
            this.TalkingWindow.Location = new System.Drawing.Point(33, 84);
            this.TalkingWindow.Multiline = true;
            this.TalkingWindow.Name = "TalkingWindow";
            this.TalkingWindow.ReadOnly = true;
            this.TalkingWindow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TalkingWindow.Size = new System.Drawing.Size(280, 384);
            this.TalkingWindow.TabIndex = 15;
            // 
            // messagecolumn
            // 
            this.messagecolumn.Location = new System.Drawing.Point(30, 492);
            this.messagecolumn.Multiline = true;
            this.messagecolumn.Name = "messagecolumn";
            this.messagecolumn.Size = new System.Drawing.Size(283, 75);
            this.messagecolumn.TabIndex = 16;
            // 
            // sending
            // 
            this.sending.Location = new System.Drawing.Point(238, 593);
            this.sending.Name = "sending";
            this.sending.Size = new System.Drawing.Size(75, 23);
            this.sending.TabIndex = 17;
            this.sending.Text = "傳送";
            this.sending.UseVisualStyleBackColor = true;
            this.sending.Click += new System.EventHandler(this.sending_Click);
            // 
            // changebgp
            // 
            this.changebgp.Location = new System.Drawing.Point(126, 426);
            this.changebgp.Name = "changebgp";
            this.changebgp.Size = new System.Drawing.Size(75, 23);
            this.changebgp.TabIndex = 18;
            this.changebgp.Text = "確定更改";
            this.changebgp.UseVisualStyleBackColor = true;
            this.changebgp.Click += new System.EventHandler(this.changebgp_Click);
            // 
            // frilist
            // 
            this.frilist.Location = new System.Drawing.Point(125, 144);
            this.frilist.Name = "frilist";
            this.frilist.Size = new System.Drawing.Size(107, 23);
            this.frilist.TabIndex = 19;
            this.frilist.Text = "好友列表";
            this.frilist.UseVisualStyleBackColor = true;
            this.frilist.Click += new System.EventHandler(this.frilist_Click);
            // 
            // frireq
            // 
            this.frireq.Location = new System.Drawing.Point(126, 214);
            this.frireq.Name = "frireq";
            this.frireq.Size = new System.Drawing.Size(106, 23);
            this.frireq.TabIndex = 20;
            this.frireq.Text = "好友申請";
            this.frireq.UseVisualStyleBackColor = true;
            this.frireq.Click += new System.EventHandler(this.frireq_Click);
            // 
            // frifin
            // 
            this.frifin.Location = new System.Drawing.Point(126, 285);
            this.frifin.Name = "frifin";
            this.frifin.Size = new System.Drawing.Size(106, 23);
            this.frifin.TabIndex = 21;
            this.frifin.Text = "尋找好友";
            this.frifin.UseVisualStyleBackColor = true;
            this.frifin.Click += new System.EventHandler(this.frifin_Click);
            // 
            // request_not
            // 
            this.request_not.BackColor = System.Drawing.Color.Red;
            this.request_not.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.request_not.ForeColor = System.Drawing.Color.White;
            this.request_not.Location = new System.Drawing.Point(221, 207);
            this.request_not.Name = "request_not";
            this.request_not.Size = new System.Drawing.Size(17, 17);
            this.request_not.TabIndex = 22;
            this.request_not.Text = "0";
            // 
            // last_list
            // 
            this.last_list.Location = new System.Drawing.Point(12, 10);
            this.last_list.Name = "last_list";
            this.last_list.Size = new System.Drawing.Size(75, 25);
            this.last_list.TabIndex = 23;
            this.last_list.Text = "上一頁";
            this.last_list.UseVisualStyleBackColor = true;
            this.last_list.Click += new System.EventHandler(this.last_list_Click);
            // 
            // check_data
            // 
            this.check_data.Location = new System.Drawing.Point(83, 426);
            this.check_data.Name = "check_data";
            this.check_data.Size = new System.Drawing.Size(75, 23);
            this.check_data.TabIndex = 24;
            this.check_data.Text = "查看資料";
            this.check_data.UseVisualStyleBackColor = true;
            this.check_data.Click += new System.EventHandler(this.check_data_Click);
            // 
            // delete_friend
            // 
            this.delete_friend.Location = new System.Drawing.Point(185, 426);
            this.delete_friend.Name = "delete_friend";
            this.delete_friend.Size = new System.Drawing.Size(75, 23);
            this.delete_friend.TabIndex = 25;
            this.delete_friend.Text = "刪除好友";
            this.delete_friend.UseVisualStyleBackColor = true;
            this.delete_friend.Click += new System.EventHandler(this.delete_friend_Click);
            // 
            // sendreq
            // 
            this.sendreq.Location = new System.Drawing.Point(125, 173);
            this.sendreq.Name = "sendreq";
            this.sendreq.Size = new System.Drawing.Size(107, 23);
            this.sendreq.TabIndex = 26;
            this.sendreq.Text = "發出的申請";
            this.sendreq.UseVisualStyleBackColor = true;
            this.sendreq.Click += new System.EventHandler(this.sendreq_Click);
            // 
            // receivereq
            // 
            this.receivereq.Location = new System.Drawing.Point(125, 243);
            this.receivereq.Name = "receivereq";
            this.receivereq.Size = new System.Drawing.Size(107, 23);
            this.receivereq.TabIndex = 27;
            this.receivereq.Text = "收到的申請";
            this.receivereq.UseVisualStyleBackColor = true;
            this.receivereq.Click += new System.EventHandler(this.receivereq_Click);
            // 
            // IDsearch
            // 
            this.IDsearch.Location = new System.Drawing.Point(125, 173);
            this.IDsearch.Name = "IDsearch";
            this.IDsearch.Size = new System.Drawing.Size(107, 23);
            this.IDsearch.TabIndex = 28;
            this.IDsearch.Text = "ID搜尋";
            this.IDsearch.UseVisualStyleBackColor = true;
            this.IDsearch.Click += new System.EventHandler(this.IDsearch_Click);
            // 
            // frisuggestion
            // 
            this.frisuggestion.Location = new System.Drawing.Point(126, 243);
            this.frisuggestion.Name = "frisuggestion";
            this.frisuggestion.Size = new System.Drawing.Size(107, 23);
            this.frisuggestion.TabIndex = 29;
            this.frisuggestion.Text = "系統推薦";
            this.frisuggestion.UseVisualStyleBackColor = true;
            this.frisuggestion.Click += new System.EventHandler(this.frisuggestion_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.BackColor = System.Drawing.Color.Transparent;
            this.id_label.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(68, 116);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(25, 17);
            this.id_label.TabIndex = 30;
            this.id_label.Text = "ID:";
            // 
            // id_select
            // 
            this.id_select.Location = new System.Drawing.Point(104, 116);
            this.id_select.Name = "id_select";
            this.id_select.Size = new System.Drawing.Size(128, 22);
            this.id_select.TabIndex = 31;
            this.id_select.TextChanged += new System.EventHandler(this.id_select_TextChanged);
            // 
            // ShowInformation
            // 
            this.ShowInformation.Location = new System.Drawing.Point(71, 148);
            this.ShowInformation.Multiline = true;
            this.ShowInformation.Name = "ShowInformation";
            this.ShowInformation.ReadOnly = true;
            this.ShowInformation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ShowInformation.Size = new System.Drawing.Size(203, 252);
            this.ShowInformation.TabIndex = 32;
            // 
            // sendoutid
            // 
            this.sendoutid.Location = new System.Drawing.Point(257, 116);
            this.sendoutid.Name = "sendoutid";
            this.sendoutid.Size = new System.Drawing.Size(65, 23);
            this.sendoutid.TabIndex = 33;
            this.sendoutid.Text = "搜尋";
            this.sendoutid.UseVisualStyleBackColor = true;
            this.sendoutid.Click += new System.EventHandler(this.sendoutid_Click);
            // 
            // Friend_join_id
            // 
            this.Friend_join_id.Location = new System.Drawing.Point(137, 426);
            this.Friend_join_id.Name = "Friend_join_id";
            this.Friend_join_id.Size = new System.Drawing.Size(75, 23);
            this.Friend_join_id.TabIndex = 34;
            this.Friend_join_id.Text = "加入好友";
            this.Friend_join_id.UseVisualStyleBackColor = true;
            this.Friend_join_id.Click += new System.EventHandler(this.button1_Click);
            // 
            // last_page_id
            // 
            this.last_page_id.Location = new System.Drawing.Point(12, 10);
            this.last_page_id.Name = "last_page_id";
            this.last_page_id.Size = new System.Drawing.Size(75, 25);
            this.last_page_id.TabIndex = 35;
            this.last_page_id.Text = "上一頁";
            this.last_page_id.UseVisualStyleBackColor = true;
            this.last_page_id.Click += new System.EventHandler(this.last_page_id_Click);
            // 
            // requestlist
            // 
            this.requestlist.FormattingEnabled = true;
            this.requestlist.ItemHeight = 12;
            this.requestlist.Location = new System.Drawing.Point(52, 97);
            this.requestlist.Name = "requestlist";
            this.requestlist.Size = new System.Drawing.Size(222, 160);
            this.requestlist.TabIndex = 36;
            this.requestlist.SelectedIndexChanged += new System.EventHandler(this.requestlist_SelectedIndexChanged);
            // 
            // detailforrequest
            // 
            this.detailforrequest.Location = new System.Drawing.Point(51, 263);
            this.detailforrequest.Multiline = true;
            this.detailforrequest.Name = "detailforrequest";
            this.detailforrequest.ReadOnly = true;
            this.detailforrequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.detailforrequest.Size = new System.Drawing.Size(222, 157);
            this.detailforrequest.TabIndex = 37;
            // 
            // agreereq
            // 
            this.agreereq.Location = new System.Drawing.Point(64, 435);
            this.agreereq.Name = "agreereq";
            this.agreereq.Size = new System.Drawing.Size(75, 23);
            this.agreereq.TabIndex = 38;
            this.agreereq.Text = "同意";
            this.agreereq.UseVisualStyleBackColor = true;
            this.agreereq.Click += new System.EventHandler(this.agreereq_Click);
            // 
            // refusereq
            // 
            this.refusereq.Location = new System.Drawing.Point(168, 435);
            this.refusereq.Name = "refusereq";
            this.refusereq.Size = new System.Drawing.Size(75, 23);
            this.refusereq.TabIndex = 39;
            this.refusereq.Text = "拒絕";
            this.refusereq.UseVisualStyleBackColor = true;
            this.refusereq.Click += new System.EventHandler(this.refusereq_Click);
            // 
            // last_req
            // 
            this.last_req.Location = new System.Drawing.Point(12, 10);
            this.last_req.Name = "last_req";
            this.last_req.Size = new System.Drawing.Size(75, 25);
            this.last_req.TabIndex = 40;
            this.last_req.Text = "上一頁";
            this.last_req.UseVisualStyleBackColor = true;
            this.last_req.Click += new System.EventHandler(this.last_req_Click);
            // 
            // cancelreq
            // 
            this.cancelreq.Location = new System.Drawing.Point(126, 435);
            this.cancelreq.Name = "cancelreq";
            this.cancelreq.Size = new System.Drawing.Size(75, 23);
            this.cancelreq.TabIndex = 41;
            this.cancelreq.Text = "取消";
            this.cancelreq.UseVisualStyleBackColor = true;
            this.cancelreq.Click += new System.EventHandler(this.cancelreq_Click);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(247, 12);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 42;
            this.register.Text = "註冊帳號";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.messageDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // messageDataSet1
            // 
            this.messageDataSet1.DataSetName = "messageDataSet1";
            this.messageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::手機.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(344, 630);
            this.Controls.Add(this.register);
            this.Controls.Add(this.cancelreq);
            this.Controls.Add(this.last_req);
            this.Controls.Add(this.refusereq);
            this.Controls.Add(this.agreereq);
            this.Controls.Add(this.last_page_id);
            this.Controls.Add(this.Friend_join_id);
            this.Controls.Add(this.sendoutid);
            this.Controls.Add(this.id_select);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.frisuggestion);
            this.Controls.Add(this.IDsearch);
            this.Controls.Add(this.receivereq);
            this.Controls.Add(this.sendreq);
            this.Controls.Add(this.delete_friend);
            this.Controls.Add(this.check_data);
            this.Controls.Add(this.last_list);
            this.Controls.Add(this.request_not);
            this.Controls.Add(this.frifin);
            this.Controls.Add(this.frireq);
            this.Controls.Add(this.frilist);
            this.Controls.Add(this.changebgp);
            this.Controls.Add(this.sending);
            this.Controls.Add(this.messagecolumn);
            this.Controls.Add(this.lastpage_mes);
            this.Controls.Add(this.Chatting);
            this.Controls.Add(this.returntomain);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.passwordtitle);
            this.Controls.Add(this.useridtitle);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.accountmod);
            this.Controls.Add(this.addfriend);
            this.Controls.Add(this.themechange);
            this.Controls.Add(this.messagesend);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.TalkingWindow);
            this.Controls.Add(this.requestlist);
            this.Controls.Add(this.detailforrequest);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ShowInformation);
            this.Name = "main";
            this.Text = "訊息功能";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Button messagesend;
        private System.Windows.Forms.Button themechange;
        private System.Windows.Forms.Button addfriend;
        private System.Windows.Forms.Button accountmod;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label useridtitle;
        private System.Windows.Forms.Label passwordtitle;
        public System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button returntomain;
        private System.Windows.Forms.Button Chatting;
        private System.Windows.Forms.Button lastpage_mes;
        private System.Windows.Forms.TextBox TalkingWindow;
        private System.Windows.Forms.TextBox messagecolumn;
        private System.Windows.Forms.Button sending;
        private System.Windows.Forms.Button changebgp;
        private System.Windows.Forms.Button frilist;
        private System.Windows.Forms.Button frireq;
        private System.Windows.Forms.Button frifin;
        private System.Windows.Forms.Label request_not;
        private System.Windows.Forms.Button last_list;
        private System.Windows.Forms.Button check_data;
        private System.Windows.Forms.Button delete_friend;
        private System.Windows.Forms.Button sendreq;
        private System.Windows.Forms.Button receivereq;
        private System.Windows.Forms.Button IDsearch;
        private System.Windows.Forms.Button frisuggestion;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_select;
        private System.Windows.Forms.TextBox ShowInformation;
        private System.Windows.Forms.Button sendoutid;
        private System.Windows.Forms.Button Friend_join_id;
        private System.Windows.Forms.Button last_page_id;
        private System.Windows.Forms.ListBox requestlist;
        private System.Windows.Forms.TextBox detailforrequest;
        private System.Windows.Forms.Button agreereq;
        private System.Windows.Forms.Button refusereq;
        private System.Windows.Forms.Button last_req;
        private System.Windows.Forms.Button cancelreq;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.BindingSource bindingSource1;
        private messageDataSet1 messageDataSet1;
    }
}