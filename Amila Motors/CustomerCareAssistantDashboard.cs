using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amila_Motors
{
    public partial class CustomerCareAssistantDashboard : Form
    {
        public CustomerCareAssistantDashboard()
        {
            InitializeComponent();
        }

        private void btnManageSupplier_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            this.Hide();
            customer.Show();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            Complaint complaint = new Complaint();
            this.Hide();
            complaint.Show();
        }

        private void btnappointments_Click(object sender, EventArgs e)
        {
            AppoinmentForm appoinment = new AppoinmentForm();  
            this.Hide();
            appoinment.Show();
        }

        private void btnJobComplete_Click(object sender, EventArgs e)
        {
            JobCompletionUpdate jobCompletionUpdate = new JobCompletionUpdate();
            this.Hide();
            jobCompletionUpdate.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            this.Hide();
            vehicle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            this.Hide();
            invoice.Show();
        }
    }
}
