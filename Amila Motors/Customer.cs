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

namespace Amila_Motors
{
    public partial class Customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIHANGAHP\SQLEXPRESS;Initial Catalog=amilamotors;Integrated Security=True");
        public Customer()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerCareAssistantDashboard customerCareAssistantDashboard = new CustomerCareAssistantDashboard();
            this.Hide();
            customerCareAssistantDashboard.Show();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            con.Open();
            string query_select = "SELECT * FROM customer_table";
            SqlCommand cmnd = new SqlCommand(query_select, con);
            SqlDataReader row = cmnd.ExecuteReader();
            cmbCID.Items.Add("New Register");
            while (row.Read())
            {
                cmbCID.Items.Add(row[0].ToString());
            }
            row.Close();
            string query_select2 = "SELECT userID FROM user_table";
            SqlCommand comm = new SqlCommand(query_select2, con);
            SqlDataReader row2 = comm.ExecuteReader();
            while (row2.Read())
            {
                cmbUID.Items.Add(row2[0].ToString());
            }
            con.Close();

        }

        private void cmbCID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string no = cmbCID.Text;
            if(no!="New Register")
            {
                con.Open();
                string query_select = "SELECT * FROM customer_table WHERE customerID =" + no;
                SqlCommand cmnd = new SqlCommand(query_select, con);
                SqlDataReader row = cmnd.ExecuteReader();
                while (row.Read())
                {
                    txtName.Text = row[1].ToString();
                    txtNIC.Text = row[2].ToString();   
                    txtContact.Text = row[3].ToString();
                    txtEmail.Text = row[4].ToString();
                    txtAddress.Text = row[5].ToString();
                    cmbStatus.Text = row[6].ToString();
                    cmbUID.Text = row[7].ToString();

                }
                con.Close();
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                txtName.Text = "";
                txtNIC.Text = "";
                txtContact.Text = "";
                txtEmail.Text = "";
                txtAddress.Text = "";
                cmbUID.Text = "";
                cmbStatus.Text = "";
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query_insert = "INSERT INTO customer_table (customerName, customerNIC, customerContact, customerEmail, customerAddress, userID, status) " +
                                      "VALUES (@customerName, @customerNIC, @customerContact, @customerEmail, @customerAddress, @userID, @status)";


                SqlCommand cmd = new SqlCommand(query_insert, con);
                cmd.Parameters.AddWithValue("@customerName", this.txtName.Text);
                cmd.Parameters.AddWithValue("@customerNIC", this.txtNIC.Text);
                cmd.Parameters.AddWithValue("@customerContact", this.txtContact.Text);
                cmd.Parameters.AddWithValue("@customerEmail", this.txtEmail.Text);
                cmd.Parameters.AddWithValue("@customerAddress", this.txtAddress.Text);
                cmd.Parameters.AddWithValue("@userID", this.cmbUID.Text);
                cmd.Parameters.AddWithValue("@status", this.cmbStatus.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer record added successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query_update = "UPDATE customer_table SET customerName = @customerName, customerNIC = @customerNIC, " +
                                      "customerContact = @customerContact, customerEmail = @customerEmail, " +
                                      "customerAddress = @customerAddress, userID = @userID, status = @status " +
                                      "WHERE customerID = @customerID";

                SqlCommand cmd = new SqlCommand(query_update, con);
                cmd.Parameters.AddWithValue("@customerID", this.cmbCID.Text);
                cmd.Parameters.AddWithValue("@customerName", this.txtName.Text);
                cmd.Parameters.AddWithValue("@customerNIC", this.txtNIC.Text);
                cmd.Parameters.AddWithValue("@customerContact", this.txtContact.Text);
                cmd.Parameters.AddWithValue("@customerEmail", this.txtEmail.Text);
                cmd.Parameters.AddWithValue("@customerAddress", this.txtAddress.Text);
                cmd.Parameters.AddWithValue("@userID", this.cmbUID.Text);
                cmd.Parameters.AddWithValue("@status", this.cmbStatus.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer record updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query_delete = "DELETE FROM customer_table WHERE customerID = @customerID";

                SqlCommand cmd = new SqlCommand(query_delete, con);
                cmd.Parameters.AddWithValue("@customerID", this.cmbCID.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer record deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
