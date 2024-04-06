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

namespace datascience_project
{
    public partial class LoginPage : Form
    {
        public static string fullname;
        public static string role;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textbox_username.Text != "" || textbox_password.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from users where username='"+textbox_username.Text+"' and password ='"+textbox_password.Text+"'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if(dt.Rows.Count > 0 )
                    {
                        fullname = dt.Rows[0][3].ToString();
                        role = dt.Rows[0][4].ToString();
                        this.Hide();
                        new Form3().ShowDialog();
                    }
                    else {
                        MessageBox.Show("Invalid username or password");
                    }
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
