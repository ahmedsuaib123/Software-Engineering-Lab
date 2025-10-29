using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class ManageDepartment : Form
    {
        public ManageDepartment()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void ManageDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet6.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter1.Fill(this.hospitalDataSet6.Department);
            // TODO: This line of code loads data into the 'hospital_ManagementDataSet7.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hospital_ManagementDataSet7.Department);

        }
    }
}
