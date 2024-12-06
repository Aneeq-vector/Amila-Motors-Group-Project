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
    public partial class AppoinmentForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIHANGAHP\SQLEXPRESS;Initial Catalog=amilamotors;Integrated Security=True");
        public AppoinmentForm()
        {
            InitializeComponent();
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerCareAssistantDashboard customerCareAssistantDashboard = new CustomerCareAssistantDashboard();
            this.Hide();
            customerCareAssistantDashboard.Show();
        }

        private void AppoinmentForm_Load(object sender, EventArgs e)
        {
            string query_appo_select = "SELECT appointmentID FROM appointment_table";
            SqlCommand commnd = new SqlCommand(query_appo_select, con);
            SqlDataReader row3 = commnd.ExecuteReader();
            cmbAID.Items.Add("New Register");
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
    }
}
