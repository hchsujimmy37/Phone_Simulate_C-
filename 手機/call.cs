using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;

namespace 手機
{
    public partial class call : Form
    {
        public call()
        {
            InitializeComponent();
        }
        private void back_text_Click(object sender, EventArgs e)
        {
            string s = call_number.Text;
            if (s.Length > 1)
            {
                call_number.Text = s.Substring(0, s.Length - 1);
            }
            else
            {
                call_number.Text = "";
            }
        }
        SoundPlayer clicker = new SoundPlayer("./music/按鈕.wav");
        public string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDBFilename=|DataDirectory|calling.mdf;" + "Integrated Security=True";
        public DataSet ds = new DataSet();
        private void No1_Click(object sender, EventArgs e)
        {
            call_number.Text += No1.Text;
            clicker.Play();

        }

        private void No2_Click(object sender, EventArgs e)
        {
            call_number.Text += No2.Text;
            clicker.Play();
        }

        private void No3_Click(object sender, EventArgs e)
        {
            call_number.Text += No3.Text;
            clicker.Play();
        }

        private void No4_Click(object sender, EventArgs e)
        {
            call_number.Text += No4.Text;
            clicker.Play();
        }

        private void No5_Click(object sender, EventArgs e)
        {
            call_number.Text += No5.Text;
            clicker.Play();
        }

        private void No6_Click(object sender, EventArgs e)
        {
            call_number.Text += No6.Text;
            clicker.Play();
        }

        private void No7_Click(object sender, EventArgs e)
        {
            call_number.Text += No7.Text;
            clicker.Play();
        }

        private void No8_Click(object sender, EventArgs e)
        {
            call_number.Text += No8.Text;
            clicker.Play();
        }

        private void No9_Click(object sender, EventArgs e)
        {
            call_number.Text += No9.Text;
            clicker.Play();
        }

        private void NoStar_Click(object sender, EventArgs e)
        {
            call_number.Text += NoStar.Text;
            clicker.Play();
        }

        private void No0_Click(object sender, EventArgs e)
        {
            call_number.Text += No0.Text;
            clicker.Play();
        }

        private void NoX_Click(object sender, EventArgs e)
        {
            call_number.Text += NoX.Text;
            clicker.Play();
        }

        private void call_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void call_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                call_number.Text += No1.Text;
            }
        }

        private void call_Load(object sender, EventArgs e)
        {

        }
        calling fc = new calling();
        Record rd = new Record();
        friend fd = new friend();
        private void call_b_Click(object sender, EventArgs e)
        {
            bool is_true = false;
            string user_name = "";
            if (call_number.Text != "")
            {
                int run_time = 0;
                string new_id = "";
                SqlConnection db = new SqlConnection(cn);
                db.Open();
                string cmd = "SELECT * FROM CallRecord";
                SqlCommand sqlcmd = new SqlCommand(cmd, db);
                SqlDataReader reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    new_id = reader["CallId"].ToString();
                }
                run_time = int.Parse(new_id)+1;
                new_id = run_time.ToString();
                reader.Close();
                cmd = "INSERT INTO CallRecord(CallId,Sender,Receiver,HappenTime,CallLength)VALUES ('" +new_id + "',N'Me',N'" + call_number.Text + "',N'" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + "','0')";
                sqlcmd = new SqlCommand(cmd, db);
                reader = sqlcmd.ExecuteReader();
                reader.Close();
                cmd = "SELECT * FROM Friendlist WHERE PhoneNumber='" + call_number.Text + "'";
                sqlcmd = new SqlCommand(cmd, db);
                reader = sqlcmd.ExecuteReader();
                user_name = call_number.Text;
                while (reader.Read())
                {
                    user_name = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                    is_true = true;
                }
                reader.Close();
                cmd = "UPDATE CallRecord SET Receiver=N'" + user_name + "' WHERE Receiver=N'" + call_number.Text + "'";
                fc.call_name.Text = user_name;
                sqlcmd = new SqlCommand(cmd, db);
                reader = sqlcmd.ExecuteReader();
                reader.Close();
                db.Close();
                fc.total_length = 0;
                fc.timer1.Start();
                fc.clicker.PlayLooping();
                fc.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("沒有輸入電話號碼");
            }
        }

        private void frilist_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            fd.friend_list.Items.Clear();
            string cmd = "SELECT * FROM Friendlist";
            SqlCommand sqlcmd = new SqlCommand(cmd, db);
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                fd.friend_list.Items.Add(reader["FirstName"].ToString() + " " + reader["LastName"].ToString());
            }
            reader.Close();
            db.Close();

            fd.Show(this);
            Hide();
        }

        private void record_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            rd.call_list.Items.Clear();
            string cmd = "SELECT * FROM CallRecord ORDER BY HappenTime ASC";
            SqlCommand sqlcmd = new SqlCommand(cmd, db);
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                rd.call_list.Items.Add(reader["Receiver"].ToString());
            }
            reader.Close();
            db.Close();
            rd.Show(this);
            Hide();
        }

        private void call_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            e.Cancel = true;
            Hide();
            f1.Show();
        }
    }
}
