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
    public partial class modify_call : Form
    {
        public modify_call()
        {
            InitializeComponent();
        }
        public string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDBFilename=|DataDirectory|calling.mdf;" + "Integrated Security=True";
        public DataSet ds = new DataSet();
        private void modify_call_Load(object sender, EventArgs e)
        {

        }
        private void modify_call_FormClosing(object sender, FormClosingEventArgs e)
        {
            friend ca = (friend)this.Owner;
            e.Cancel = true;
            Hide();
            ca.Show();
        }

        private void friok_Click(object sender, EventArgs e)
        {
            string fid = "0000001";
            friend ca = (friend)this.Owner;
            bool mod = false;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("有欄位缺少值");
            }
            else if (ca.specfic == false)
            {
                int newest = 1;
                SqlConnection db = new SqlConnection(cn);
                db.Open();
                string thecommand = "SELECT * FROM Friendlist";
                SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                SqlDataReader reader = mysqlcommand.ExecuteReader();
                while (reader.Read())
                {
                    if ((reader["FirstName"].ToString() + " " + reader["LastName"].ToString()) == textBox2.Text + " " + textBox1.Text)
                    {
                        DialogResult x = MessageBox.Show("已經有相同名字，是否創立同樣名字的資料", "警告", MessageBoxButtons.OKCancel);
                        if (x == DialogResult.OK)
                        {
                            mod = false;
                        }
                        else
                        {
                            mod = true; fid = reader["FriendId"].ToString();
                            break;
                        }
                    }
                    newest++;
                    fid = "000000" + newest.ToString();

                }
                reader.Close();
                if (mod == true)
                {
                    thecommand = "UPDATE Friendlist SET FirstName=N'" + textBox2.Text + "',LastName=N'" + textBox1.Text + "',PhoneNumber='" + textBox3.Text + "' WHERE FriendId='" + fid + "'";
                    mysqlcommand = new SqlCommand(thecommand, db);
                    reader = mysqlcommand.ExecuteReader();
                    reader.Close();
                    MessageBox.Show("更新成功");
                }
                else
                {
                    thecommand = "INSERT INTO Friendlist(FriendId,FirstName,LastName,PhoneNumber) VALUES('" + fid + "',N'" + textBox2.Text + "',N'" + textBox1.Text + "',N'" + textBox3.Text + "')";
                    mysqlcommand = new SqlCommand(thecommand, db);
                    reader = mysqlcommand.ExecuteReader();
                    reader.Close();
                    MessageBox.Show("建立成功");
                }
                db.Close();
                Hide();
            }
            else
            {
                SqlConnection db = new SqlConnection(cn);
                db.Open();
                string thecommand = "UPDATE Friendlist SET FirstName=N'" + textBox2.Text + "',LastName=N'" + textBox1.Text + "',PhoneNumber='" + textBox3.Text + "' WHERE FriendId='000000" + (ca.friend_list.SelectedIndex + 1) + "'";
                SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                SqlDataReader reader = mysqlcommand.ExecuteReader();
                reader.Close();
                MessageBox.Show("更新成功");
                db.Close();
                Hide();
            }

        }

        private void fri_can_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
