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
    public partial class AddDoctor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new DoctorManagement().Show();
            this.Hide();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string insert_query = "INSERT INTO Doctor (DoctorName, DoctorAge, Gender, DoctorContact, BloodGroup, Qualification, DoctorUsername) VALUES ('"
                     + FullNameTextBox.Text + "', '"
                     + AgeTextBox.Text + "', '"
                     + GenderComboBox.Text + "', '"
                     + ContactTextBox.Text + "', '"
                     + BloodGroupComboBox.Text + "', '"
                     + AddressTextBox.Text + "', '"
                     + DiagnosisTextBox.Text + "')";

            string login_query = "INSERT INTO Login (Username, Password, Role) VALUES ('"
                        + DiagnosisTextBox.Text + "', '"
                        + textBox2.Text + "', '"
                        + "Doctor" + "')";

            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.InsertCommand = new SqlCommand(insert_query, con);

            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.InsertCommand = new SqlCommand(login_query, con);

            if (con.State == ConnectionState.Open)
            {
                int result1 = da1.InsertCommand.ExecuteNonQuery();
                int result2 = da2.InsertCommand.ExecuteNonQuery();

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
