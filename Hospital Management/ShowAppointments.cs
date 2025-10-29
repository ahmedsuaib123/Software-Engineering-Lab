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
    
    public partial class ShowAppointments : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        public ShowAppointments()
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
                    AP.AppointmentID,
                    P.PatientName,
                    D.DoctorName,
                    P.PatientContact,
                    AP.AppointmentDate
                FROM [Hospital].[dbo].[Appointment] AP
                JOIN [Hospital].[dbo].[Patient] P
                    ON AP.PatientID = P.PatientID
                JOIN [Hospital].[dbo].[Doctor] D
                    ON AP.DoctorID = D.DoctorID
                ORDER BY AP.AppointmentDate;";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
