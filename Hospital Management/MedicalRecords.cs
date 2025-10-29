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
    public partial class MedicalRecords : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        public MedicalRecords()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    MR.RecordID,
                    P.PatientName,
                    D.DoctorName,
                    MR.Diagnosis,
                    MR.Date
                FROM [Hospital].[dbo].[MedicalRecords] MR
                JOIN [Hospital].[dbo].[Patient] P
                    ON MR.PatientID = P.PatientID
                JOIN [Hospital].[dbo].[Doctor] D
                    ON MR.DoctorID = D.DoctorID
                ORDER BY MR.RecordID;";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
