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
    public partial class SubCategoryInformation : Form
    {
        int sub_category_id;
        public SubCategoryInformation()
        {
            InitializeComponent();
            
        }
        public void clearFields()
        {
            textbox_sub_categoryname.Text = string.Empty;
            ddl_category_name.SelectedIndex = 0;
        }
        public void showcategoryInformation()
        {
            // TODO: This line of code loads data into the 'datasience_dbDataSet.tbl_category' table. You can move, or remove it, as needed.
            this.tbl_categoryTableAdapter.Fill(this.datasience_dbDataSet.tbl_category);
        }
        public void showSubcategoryInformation()
        {
            // TODO: This line of code loads data into the 'datasience_dbDataSet1.subcategory' table. You can move, or remove it, as needed.
            this.subcategoryTableAdapter.Fill(this.datasience_dbDataSet1.subcategory);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textbox_sub_categoryname.Text != "" || ddl_category_name.Text !="")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into subcategory values (@subcategoryname,@category_id)", con);
                    cmd.Parameters.AddWithValue("@subcategoryname", textbox_sub_categoryname.Text);
                    cmd.Parameters.AddWithValue("@category_id", int.Parse(ddl_category_name.SelectedValue.ToString()));
                    cmd.ExecuteNonQuery();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    MessageBox.Show("Sub Category information updated successfully.");
                    showSubcategoryInformation();
                    clearFields();
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all field");
            }
        }

        private void SubCategoryInformation_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            showcategoryInformation();
            showSubcategoryInformation();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textbox_sub_categoryname.Text != "" || ddl_category_name.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update subcategory set subcategory_name = @subcategory_name,category_id= @category_id where subcategory_id = @subcategory_id", con);
                    cmd.Parameters.AddWithValue("@subcategory_name", textbox_sub_categoryname.Text);
                    cmd.Parameters.AddWithValue("@category_id", ddl_category_name.SelectedValue);
                    cmd.Parameters.AddWithValue("@subcategory_id", sub_category_id);
                    cmd.ExecuteNonQuery();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    MessageBox.Show("sub category information updated successfully.");
                    showSubcategoryInformation();
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
            if (row != null)
            {
                textbox_sub_categoryname.Text = row.Cells[1].Value.ToString();
                ddl_category_name.SelectedValue = int.Parse(row.Cells[2].Value.ToString());
                sub_category_id = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from subcategory where subcategory_id = @subcategory_id", con);
                cmd.Parameters.AddWithValue("@subcategory_id", sub_category_id);
                cmd.ExecuteNonQuery();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
                MessageBox.Show("Sub category information deleted successfully.");
                showSubcategoryInformation();
                clearFields();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
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
