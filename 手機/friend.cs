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
    public partial class friend : Form
    {
        public friend()
        {
            InitializeComponent();
        }
        public string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDBFilename=|DataDirectory|calling.mdf;" + "Integrated Security=True";
        public DataSet ds = new DataSet();
        private void friend_Load(object sender, EventArgs e)
        {
            
        }
        modify_call mc = new modify_call();
        private void friend_FormClosing(object sender, FormClosingEventArgs e)
        {
            call fd = (call)this.Owner;
            e.Cancel = true;
            Hide();
            fd.Show();
        }
        calling fc = new calling();
        private void accept_accept_Click(object sender, EventArgs e)
        {

            call fd = (call)this.Owner;
            fd.call_number.Text = f_phone.Text;
            Hide();
            fd.Show();
        }
        public bool specfic = true;
        private void modify_friend_Click(object sender, EventArgs e)
        {
            specfic = true;
            mc.Show(this);
        }

        private void join_fri_Click(object sender, EventArgs e)
        {
            specfic = false;
            mc.Show(this);
        }

        private void friend_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (friend_list.SelectedItems == null)
            {
                MessageBox.Show("沒有進行選擇");
            }
            else
            {
                int ranked = 0;
                SqlConnection db = new SqlConnection(cn);
                db.Open();
                string cmd = "SELECT * FROM Friendlist";
                SqlCommand sqlcmd = new SqlCommand(cmd, db);
                SqlDataReader reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    if (friend_list.SelectedIndex == ranked)
                    {
                        f_Name.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                        f_phone.Text = reader["PhoneNumber"].ToString();
                    }
                    ranked++;
                }
                reader.Close();
                db.Close();
            }

        }
    }
}
