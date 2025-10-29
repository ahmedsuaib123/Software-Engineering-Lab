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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management
{
    public partial class DoctorDashboard : Form
    {

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        private bool isProfilePanelExpanded = false;
        private int targetWidth = 220;
        private int animationStep = 20;
        private int DoctorID;

        public DoctorDashboard()
        {
            InitializeComponent();

            // Start Profile Panel collapsed
            ProfilePanel.Width = 0;
            ProfilePanel.Left = this.ClientSize.Width;

            // Wire events
            timer1.Tick += timer1_Tick;
            ProfilePanelExtender.Click += ProfilePanelExtender_Click;
            SearchButton.Click += SearchButton_Click;
            ClearButton.Click += ClearButton_Click;
            ShowAllButton.Click += ShowAllButton_Click; // Show all doctors button

            // Initialize DataGridView as blank
            dataGridView1.DataSource = new DataTable();

        }
        private void DoctorDashboard_Load(object sender, EventArgs e)
        {
            // Load appointment table
            this.appointmentTableAdapter.Fill(this.hospitalDataSet8.Appointment);

            // Welcome label
            label1.Text = "Welcome, " + Login.username;

            // Profile info
            Name1Label.Text = Login.fullName;
            Contact1Label.Text = Login.contact;
            Age1Label.Text = Login.age.ToString();
            Gender1Label.Text = Login.gender;
            BloodGroup1Label.Text = Login.bloodGroup;
            Available1Label.Text = Login.availableSlot;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string keyword = SearchTextBox.Text.Trim();

            try
            {
                string query = @"
        SELECT 
            a.AppointmentID,
            p.PatientName,
            p.PatientContact,
            a.AppointmentDate,
            a.AppointmentSlot
        FROM [Hospital].[dbo].[Appointment] a
        JOIN [Hospital].[dbo].[Patient] p ON a.PatientID = p.PatientID
        JOIN [Hospital].[dbo].[Doctor] d ON a.DoctorID = d.DoctorID
        WHERE d.DoctorUsername = @DoctorUsername
          AND (
              CAST(a.AppointmentID AS NVARCHAR) LIKE @keyword
              OR p.PatientName LIKE @keyword
              OR p.PatientContact LIKE @keyword
          )
        ORDER BY a.AppointmentDate, a.AppointmentSlot";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@DoctorUsername", Login.username); // Logged-in doctor
                da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    DataTable emptyTable = new DataTable();
                    emptyTable.Columns.Add("Message");
                    emptyTable.Rows.Add("No appointments found");
                    dataGridView1.DataSource = emptyTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            dataGridView1.DataSource = new DataTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"
        SELECT 
            a.AppointmentID,
            p.PatientName,
            p.PatientContact,
            a.AppointmentDate,
            a.AppointmentSlot
        FROM Appointment a
        INNER JOIN Patient p ON a.PatientID = p.PatientID
        INNER JOIN Doctor d ON a.DoctorID = d.DoctorID
        WHERE d.DoctorUsername = @DoctorUsername
        ORDER BY a.AppointmentDate, a.AppointmentSlot";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@DoctorUsername", Login.username); // match parameter name

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    DataTable emptyTable = new DataTable();
                    emptyTable.Columns.Add("Message");
                    emptyTable.Rows.Add("No appointments found");
                    dataGridView1.DataSource = emptyTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }






        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePanelExtender_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePanel_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                con.Open();
                string query = @"SELECT * FROM Doctor WHERE DoctorID = @DoctorID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DoctorID", DoctorID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Name1Label.Text = reader["DoctorName"].ToString();
                    Contact1Label.Text = reader["DoctorContact"].ToString();
                    Age1Label.Text = reader["DoctorAge"].ToString();
                    Gender1Label.Text = reader["Gender"].ToString();
                    BloodGroup1Label.Text = reader["BloodGroup"].ToString();
                    Available1Label.Text = reader["AvailableSlot"].ToString();
                }
                reader.Close(); // Don't forget to close the reader
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctor profile: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ContactLabel_Click(object sender, EventArgs e)
        {

        }

        private void AgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void GenderLabel_Click(object sender, EventArgs e)
        {

        }

        private void BloodGroupLabel_Click(object sender, EventArgs e)
        {

        }

        private void AvailableLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isProfilePanelExpanded)
            {
                // Collapse
                ProfilePanel.Width -= animationStep;
                ProfilePanel.Left += animationStep;

                if (ProfilePanel.Width <= 0)
                {
                    ProfilePanel.Width = 0;
                    ProfilePanel.Left = this.ClientSize.Width;
                    isProfilePanelExpanded = false;
                    timer1.Stop();
                }
            }
            else
            {
                // Expand
                ProfilePanel.Width += animationStep;
                ProfilePanel.Left -= animationStep;

                if (ProfilePanel.Width >= targetWidth)
                {
                    ProfilePanel.Width = targetWidth;
                    ProfilePanel.Left = this.ClientSize.Width - targetWidth;
                    isProfilePanelExpanded = true;
                    timer1.Stop();
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to Logout?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }
    }
}
