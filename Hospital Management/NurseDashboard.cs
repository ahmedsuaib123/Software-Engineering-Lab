using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hospital_Management
{
    public partial class NurseDashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        private int nurseId;
        private string nurseUsername;

        // Constructor with nurseId and username
        public NurseDashboard(int nurseId, string username)
        {
            InitializeComponent();
            this.nurseId = nurseId;
            this.nurseUsername = username;
        }

        //  Show all patients
        private void PatientInfoBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * 
                                 FROM Patient";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                NurseDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message);
            }
        }

        //  Show logged-in nurse duty schedule
        private void DutyScheduleBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT 
                                    Shift AS [Date & Time],
                                    AssignedDepartment AS Department
                                 FROM Nurse
                                 WHERE NurseUsername = @username";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@username", nurseUsername);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                NurseDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading duty schedule: " + ex.Message);
            }
        }

        //  Exit Application
        private void NurseDashboardExitBTN_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Are you sure to close the application?",
                "Exit Confirmation",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //  Open NurseProfile Form
        private void NurseProfileBTN_Click(object sender, EventArgs e)
        {
            NurseProfile np = new NurseProfile(nurseId, nurseUsername);
            np.Show();
            this.Hide();
        }

        //  Patient Search (by ID or Name)
        private void PatientSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                string query = @"
                    SELECT *
                    FROM Patient
                    WHERE PatientName LIKE '%" + PatientSearchTextBox.Text + @"%' 
                       OR CAST(PatientId AS VARCHAR(50)) LIKE '%" + PatientSearchTextBox.Text + "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                NurseDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching patient: " + ex.Message);
            }
        }

        // Logout
        private void LogOutBTN_Click(object sender, EventArgs e)
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
