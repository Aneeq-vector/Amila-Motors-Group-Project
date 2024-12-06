using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Amila_Motors
{
    public partial class Job : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIHANGAHP\SQLEXPRESS;Initial Catalog=amilamotors;Integrated Security=True");
        public Job()
        {
            InitializeComponent();
        }

        private void Job_Load(object sender, EventArgs e)
        {
            con.Open();
            string query_job_select = "SELECT * FROM job_table";
            SqlCommand cmnd = new SqlCommand(query_job_select, con);
            SqlDataReader row = cmnd.ExecuteReader();
            cmbJobID.Items.Add("New Register");
            while (row.Read())
            {
                cmbJobID.Items.Add(row[0].ToString());
            }
            row.Close();
            string query_user_select = "SELECT userID FROM user_table";
            SqlCommand comm = new SqlCommand(query_user_select, con);
            SqlDataReader row2 = comm.ExecuteReader();
            while (row2.Read())
            {
                cmbUID.Items.Add(row2[0].ToString());
            }
            row2.Close();
            string query_appo_select = "SELECT appointmentID FROM appointment_table";
            SqlCommand commnd = new SqlCommand(query_appo_select, con);
            SqlDataReader row3 = commnd.ExecuteReader();
            while (row3.Read())
            {
                cmbAID.Items.Add(row3[0].ToString());
            }
            row3.Close();
            string query_cus_select = "SELECT customerID FROM customer_table";
            SqlCommand comnd = new SqlCommand(query_cus_select, con);
            SqlDataReader row4 = comnd.ExecuteReader();
            while (row4.Read())
            {
                cmbCID.Items.Add(row4[0].ToString());
            }
            row4.Close();
            string query_vehi_select = "SELECT vehicleID FROM vehicle_table";
            SqlCommand command = new SqlCommand(query_vehi_select, con);
            SqlDataReader row5 = command.ExecuteReader();
            while (row5.Read())
            {
                cmbVID.Items.Add(row5[0].ToString());
            }
            row5.Close();
            con.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            JobCoordinatorDashboard dash = new JobCoordinatorDashboard();
            this.Hide();
            dash.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query_insert = "INSERT INTO job_table (jobstatus, assignedDate, startdate, enddate, appointmentID, customerID, vehicleID, createdBy) VALUES(@jobstatus, @assignedDate, @startdate, @enddate, @appointmentID, @customerID, @vehicleID, @createdBy);";

                SqlCommand cmd = new SqlCommand(query_insert, con);
                cmd.Parameters.AddWithValue("@jobstatus", this.cmbStatus.Text);
                cmd.Parameters.AddWithValue("@assignedDate", this.dtpAD.Value.Date);
                cmd.Parameters.AddWithValue("@startdate", this.dtpSD.Value.Date);
                cmd.Parameters.AddWithValue("@enddate", this.dtpED.Value.Date);
                cmd.Parameters.AddWithValue("@appointmentID", this.cmbAID.Text);
                cmd.Parameters.AddWithValue("@customerID", this.cmbCID.Text);
                cmd.Parameters.AddWithValue("@vehicleID", this.cmbVID.Text);
                cmd.Parameters.AddWithValue("@createdBy", this.cmbUID.Text);
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Job record added successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query_update = "UPDATE job_table SET jobstatus = @jobstatus, assignedDate = @assignedDate, startdate = @startdate, enddate = @enddate, appointmentID = @appointmentID, customerID = @customerID, vehicleID = @vehicleID, createdBy = @createdBy WHERE jobID = @jobID;";

                SqlCommand cmd = new SqlCommand(query_update, con);
                cmd.Parameters.AddWithValue("@jobID", this.cmbJobID.Text); // Assuming jobID is selected from a dropdown or text box
                cmd.Parameters.AddWithValue("@jobstatus", this.cmbStatus.Text);
                cmd.Parameters.AddWithValue("@assignedDate", this.dtpAD.Value.Date);
                cmd.Parameters.AddWithValue("@startdate", this.dtpSD.Value.Date);
                cmd.Parameters.AddWithValue("@enddate", this.dtpED.Value.Date);
                cmd.Parameters.AddWithValue("@appointmentID", this.cmbAID.Text);
                cmd.Parameters.AddWithValue("@customerID", this.cmbCID.Text);
                cmd.Parameters.AddWithValue("@vehicleID", this.cmbVID.Text);
                cmd.Parameters.AddWithValue("@createdBy", this.cmbUID.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Job record updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query_delete = "DELETE FROM job_table WHERE jobID = @jobID;";

                SqlCommand cmd = new SqlCommand(query_delete, con);
                cmd.Parameters.AddWithValue("@jobID", this.cmbJobID.Text); // Assuming jobID is selected from a dropdown or text box
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Job record deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbJobID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string no = cmbJobID.Text;
            if (no != "New Register")
            {
                con.Open();
                string query_select = "SELECT * FROM job_table WHERE jobID =" + no;
                SqlCommand cmnd = new SqlCommand(query_select, con);
                SqlDataReader row = cmnd.ExecuteReader();
                while (row.Read())
                {
                    cmbStatus.Text = row[1].ToString();
                    dtpAD.Format = DateTimePickerFormat.Custom;
                    dtpAD.CustomFormat = "yyyy/MM/dd";
                    dtpAD.Text = row[2].ToString();
                    dtpSD.Format = DateTimePickerFormat.Custom;
                    dtpSD.CustomFormat = "yyyy/MM/dd";
                    dtpSD.Text = row[3].ToString();
                    dtpED.Format = DateTimePickerFormat.Custom;
                    dtpED.CustomFormat = "yyyy/MM/dd";
                    dtpED.Text = row[4].ToString();
                    cmbAID.Text = row[5].ToString();
                    cmbCID.Text = row[6].ToString();
                    cmbVID.Text = row[7].ToString();
                    cmbUID.Text = row[8].ToString();
                }
                con.Close();
                AddButton.Enabled = false;
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
            else
            {
                cmbStatus.Text = "";
                cmbAID.Text = "";
                cmbCID.Text = "";
                cmbVID.Text = "";
                cmbUID.Text = "";
                AddButton.Enabled = true;
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }
    }
}
