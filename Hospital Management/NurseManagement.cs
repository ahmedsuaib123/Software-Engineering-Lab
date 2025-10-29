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

namespace Hospital_Management
{
    public partial class NurseManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
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
            // TODO: This line of code loads data into the 'hospitalDataSet5.Nurse' table. You can move, or remove it, as needed.
            this.nurseTableAdapter1.Fill(this.hospitalDataSet5.Nurse);
            this.nurseTableAdapter.Fill(this.hospital_ManagementDataSet5.Nurse);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Nurse where NurseID like '%" + textBox1.Text + "%' " +
                   "or NurseName like '%" + textBox1.Text + "%' " +
                   "or NurseContact like '%" + textBox1.Text + "%' " +
                   "or DepartmentID like '%" + textBox1.Text + "%'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddNurse().Show();
            this.Hide();
        }
    }
}
