using homework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Text;
                SqlConnection conn = null;
                using (conn = new SqlConnection(Settings.Default.PhotoConnectionString))
                {
                    SqlCommand Command = new SqlCommand();

                    Command.CommandText = $"Insert into YourMember(userName,Password) values(@UserName,@Password)";
                    Command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = username;
                    Command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = password;

                    //==========================================

                    //SqlParameter p1 = new SqlParameter();
                    //p1.ParameterName = "@Password";
                    //p1.SqlDbType = SqlDbType.NVarChar;
                    //p1.Size = 40;
                    //p1.Value = password;
                    //Command.Parameters.Add(p1);

                    //==========================================
                    Command.Connection = conn;
                    conn.Open();
                    Command.ExecuteNonQuery();
                    MessageBox.Show("Insert Member Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            SqlConnection conn = null;
            using (conn = new SqlConnection(Settings.Default.PhotoConnectionString))
            {
                SqlCommand Command = new SqlCommand();
                Command.CommandText = "Select * from YourMember where userName= @UserName and password = @Password";
                Command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = username;
                Command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = password;
                Command.Connection = conn;
                conn.Open();
                SqlDataReader DataReader = Command.ExecuteReader();
                if (DataReader.HasRows)
                {
                    MessageBox.Show($"{username} : 登入成功");
                    FrmCustomers frmCustomers = new FrmCustomers();
                    frmCustomers.Show();
                }
                else
                {
                    MessageBox.Show("登入失敗");
                }
            }
        }

        private void FrmLogon_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void FrmLogon_KeyDown(object sender, KeyEventArgs e)
        {
            // username(U),password(P),yes(O),cancel(c),
            if(e.KeyCode == Keys.U && e.Control)
            {
                UsernameTextBox.Focus();
            }
            if (e.KeyCode == Keys.P && e.Control)
            {
                PasswordTextBox.Focus();
            }

            if (e.KeyCode == Keys.O && e.Control)
            {
                OK.PerformClick();
            }
            if (e.KeyCode == Keys.C && e.Control)
            {
                this.Close();
            }
        }
    }
}
