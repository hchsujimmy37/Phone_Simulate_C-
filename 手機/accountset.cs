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
    public partial class accountset : Form
    {
        public accountset()
        {
            InitializeComponent();
        }
        public string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" + @"AttachDBFilename=|DataDirectory|message.mdf;" + "Integrated Security=True";
        public DataSet ds = new DataSet();
        public string user_id;
        private void accountset_Load(object sender, EventArgs e)
        {

        }

        private void accountset_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main F1 = (main)this.Owner;
            if (surname_input.Text == "" || name_input.Text == "" || label2.ForeColor == Color.Red || label3.ForeColor == Color.Red || label4.ForeColor == Color.Red)
            {
                MessageBox.Show("資料仍有錯誤或缺漏，請修改後再送出", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (F1.is_lived == true)
                {
                    SqlConnection db = new SqlConnection(cn);
                    db.Open();
                    string thecommand = "UPDATE UserData SET ID='" + id_input.Text + "',FirstName=N'" + name_input.Text + "',LastName=N'" + surname_input.Text + "',Phone='" + phone_input.Text + "',Password=N'" + pw_input.Text + "',Signature=N'" + sign_input.Text + "' WHERE ID='" + F1.userid.Text + "'";
                    SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                    SqlDataReader reader = mysqlcommand.ExecuteReader();
                    reader.Close();
                    db.Close();
                    MessageBox.Show("成功修改帳號", "成功", MessageBoxButtons.OK);
                    this.Hide();
                }
                else
                {
                    SqlConnection db = new SqlConnection(cn);
                    db.Open();
                    string thecommand = "INSERT INTO UserData(ID,FirstName,LastName,Phone,Password,Signature)VALUES(N'" + id_input.Text + "',N'" + name_input.Text + "',N'" + surname_input.Text + "',N'" + phone_input.Text + "',N'" + pw_input.Text + "',N'" + sign_input.Text + "')";
                    SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                    SqlDataReader reader = mysqlcommand.ExecuteReader();
                    reader.Close();
                    db.Close();
                    MessageBox.Show("新增帳號成功，完成驗證手續後即可使用", "成功", MessageBoxButtons.OK);
                    this.Hide();
                }
            }
        }

        private void id_input_TextChanged(object sender, EventArgs e)
        {

            bool is_used = false;
            if (id_input.TextLength < 8)
            {
                label4.Text = "輸入至少8個字元";
                label4.ForeColor = Color.Red;
            }
            else
            {
                string[] used_id = new string[1];
                SqlConnection db = new SqlConnection(cn);
                db.Open();
                string thecommand = "SELECT ID From UserData";
                SqlCommand mysqlcommand = new SqlCommand(thecommand, db);
                SqlDataReader reader = mysqlcommand.ExecuteReader();
                while (reader.Read())
                {
                    used_id[used_id.Length - 1] = reader["ID"].ToString();
                    Array.Resize(ref used_id, used_id.Length + 1);
                }
                reader.Close();
                db.Close();
                for (int i = 0; i < used_id.Length - 1; i++)
                {
                    if (used_id[i] == id_input.Text)
                    {
                        is_used = true;
                        break;
                    }
                }
                if (is_used == true && user_id != id_input.Text)
                {
                    label4.Text = "此帳號已被使用";
                    label4.ForeColor = Color.Red;
                }
                else
                {
                    label4.Text = "ID可使用";
                    label4.ForeColor = Color.Green;
                }
            }
        }

        private void id_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;


            }
            else if ((e.KeyChar >= 96 && e.KeyChar <= 105) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == 8)
                    {
                        e.Handled = false;
                    }
                    else e.Handled = true;
                }
            }
        }

        private void pw_input_TextChanged(object sender, EventArgs e)
        {
            if (pw_input.TextLength < 6)
            {
                label2.Text = "輸入至少6個字元";
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.Text = "字元長度達到標準";
                label2.ForeColor = Color.Green;
            }
        }

        private void pw_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;


            }
            else if ((e.KeyChar >= 96 && e.KeyChar <= 105) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == 8)
                    {
                        e.Handled = false;
                    }
                    else e.Handled = true;
                }
            }
        }

        private void pw_re_TextChanged(object sender, EventArgs e)
        {
            if (pw_re.Text != pw_input.Text)
            {
                label3.Text = "和密碼不一致";
                label3.ForeColor = Color.Red;
            }
            else
            {
                label3.Text = "和密碼一致";
                label3.ForeColor = Color.Green;
            }
        }

        private void pw_re_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;


            }
            else if ((e.KeyChar >= 96 && e.KeyChar <= 105) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == 8)
                    {
                        e.Handled = false;
                    }
                    else e.Handled = true;
                }
            }
        }
    }
}
