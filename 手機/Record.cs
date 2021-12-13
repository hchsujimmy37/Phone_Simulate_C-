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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }
        public string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDBFilename=|DataDirectory|calling.mdf;" + "Integrated Security=True";
        public DataSet ds = new DataSet();
        private void choose_Delete_Click(object sender, EventArgs e)
        {
            call cal = (call)this.Owner;
            if (call_list.SelectedItems == null)
            {
                MessageBox.Show("沒有進行選擇");
            }
            else
            {
                DialogResult x = MessageBox.Show("真的要刪除這筆紀錄?", "警告", MessageBoxButtons.OKCancel);
                if (x == DialogResult.OK)
                {
                    SqlConnection db = new SqlConnection(cn);
                    db.Open();
                    string cmd = "DELETE FROM CallRecord WHERE HappenTime=N'" + r_time.Text + "'";
                    SqlCommand sqlcmd = new SqlCommand(cmd, db);
                    SqlDataReader reader = sqlcmd.ExecuteReader();
                    reader.Close();
                    MessageBox.Show("已成功刪除");
                    db.Close();
                    Hide(); cal.Show();
                }
            }
        }

        private void delete_all_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("真的要刪除全部紀錄?", "警告", MessageBoxButtons.OKCancel);
            if (x == DialogResult.OK)
            {
                call cal = (call)this.Owner;
                SqlConnection db = new SqlConnection(cn);
                db.Open();
                string cmd = "DELETE FROM CallRecord";
                SqlCommand sqlcmd = new SqlCommand(cmd, db);
                SqlDataReader reader = sqlcmd.ExecuteReader();
                reader.Close();
                MessageBox.Show("已成功全部刪除");
                db.Close();
                Hide(); cal.Show();
            }
        }
        private void Record_FormClosing(object sender, FormClosingEventArgs e)
        {
            call cal = (call)this.Owner;
            e.Cancel = true;
            Hide();
            cal.Show();
        }

        private void Record_Load(object sender, EventArgs e)
        {
        }

        private void call_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (call_list.SelectedItems == null)
            {
                MessageBox.Show("沒有進行選擇");
            }
            else
            {
                int ranked = 0;
                SqlConnection db = new SqlConnection(cn);
                db.Open();
                string cmd = "SELECT * FROM CallRecord ORDER BY HappenTime ASC";
                SqlCommand sqlcmd = new SqlCommand(cmd, db);
                SqlDataReader reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    if (call_list.SelectedIndex == ranked)
                    {
                        r_name.Text = reader["Receiver"].ToString();
                        r_length.Text = reader["CallLength"].ToString() + "秒";
                        r_time.Text = reader["HappenTime"].ToString();
                    }
                    ranked++;
                }
                reader.Close();
                db.Close();
            }
        }
    }
}
