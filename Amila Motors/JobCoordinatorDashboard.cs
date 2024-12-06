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
    public partial class JobCoordinatorDashboard : Form
    {
        public JobCoordinatorDashboard()
        {
            InitializeComponent();
        }

        private void JobCoordinatorDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Job job = new Job();
            this.Hide();
            job.Show();
            
        }
    }
}
