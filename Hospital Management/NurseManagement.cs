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
    public partial class NurseManagement : Form
    {
        public NurseManagement()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void NurseManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospital_ManagementDataSet5.Nurse' table. You can move, or remove it, as needed.
            this.nurseTableAdapter.Fill(this.hospital_ManagementDataSet5.Nurse);

        }
    }
}
