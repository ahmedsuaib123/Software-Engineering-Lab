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
    
    public partial class AddPatient : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        public AddPatient()
        {
            InitializeComponent();
        }

        private void QualificationLabel_Click(object sender, EventArgs e)
        {

        }

        private void QualificationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiagnosisTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiagnosisLabel_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new PatientManagement().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string insert_query = "INSERT INTO Patient (PatientName, PatientAge, Gender, PatientContact, BloodGroup, PatientAddress, Diagnosis, PatientUsername) VALUES ('"
                     + FullNameTextBox.Text + "', '"
                     + AgeTextBox.Text + "', '"
                     + GenderComboBox.Text + "', '"
                     + ContactTextBox.Text + "', '"
                     + BloodGroupComboBox.Text + "', '"
                     + AddressTextBox.Text + "', '"
                     + DiagnosisTextBox.Text + "', '"
                     + textBox3.Text + "')";
            string login_query = "INSERT INTO Login (Username, Password, Role) VALUES ('"
                        + textBox3.Text + "', '"
                        + textBox2.Text + "', '"
                        + "Patient" + "')";

            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.InsertCommand = new SqlCommand(insert_query, con);

            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.InsertCommand = new SqlCommand(login_query, con);

            if (con.State == ConnectionState.Open)
            {
                int result1 = da1.InsertCommand.ExecuteNonQuery(); // Insert into Doctor
                int result2 = da2.InsertCommand.ExecuteNonQuery(); // Insert into Login

                if (result1 > 0 && result2 > 0)
                {
                    MessageBox.Show("Doctor is Added");
                    new DoctorManagement().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Doctor is not added");
                }
            }
            else
            {
                MessageBox.Show("Database Connection is not valid");
            }
        }


    }
}
