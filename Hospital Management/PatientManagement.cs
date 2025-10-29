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
    public partial class PatientManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        public PatientManagement()
        {
            InitializeComponent();
        }

        private void PatientManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet2.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter5.Fill(this.hospitalDataSet2.Patient);
            // TODO: This line of code loads data into the 'hospitalDataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter4.Fill(this.hospitalDataSet1.Patient);
            // TODO: This line of code loads data into the 'hospitalDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter3.Fill(this.hospitalDataSet.Patient);
            // TODO: This line of code loads data into the 'hospital_ManagementDataSet6.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter2.Fill(this.hospital_ManagementDataSet6.Patient);
            try
            {
                // Temporarily disable constraint enforcement
                hospital_ManagementDataSet3.EnforceConstraints = false;

                // Load data into the Patient table
                this.patientTableAdapter1.Fill(this.hospital_ManagementDataSet3.Patient);

                // Re-enable constraint checking
                hospital_ManagementDataSet3.EnforceConstraints = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Patient where PatientID like '%" + textBox1.Text + "%' " +
               "or PatientName like '%" + textBox1.Text + "%' " +
               "or PatientAddress like '%" + textBox1.Text + "%' " +
               "or PatientContact like '%" + textBox1.Text + "%' " +
               "or Diagnosis like '%" + textBox1.Text + "%'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Patient";


            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "select * from Patient";


            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter1.FillBy(this.hospital_ManagementDataSet3.Patient);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddPatient().Show();
            this.Hide();
        }
    }
}
