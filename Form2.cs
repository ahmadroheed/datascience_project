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
//using Excel = Microsoft.Office.Interop.Excel;

namespace datascience_project
{
    public partial class Form2 : Form
    {
        int link_id;
        public Form2()
        {
            InitializeComponent();
        }
        public void showInformation()
        {
            // TODO: This line of code loads data into the 'datasience_dbDataSet3.subcategory' table. You can move, or remove it, as needed.
            this.subcategoryTableAdapter.Fill(this.datasience_dbDataSet3.subcategory);
            // TODO: This line of code loads data into the 'datasience_dbDataSet2.link' table. You can move, or remove it, as needed.
            this.linkTableAdapter.Fill(this.datasience_dbDataSet2.link);
            // TODO: This line of code loads data into the 'datasience_dbDataSet7.link' table. You can move, or remove it, as needed.
            this.linkTableAdapter2.Fill(this.datasience_dbDataSet7.link);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            showInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ddl_sub_category_name.Text != "" || ddll_link_type.Text != "" || textbox_link_text.Text != "" || textbox_sub_link_text.Text != "" || textbox_link_content.Text !="")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("  INSERT INTO link VALUES (@link_text,@sub_link_text,@link_content,@link_type,@sub_category_id,@user_fullname,@date)", con);
                    cmd.Parameters.AddWithValue("@link_text", textbox_link_text.Text);
                    cmd.Parameters.AddWithValue("@sub_link_text", textbox_sub_link_text.Text);
                    cmd.Parameters.AddWithValue("@link_content", textbox_link_content.Text);
                    cmd.Parameters.AddWithValue("@link_type", ddll_link_type.Text);
                    cmd.Parameters.AddWithValue("@sub_category_id", ddl_sub_category_name.SelectedValue);
                    cmd.Parameters.AddWithValue("@user_fullname", LoginPage.fullname);
                    cmd.Parameters.AddWithValue("@date", datetime.Value);
                    cmd.ExecuteNonQuery();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    MessageBox.Show("link information added successfully.");
                    showInformation();
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

        public void clearFields()
        {
            textbox_link_content.Clear();
            textbox_link_text.Clear();
            textbox_sub_link_text.Clear();
            ddl_sub_category_name.SelectedIndex = 0;
            ddll_link_type.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                textbox_link_text.Text = row.Cells[1].Value.ToString();
                textbox_sub_link_text.Text = row.Cells[2].Value.ToString();
                textbox_link_content.Text = row.Cells[3].Value.ToString();
                ddll_link_type.Text = row.Cells[4].Value.ToString();
                ddl_sub_category_name.SelectedText = row.Cells[0].Value.ToString();
                link_id = int.Parse(row.Cells[0].Value.ToString());
                if (DateTime.TryParse(row.Cells[5].Value?.ToString(), out DateTime linkDate))
                {
                    datetime.Value = linkDate;
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ddl_sub_category_name.Text != "" || ddll_link_type.Text != "" || textbox_link_text.Text != "" || textbox_sub_link_text.Text != "" || textbox_link_content.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update link set link_text = @link_text,sub_link_text = @sub_link_text,link_content = @link_content,link_type = @link_type,sub_category_id = @sub_category_id,@fullname=fullname,date=@date where link_id = @link_id", con);
                    cmd.Parameters.AddWithValue("@link_text", textbox_link_text.Text);
                    cmd.Parameters.AddWithValue("@sub_link_text", textbox_sub_link_text.Text);
                    cmd.Parameters.AddWithValue("@link_content", textbox_link_content.Text);
                    cmd.Parameters.AddWithValue("@link_type", ddll_link_type.Text);
                    cmd.Parameters.AddWithValue("@sub_category_id", ddl_sub_category_name.SelectedValue);
                    cmd.Parameters.AddWithValue("@link_id", link_id);
                    cmd.Parameters.AddWithValue("@fullname", LoginPage.fullname);
                    cmd.Parameters.AddWithValue("@date", datetime.Value);
                    cmd.ExecuteNonQuery();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    MessageBox.Show("link information updated successfully.");
                    showInformation();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
                try
                {
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                    SqlCommand cmd = new SqlCommand("delete link where link_id = @link_id ", con);
                    cmd.Parameters.AddWithValue("@link_id", link_id);
                    cmd.ExecuteNonQuery();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    MessageBox.Show("link information deleted successfully.");
                    showInformation();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1 == null || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false; // Set to true if you want to see Excel in action
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Sheets[1];

            // Export headers
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            // Export data
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    object cellValue = dataGridView1.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j + 1] = cellValue != null ? cellValue.ToString() : "";
                }
            }

            workbook.SaveAs("Downloads");
            workbook.Close();
            excelApp.Quit();

            // Clean up Excel objects
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            MessageBox.Show("Data exported successfully!", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
