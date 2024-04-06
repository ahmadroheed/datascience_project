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

namespace datascience_project
{
    public partial class Form1 : Form
    {
        int category_id;
        public Form1()
        {
            InitializeComponent();
        }
        public void clearFields()
        {
            textbox_categoryname.Clear();
        }
        public void showcategoryInformation()
        {
            // TODO: This line of code loads data into the 'datasience_dbDataSet.tbl_category' table. You can move, or remove it, as needed.
            this.tbl_categoryTableAdapter.Fill(this.datasience_dbDataSet.tbl_category);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showcategoryInformation();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(textbox_categoryname.Text != "")
            {
                try
                {

                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tbl_category values (@category_name)", con);
                    cmd.Parameters.AddWithValue("@category_name", textbox_categoryname.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category information added successfully.");
                    showcategoryInformation();
                    clearFields();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;  
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null) { 
               textbox_categoryname.Text = row.Cells[1].Value.ToString();
                category_id = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textbox_categoryname.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update tbl_category set category_name = @category_name where categoryid = @categoryid", con);
                    cmd.Parameters.AddWithValue("@category_name", textbox_categoryname.Text);
                    cmd.Parameters.AddWithValue("@categoryid", category_id);
                    cmd.ExecuteNonQuery();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    MessageBox.Show("Category information updated successfully.");
                    showcategoryInformation();
                    clearFields();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from tbl_category where categoryid = @categoryid", con);
                cmd.Parameters.AddWithValue("@categoryid", category_id);
                cmd.ExecuteNonQuery();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
                MessageBox.Show("Category information deleted successfully.");
                showcategoryInformation();
                clearFields();
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
            if(LoginPage.role != "Admin")
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
