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
    public partial class JobCompletionUpdate : Form
    {
        public JobCompletionUpdate()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerCareAssistantDashboard customerCareAssistantDashboard = new CustomerCareAssistantDashboard();
            this.Hide();
            customerCareAssistantDashboard.Show();
        }
    }
}
