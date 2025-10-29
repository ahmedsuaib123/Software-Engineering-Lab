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
    public partial class AdminDashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PatientManagement().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DoctorManagement().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to Logout?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to close the application?", "Closing Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new NurseManagement().Show();
            this.Hide();
        }

        private void LoadCounts()
        {
            
                DataTable dt = new DataTable();
                string query = @"
                    SELECT 
                        (SELECT COUNT(*) FROM Patient) AS TotalPatients,
                        (SELECT COUNT(*) FROM Doctor) AS TotalDoctors,
                        (SELECT COUNT(*) FROM Nurse) AS TotalNurses";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    lblPatientCount.Text = "Total Patients: " + dt.Rows[0]["TotalPatients"].ToString();
                    lblDoctorCount.Text = "Total Doctors: " + dt.Rows[0]["TotalDoctors"].ToString();
                    lblNurseCount.Text = "Total Nurses: " + dt.Rows[0]["TotalNurses"].ToString();
                }

                //da = new SqlDataAdapter("SELECT COUNT(*) FROM Appointments", con);
                //dt = new DataTable();
                //da.Fill(dt);
                //lblAppointmentCount.Text = "Total Appointments: " + dt.Rows[0][0].ToString();
            
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadCounts();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadCounts();
        }

        private void AdminDashboard_Load_1(object sender, EventArgs e)
        {
            LoadCounts();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new PatientManagement().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to Logout?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new DoctorManagement().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new NurseManagement().Show();
            this.Hide();
        }

        private void lblBillCount_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            new ManageDepartment().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new AdminPasswordChange().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new ShowAppointments().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new MedicalRecords().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new CheckAccountStatus().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ManageAdmins().Show();
            this.Hide();
        }
    }
}
