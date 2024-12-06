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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AmilaMotorsName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //create a connection with ms sql db
            string cs = "Data Source=LAPTOP-LA6LADLM\\SQLEXPRESS;Initial Catalog=amilamotors;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //create a command 
            string sql = "SELECT * FROM user_table WHERE username=@un AND password=@pw";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@un", this.txtUsername.Text);
            com.Parameters.AddWithValue("@pw", this.txtPassword.Text);


            //execute command and access data using datareader
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                string role = dr["role"].ToString(); // Retrieve the role of the user

                // Open different forms based on the role
                if (role == "Manager")
                {
                    ManagerDashboard managerForm = new ManagerDashboard();
                    managerForm.Show();
                }
                else if (role == "Labor")
                {
                    LaborDashboard adminForm = new LaborDashboard();
                    adminForm.Show();
                }
                else if (role == "Job Coordinator")
                {
                    JobCoordinatorDashboard staffForm = new JobCoordinatorDashboard();
                    staffForm.Show();
                }
                else if (role == "Customer Care Assistant")
                {
                    CustomerCareAssistantDashboard cca = new CustomerCareAssistantDashboard();
                    cca.Show();
                }
                else if (role == "Supplier")
                {
                    Supplier suplier = new Supplier();
                    suplier.Show();
                }
                else if (role == "System Administor")
                {
                    SystemAdministratorDashboard sa = new SystemAdministratorDashboard();
                    sa.Show();
                }
                else
                {
                    MessageBox.Show("Role not recognized.");
                }

                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }


            //disconnect
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
