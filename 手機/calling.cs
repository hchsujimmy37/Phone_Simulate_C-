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
    public partial class calling : Form
    {
        public calling()
        {
            InitializeComponent();
        }
        public int total_length = 0;
        public string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDBFilename=|DataDirectory|calling.mdf;" + "Integrated Security=True";
        public DataSet ds = new DataSet();
        private void calling_FormClosing(object sender, FormClosingEventArgs e)
        {
            call cal = (call)this.Owner;
            timer1.Stop();
            int run_time = 0;
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            string cmd = "SELECT * FROM CallRecord";
            SqlCommand sqlcmd = new SqlCommand(cmd, db);
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                run_time++;
            }
            reader.Close();
            cmd = "UPDATE CallRecord SET CallLength='" + total_length + "' WHERE CallId='" + run_time + "'";
            sqlcmd = new SqlCommand(cmd, db);
            reader = sqlcmd.ExecuteReader();
            reader.Close();
            db.Close();

            clicker.Stop();
            cal.call_number.Text = "";
            e.Cancel = true;
            Hide();
            cal.Show();
        }
        public SoundPlayer clicker = new SoundPlayer("./music/嘟嘟聲.wav");
        private void calling_Load(object sender, EventArgs e)
        {
            accept_accept.Hide(); accept_reject.Hide();
            timer1.Start();
            clicker.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            total_length++;
        }

        private void call_over_Click(object sender, EventArgs e)
        {
            call cal = (call)this.Owner;
            timer1.Stop();
            int run_time = 0;
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            string cmd = "SELECT * FROM CallRecord";
            SqlCommand sqlcmd = new SqlCommand(cmd, db);
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                run_time++;
            }
            reader.Close();
            cmd = "UPDATE CallRecord SET CallLength='" + total_length + "' WHERE CallId='" + run_time + "'";
            sqlcmd = new SqlCommand(cmd, db);
            reader = sqlcmd.ExecuteReader();
            reader.Close();
            db.Close();

            clicker.Stop();
            cal.call_number.Text = "";
            Hide();
            cal.Show();
        }
    }
}
