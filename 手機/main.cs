using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 手機
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        accountset acc = new accountset();
        public string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDBFilename=|DataDirectory|message.mdf;" + "Integrated Security=True";
        public DataSet ds = new DataSet();
        public int bgpic = 0;
        public bool modify = false;
        public bool is_lived = false;
        public bool is_back = false;
        public void login_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            string thecommand = "SELECT ID,Password FROM UserData WHERE ID='" + userid.Text + "'AND Password='" + password.Text + "'";
            SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
            SqlDataReader reader = mysqlcommand.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("用戶" + userid.Text + "成功登入", "成功登入");
                userid.Hide(); useridtitle.Hide(); register.Hide();
                password.Hide(); passwordtitle.Hide(); login.Hide();
                messagesend.Show(); themechange.Show();
                addfriend.Show(); accountmod.Show(); logout.Show();
                title1.Text = "請選擇需要的功能:"; password.Text = "";
            }
            else
            {
                MessageBox.Show("用戶名或密碼不正確", "登入失敗");
            }
            reader.Close();
            db.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            title1.Text = "請輸入帳號密碼:";
            messagesend.Hide(); themechange.Hide(); Chatting.Hide(); lastpage_mes.Hide();
            addfriend.Hide(); accountmod.Hide(); logout.Hide(); listBox1.Hide(); returntomain.Hide();
            sending.Hide(); messagecolumn.Hide();
            TalkingWindow.Hide(); changebgp.Hide();
            frifin.Hide(); frilist.Hide(); frireq.Hide(); request_not.Hide(); last_list.Hide();
            check_data.Hide(); delete_friend.Hide(); sendreq.Hide(); receivereq.Hide();
            frisuggestion.Hide(); IDsearch.Hide();
            last_page_id.Hide(); id_label.Hide(); id_select.Hide(); sendoutid.Hide(); ShowInformation.Hide(); Friend_join_id.Hide(); last_page_id.Hide();
            last_req.Hide(); requestlist.Hide(); detailforrequest.Hide(); agreereq.Hide(); refusereq.Hide(); cancelreq.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("確定要登出嗎?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                messagesend.Hide(); themechange.Hide();
                addfriend.Hide(); accountmod.Hide(); logout.Hide();
                userid.Show(); useridtitle.Show();
                password.Show(); passwordtitle.Show(); login.Show(); register.Show();
                title1.Text = "請輸入帳號密碼:";
            }
        }

        private void messagesend_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            messagesend.Hide(); themechange.Hide(); returntomain.Show();
            addfriend.Hide(); accountmod.Hide(); logout.Hide(); Chatting.Show();
            listBox1.Show();
            title1.Text = "請選擇想要聊天的好友:";
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            string thecommand = "SELECT FriendID FROM Friend WHERE UserID='" + userid.Text + "'";
            SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
            SqlDataReader reader = mysqlcommand.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["FriendID"].ToString());
            }
            reader.Close();
            db.Close();
        }

        private void friendlist_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            messagesend.Hide(); themechange.Hide(); returntomain.Show();
            addfriend.Hide(); accountmod.Hide(); logout.Hide(); listBox1.Show();
            title1.Text = "請選擇想要改變的主題:";
            listBox1.Items.Add("星空"); listBox1.Items.Add("森林");
            listBox1.Items.Add("雪地"); listBox1.Items.Add("黃昏");
            is_back = true; changebgp.Show();

        }

        private void addfriend_Click(object sender, EventArgs e)
        {
            frifin.Show(); frilist.Show(); frireq.Show();
            messagesend.Hide(); themechange.Hide();
            addfriend.Hide(); accountmod.Hide(); logout.Hide(); returntomain.Show();
        }

        public void accountmod_Click(object sender, EventArgs e)
        {
            is_lived = true;
            acc.user_id = userid.Text;
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            string thecommand = "SELECT * FROM UserData WHERE ID=N'" + userid.Text + "'";
            SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
            SqlDataReader reader = mysqlcommand.ExecuteReader();
            while (reader.Read())
            {
                acc.id_input.Text = reader["ID"].ToString();
                acc.pw_input.Text = reader["Password"].ToString();
                acc.pw_re.Text = "";
                acc.surname_input.Text = reader["LastName"].ToString();
                acc.name_input.Text = reader["FirstName"].ToString();
                acc.phone_input.Text = reader["Phone"].ToString();
                acc.sign_input.Text = reader["Signature"].ToString();
            }
            reader.Close();

            acc.Show(this);
        }

        private void returntomain_Click(object sender, EventArgs e)
        {
            if (is_back == true)
            {
                listBox1.SelectedIndex = bgpic;
            }
            messagesend.Show(); themechange.Show();
            addfriend.Show(); accountmod.Show(); logout.Show();
            listBox1.Hide(); returntomain.Hide(); Chatting.Hide();
            frifin.Hide(); frilist.Hide(); frireq.Hide(); request_not.Hide();
            is_back = false; changebgp.Hide(); last_list.Hide();
            title1.Text = "請選擇需要的功能:";
        }

        private void Chatting_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("沒有進行選擇");
            }
            else
            {
                listBox1.Hide(); TalkingWindow.Show(); returntomain.Hide(); Chatting.Hide(); lastpage_mes.Show();
                title1.Text = listBox1.SelectedItem.ToString();
                sending.Show(); messagecolumn.Show();

            }

        }

        private void lastpage_mes_Click(object sender, EventArgs e)
        {
            listBox1.Show(); TalkingWindow.Hide(); returntomain.Show(); Chatting.Show(); lastpage_mes.Hide();
            title1.Text = "請選擇想要聊天的好友:";
            sending.Hide(); messagecolumn.Hide();
        }

        private void sending_Click(object sender, EventArgs e)
        {
            int amount = 0;
            TalkingWindow.Text += userid.Text + ":\r\n" + messagecolumn.Text + "\r\n" + DateTime.Now.ToLongTimeString() + DateTime.Now.ToLongDateString() + "\r\n\r\n";
            SqlConnection db = new SqlConnection(cn);
            db.Open();

            string counting = "SELECT * From Message";
            SqlCommand cmdd = new SqlCommand(counting, db);
            SqlDataReader rdd = cmdd.ExecuteReader();
            while (rdd.Read())
            {
                amount++;
            }
            string thecommand = "INSERT INTO Message(SendID,RecieveID,MessageID,Message,Time)VALUES(N'" + userid.Text + "',N'" + listBox1.SelectedItem.ToString() + "',N'0000000" + (amount + 1).ToString() + "',N'" + messagecolumn.Text + "',N'" + DateTime.Now.ToLongDateString().ToString() + DateTime.Now.ToLongTimeString().ToString() + "')";
            rdd.Close();
            SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
            SqlDataReader reader = mysqlcommand.ExecuteReader(); reader.Close();
            db.Close();
            messagecolumn.Text = "";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                if (modify == true)
                {
                    modify = false;
                    MessageBox.Show("按確定繼續", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("沒有進行選擇");
                }
            }
            else
            {

                TalkingWindow.Text = "";
                SqlConnection db = new SqlConnection(cn);
                db.Open();
                string thecommand = "SELECT SendID,Message,Time FROM Message WHERE (SendID=N'" + userid.Text + "'AND RecieveID=N'" + listBox1.SelectedItem.ToString() + "') OR " + "(RecieveID = N'" + userid.Text + "'AND SendID = N'" + listBox1.SelectedItem.ToString() + "') ORDER BY Time ASC";
                SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                SqlDataReader reader = mysqlcommand.ExecuteReader();
                while (reader.Read())
                {
                    string mgt = reader["Message"].ToString();
                    TalkingWindow.Text += reader["SendID"].ToString() + ":\r\n" + mgt + "\r\n" + reader["Time"].ToString() + "\r\n\r\n";
                }
                reader.Close();
                db.Close();
            }
            if (is_back == true)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    this.BackgroundImage = Image.FromFile(@"..\..\IMG\IMG\starry.jpg");
                }
                else if (listBox1.SelectedIndex == 1)
                {
                    this.BackgroundImage = Image.FromFile(@"..\..\IMG\IMG\forest.jpg");
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    this.BackgroundImage = Image.FromFile(@"..\..\IMG\IMG\snow.jpg");
                }
                else if (listBox1.SelectedIndex == 3)
                {
                    this.BackgroundImage = Image.FromFile(@"..\..\IMG\IMG\sunset.jpg");
                }
            }
        }

        private void changebgp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已成功更改!", "成功");
            bgpic = listBox1.SelectedIndex;
            messagesend.Show(); themechange.Show();
            addfriend.Show(); accountmod.Show(); logout.Show();
            listBox1.Hide(); returntomain.Hide(); Chatting.Hide();
            is_back = false; changebgp.Hide();
            title1.Text = "請選擇需要的功能:";
        }

        private void frilist_Click(object sender, EventArgs e)
        {
            check_data.Show(); delete_friend.Show();
            last_list.Show(); frifin.Hide(); frilist.Hide(); frireq.Hide(); request_not.Hide();
            listBox1.Items.Clear();
            listBox1.Show();
            title1.Text = "請選擇採取動作的好友:";
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            string thecommand = "SELECT FriendID FROM Friend WHERE UserID=N'" + userid.Text + "'";
            SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
            SqlDataReader reader = mysqlcommand.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["FriendID"].ToString());
            }
            reader.Close();
            db.Close();
        }

        private void frireq_Click(object sender, EventArgs e)
        {
            sendreq.Show(); receivereq.Show(); last_list.Show();
            frifin.Hide(); frilist.Hide(); frireq.Hide(); request_not.Hide();
        }

        private void frifin_Click(object sender, EventArgs e)
        {
            frisuggestion.Show(); IDsearch.Show(); frifin.Hide(); frilist.Hide(); frireq.Hide(); request_not.Hide();
            last_list.Show();
        }

        private void last_list_Click(object sender, EventArgs e)
        {
            last_list.Hide(); frifin.Show(); frilist.Show(); frireq.Show();
            title1.Text = "請選擇需要的功能:";
            check_data.Hide(); delete_friend.Hide(); listBox1.Hide();
            sendreq.Hide(); receivereq.Hide();
            frisuggestion.Hide(); IDsearch.Hide();
        }

        private void check_data_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("沒有選擇好友");
            }
            else
            {
                string thecommand = "SELECT * FROM UserData WHERE ID=N'" + listBox1.SelectedItem.ToString() + "'";
                SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                SqlDataReader reader = mysqlcommand.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("好友名字:" + reader["FirstName"].ToString() + " " + reader["LastName"].ToString() + "\n好友ID:" + reader["ID"].ToString() + "\n好友手機:" + reader["Phone"].ToString() + "\n個性簽名:\n" + reader["Signature"].ToString(), "會員資訊");
                }
                reader.Close();
            }
            db.Close();
        }

        private void delete_friend_Click(object sender, EventArgs e)
        {

            SqlConnection db = new SqlConnection(cn);
            db.Open();
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("沒有選擇好友");
            }
            else
            {
                DialogResult x = MessageBox.Show("確定刪除用戶" + listBox1.SelectedItem.ToString() + "嗎?", "刪除好友", MessageBoxButtons.OKCancel);
                string thecommand = "DELETE From Friend WHERE (UserID=N'" + userid.Text + "' AND FriendID=N'" + listBox1.SelectedItem.ToString() + "') OR (UserID=N'" + listBox1.SelectedItem.ToString() + "' AND FriendID='" + userid.Text + "')";
                if (x == DialogResult.OK)
                {
                    SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                    modify = true;
                    SqlDataReader reader = mysqlcommand.ExecuteReader();
                    MessageBox.Show("已刪除用戶，將跳轉上一頁" + listBox1.SelectedItem.ToString());
                    reader.Close();

                    last_list.Hide(); frifin.Show(); frilist.Show(); frireq.Show();
                    title1.Text = "請選擇需要的功能:";
                    check_data.Hide(); delete_friend.Hide(); listBox1.Hide();
                    sendreq.Hide(); receivereq.Hide();
                    frisuggestion.Hide(); IDsearch.Hide();
                }
            }
            db.Close();
        }

        private void sendreq_Click(object sender, EventArgs e)
        {
            string[] Friend = new string[1];
            string[] t_friend = new string[1];
            title1.Text = "送出的交友邀請";
            last_req.Show(); requestlist.Show(); detailforrequest.Show(); cancelreq.Show();
            requestlist.Items.Clear(); sendreq.Hide(); receivereq.Hide();
            detailforrequest.Text = "";
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            string thecommand = "SELECT FriendID From Friend WHERE UserID=N'" + userid.Text + "'";
            SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
            SqlDataReader reader = mysqlcommand.ExecuteReader();
            while (reader.Read())
            {
                Friend[Friend.Length - 1] = reader["FriendID"].ToString();
                Array.Resize(ref Friend, Friend.Length + 1);
            }
            reader.Close();
            Array.Resize(ref Friend, Friend.Length - 1);
            for (int i = 0; i < Friend.Length; i++)
            {

                thecommand = "SELECT UserID From Friend WHERE UserID=N'" + Friend[i] + "' AND FriendID=N'" + userid.Text + "'";
                mysqlcommand = new SqlCommand(thecommand, db); reader = mysqlcommand.ExecuteReader();
                while (reader.Read())
                {
                    t_friend[t_friend.Length - 1] = Friend[i];
                    Array.Resize(ref t_friend, t_friend.Length + 1);
                }
                reader.Close();
            }
            Array.Resize(ref t_friend, t_friend.Length - 1);
            int B_T = 0;
            while (B_T < t_friend.Length)
            {
                for (int i = 0; i < Friend.Length; i++)
                {
                    if (t_friend[B_T] == Friend[i])
                    {
                        Friend[i] = Friend[Friend.Length - 1];
                        Array.Resize(ref Friend, Friend.Length - 1);

                        break;
                    }

                }
                B_T++;
            }
            for (int i = 0; i < Friend.Length; i++)
            {
                requestlist.Items.Add(Friend[i]);

            }
            db.Close();
        }

        private void receivereq_Click(object sender, EventArgs e)
        {
            string[] Friend = new string[1];
            string[] t_friend = new string[1];
            title1.Text = "收到的交友邀請";
            last_req.Show(); requestlist.Show(); detailforrequest.Show(); agreereq.Show(); refusereq.Show();
            sendreq.Hide(); receivereq.Hide(); requestlist.Items.Clear();
            detailforrequest.Text = "";
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            string thecommand = "SELECT UserID From Friend WHERE FriendID=N'" + userid.Text + "'";
            SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
            SqlDataReader reader = mysqlcommand.ExecuteReader();
            while (reader.Read())
            {
                Friend[Friend.Length - 1] = reader["UserID"].ToString();
                Array.Resize(ref Friend, Friend.Length + 1);
            }
            reader.Close();
            Array.Resize(ref Friend, Friend.Length - 1);
            for (int i = 0; i < Friend.Length; i++)
            {

                thecommand = "SELECT FriendID From Friend WHERE UserID=N'" + userid.Text + "' AND FriendID=N'" + Friend[i] + "'";
                mysqlcommand = new SqlCommand(thecommand, db); reader = mysqlcommand.ExecuteReader();
                while (reader.Read())
                {
                    t_friend[t_friend.Length - 1] = Friend[i];
                    Array.Resize(ref t_friend, t_friend.Length + 1);
                }
                reader.Close();
            }
            Array.Resize(ref t_friend, t_friend.Length - 1);
            int B_T = 0;
            while (B_T < t_friend.Length)
            {
                for (int i = 0; i < Friend.Length; i++)
                {
                    if (t_friend[B_T] == Friend[i])
                    {
                        Friend[i] = Friend[Friend.Length - 1];
                        Array.Resize(ref Friend, Friend.Length - 1);

                        break;
                    }

                }
                B_T++;
            }
            for (int i = 0; i < Friend.Length; i++)
            {
                requestlist.Items.Add(Friend[i]);

            }
            db.Close();
        }
        public string join_id = "";
        private void sendoutid_Click(object sender, EventArgs e)
        {
            if (id_select.Text == "")
            {
                MessageBox.Show("未輸入任何資訊");
            }
            else
            {
                ShowInformation.Text = "";
                SqlConnection db = new SqlConnection(cn);
                db.Open();
                string thecommand = "SELECT * FROM UserData WHERE ID=N'" + id_select.Text + "'";
                SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                SqlDataReader reader = mysqlcommand.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("沒有找到用戶", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    while (reader.Read())
                    {
                        join_id = reader["ID"].ToString();
                        ShowInformation.Text += "姓名:" + reader["FirstName"].ToString() + " " + reader["LastName"].ToString() + "\r\nID:" + reader["ID"].ToString() + "\r\n\r\n個性簽名:\n\r" + reader["Signature"].ToString();
                    }
                }
                reader.Close();
                db.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int relation = 0;
            if (join_id == "")
            {
                MessageBox.Show("查無資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (join_id == userid.Text)
            {
                MessageBox.Show("難道你想加自己好友?", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection db = new SqlConnection(cn);
                db.Open();
                string thecommand = "SELECT * FROM Friend WHERE (UserID='" + userid.Text + "' AND FriendID='" + join_id + "') OR (UserID='" + join_id + "' AND FriendID='" + userid.Text + "')";
                SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                SqlDataReader reader = mysqlcommand.ExecuteReader();
                if (!reader.HasRows)
                {
                    reader.Close();
                    thecommand = "INSERT INTO Friend(UserID,FriendID)VALUES(N'" + userid.Text + "',N'" + join_id + "')";
                    mysqlcommand = new SqlCommand(thecommand, db);
                    reader = mysqlcommand.ExecuteReader();
                    MessageBox.Show("已成功提出申請，可傳送訊息給對方，但是等對方回覆申請後對方才可看到訊息", "成功");
                    reader.Close();
                }
                else
                {
                    while (reader.Read())
                    {
                        if (relation == 0 && reader["UserID"].ToString() == userid.Text)
                        {
                            relation = 1;
                        }
                        else if (relation == 0 && reader["FriendID"].ToString() == userid.Text)
                        {
                            relation = 2;
                        }
                        else if (relation != 0 && (reader["UserID"].ToString() == userid.Text || reader["FriendID"].ToString() == userid.Text))
                        {
                            relation = 3;
                        }
                    }
                    if (relation == 1)
                    {
                        MessageBox.Show("你已經對此用戶提出申請了，請到好友申請區確認", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (relation == 2)
                    {
                        MessageBox.Show("對方已對你提出申請，請到好友申請區確認", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (relation == 3)
                    {
                        MessageBox.Show("你們已經是朋友了", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    reader.Close();
                }
                db.Close();
            }
        }

        private void IDsearch_Click(object sender, EventArgs e)
        {
            join_id = "";
            ShowInformation.Text = "";
            id_select.Text = "";
            frisuggestion.Hide(); IDsearch.Hide(); last_list.Hide();
            last_page_id.Show(); title1.Text = "請輸入想加入的ID:";
            id_label.Show(); id_select.Show(); sendoutid.Show(); ShowInformation.Show(); Friend_join_id.Show();
        }

        private void frisuggestion_Click(object sender, EventArgs e)
        {
            string[] a = new string[1]; string[] b = new string[1];
            join_id = ""; ShowInformation.Text = ""; ShowInformation.Show(); Friend_join_id.Show(); last_page_id.Show();
            IDsearch.Hide(); frisuggestion.Hide();
            int amount = 0, B_amount = 0;
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            string counting = "SELECT * From Friend WHERE (UserID=N'" + userid.Text + "') OR (FriendID=N'" + userid.Text + "')";
            SqlCommand cmdd = new SqlCommand(counting, db);
            SqlDataReader rdd = cmdd.ExecuteReader();
            while (rdd.Read())
            {
                if (rdd["FriendID"].ToString() != userid.Text)
                {
                    b[B_amount] = rdd["FriendID"].ToString();
                    B_amount++;
                    Array.Resize(ref b, B_amount + 1);
                }
                else
                {
                    b[B_amount] = rdd["UserID"].ToString();
                    B_amount++;
                    Array.Resize(ref b, B_amount + 1);
                }
            }
            b[B_amount] = userid.Text;
            rdd.Close();
            counting = "SELECT ID From UserData";
            cmdd = new SqlCommand(counting, db);
            rdd = cmdd.ExecuteReader();
            while (rdd.Read())
            {
                if (rdd["ID"].ToString() != null || rdd["ID"].ToString() == "")
                {
                    a[amount] = rdd["ID"].ToString();
                    amount++;
                    Array.Resize(ref a, amount + 1);
                }
            }
            Array.Resize(ref a, amount);
            int B_T = 0;
            Random rnd = new Random();
            while (B_T < b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (b[B_T] == a[i])
                    {
                        a[i] = a[a.Length - 1];
                        Array.Resize(ref a, a.Length - 1);

                        break;
                    }

                }
                B_T++;
            }
            int x = rnd.Next(0, a.Length);
            join_id = a[x];

            rdd.Close();
            string thecommand = "SELECT * FROM UserData WHERE ID=N'" + join_id + "'";
            SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
            SqlDataReader reader = mysqlcommand.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("沒有找到用戶", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                while (reader.Read())
                {
                    join_id = reader["ID"].ToString();
                    ShowInformation.Text += "姓名:" + reader["FirstName"].ToString() + " " + reader["LastName"].ToString() + "\r\nID:" + reader["ID"].ToString() + "\r\n\r\n個性簽名:\n\r" + reader["Signature"].ToString();
                }
            }
            reader.Close();
            db.Close();

        }

        private void last_page_id_Click(object sender, EventArgs e)
        {
            frisuggestion.Show(); IDsearch.Show(); last_list.Show();
            title1.Text = "請選擇需要的功能:";
            last_page_id.Hide(); id_label.Hide(); id_select.Hide(); sendoutid.Hide(); ShowInformation.Hide(); Friend_join_id.Hide();
        }

        private void agreereq_Click(object sender, EventArgs e)
        {
            if (requestlist.SelectedItem == null)
            {
                MessageBox.Show("沒有選擇邀請");
            }
            else
            {
                DialogResult x = MessageBox.Show("確定同意這個交友邀請?", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (x == DialogResult.OK)
                {
                    SqlConnection db = new SqlConnection(cn);
                    db.Open();
                    string thecommand = "INSERT INTO Friend(UserID,FriendID)VALUES(N'" + userid.Text + "',N'" + requestlist.SelectedItem + "')";
                    SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                    modify = true;
                    SqlDataReader reader = mysqlcommand.ExecuteReader();
                    requestlist.SelectedItems.Clear();
                    reader.Close();
                    MessageBox.Show("已成功加入，將跳轉上一頁", "成功");
                    db.Close();

                    last_req.Hide(); requestlist.Hide(); detailforrequest.Hide(); agreereq.Hide(); refusereq.Hide(); cancelreq.Hide();
                    title1.Text = "請選擇需要的功能:"; receivereq.Show(); sendreq.Show();
                }
            }
        }

        private void refusereq_Click(object sender, EventArgs e)
        {
            if (requestlist.SelectedItem == null)
            {
                MessageBox.Show("沒有選擇邀請");
            }
            else
            {
                DialogResult x = MessageBox.Show("確定拒絕這個交友邀請?", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (x == DialogResult.OK)
                {
                    SqlConnection db = new SqlConnection(cn);
                    db.Open();
                    string thecommand = "DELETE From Friend WHERE UserID='" + requestlist.SelectedItem + "' AND FriendID='" + userid.Text + "'";
                    SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                    modify = true;
                    SqlDataReader reader = mysqlcommand.ExecuteReader();
                    requestlist.SelectedItems.Clear();
                    reader.Close();
                    MessageBox.Show("已成功拒絕，將跳轉上一頁", "成功");
                    db.Close();

                    last_req.Hide(); requestlist.Hide(); detailforrequest.Hide(); agreereq.Hide(); refusereq.Hide(); cancelreq.Hide();
                    title1.Text = "請選擇需要的功能:"; receivereq.Show(); sendreq.Show();
                }
            }
        }

        private void last_req_Click(object sender, EventArgs e)
        {
            last_req.Hide(); requestlist.Hide(); detailforrequest.Hide(); agreereq.Hide(); refusereq.Hide(); cancelreq.Hide();
            title1.Text = "請選擇需要的功能:"; receivereq.Show(); sendreq.Show();
        }
        private void cancelreq_Click(object sender, EventArgs e)
        {
            if (requestlist.SelectedItem == null)
            {
                MessageBox.Show("沒有選擇邀請");
            }
            else
            {
                DialogResult x = MessageBox.Show("確定取消這個交友邀請?", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (x == DialogResult.OK)
                {
                    SqlConnection db = new SqlConnection(cn);
                    db.Open();
                    string thecommand = "DELETE From Friend WHERE UserID='" + userid.Text + "' AND FriendID='" + requestlist.SelectedItem + "'";
                    SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                    modify = true;
                    SqlDataReader reader = mysqlcommand.ExecuteReader();
                    requestlist.SelectedItems.Clear();
                    reader.Close();
                    MessageBox.Show("已成功取消，將跳轉上一頁", "成功");
                    db.Close();

                    last_req.Hide(); requestlist.Hide(); detailforrequest.Hide(); agreereq.Hide(); refusereq.Hide(); cancelreq.Hide();
                    title1.Text = "請選擇需要的功能:"; receivereq.Show(); sendreq.Show();
                }
            }
        }

        private void requestlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (requestlist.SelectedItem == null)
            {
                if (modify == true)
                {
                    MessageBox.Show("按確定繼續", "", MessageBoxButtons.OK);
                    modify = false;
                }
                else
                {
                    MessageBox.Show("沒有選擇邀請");
                }

            }
            else
            {
                detailforrequest.Text = "";
                SqlConnection db = new SqlConnection(cn);
                db.Open();
                string thecommand = "SELECT * FROM UserData WHERE ID='" + requestlist.SelectedItem + "'";
                SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                SqlDataReader reader = mysqlcommand.ExecuteReader();
                while (reader.Read())
                {
                    detailforrequest.Text += "姓名:" + reader["FirstName"].ToString() + " " + reader["LastName"].ToString() + "\r\nID:" + reader["ID"].ToString() + "\r\n\r\n個性簽名:\n\r" + reader["Signature"].ToString();
                }
                reader.Close();
                db.Close();
            }
        }

        public void register_Click(object sender, EventArgs e)
        {
            is_lived = false;
            acc.id_input.Text = "";
            acc.pw_input.Text = "";
            acc.pw_re.Text = "";
            acc.surname_input.Text = "";
            acc.name_input.Text = "";
            acc.phone_input.Text = "";
            acc.sign_input.Text = "";
            acc.label2.Text = ""; acc.label2.ForeColor = Color.Red;
            acc.label3.Text = ""; acc.label3.ForeColor = Color.Red;
            acc.label4.Text = ""; acc.label4.ForeColor = Color.Red;

            acc.Show(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void id_select_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
