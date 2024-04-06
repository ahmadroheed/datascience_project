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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            getTotalCategory();
            gettotalSubCategory();
            gettotalLinks();
            gettotalUsers();
        }


        public void getTotalCategory()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("select count(categoryid) from tbl_category",con);
                int total_categories = int.Parse(sqlCommand.ExecuteScalar().ToString());
                label_total_category.Text = total_categories.ToString();
                con.Close();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
        public void gettotalSubCategory()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("select count(subcategory_id) from subcategory", con);
                int total_sub_categories = int.Parse(sqlCommand.ExecuteScalar().ToString());
                label_total_sub_category.Text = total_sub_categories.ToString();
                con.Close();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
        public void gettotalLinks()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("select count(link_id) from link", con);
                int total_links = int.Parse(sqlCommand.ExecuteScalar().ToString());
                label_total_links.Text = total_links.ToString();
                con.Close();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
        public void gettotalUsers()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("select count(userid) from users", con);
                int total_users = int.Parse(sqlCommand.ExecuteScalar().ToString());
                label_total_users.Text = total_users.ToString();
                con.Close();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SubCategoryInformation().ShowDialog();
        }

        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginPage.role != "Admin")
            {
                MessageBox.Show("you don't have permission to access this section");
            }
            else
            {
                this.Hide();
                new user_management().ShowDialog();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().ShowDialog();
        }
    }
}
