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
    public partial class AddNurse : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public AddNurse()
        {
            InitializeComponent();
        }

        private void AddNurse_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new NurseManagement().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string insert_query = "INSERT INTO Nurse (NurseName, NurseAge, Gender, NurseContact, BloodGroup, NurseUsername) VALUES ('"
                                  + FullNameTextBox.Text + "', '"
                                  + AgeTextBox.Text + "', '"
                                  + GenderComboBox.Text + "', '"
                                  + ContactTextBox.Text + "', '"
                                  + BloodGroupComboBox.Text + "',  '"
                                  + textBox3.Text + "')";

            string login_query = "INSERT INTO Login (Username, Password, Role) VALUES ('"
                                 + textBox3.Text + "', '"
                                 + textBox2.Text + "', '"
                                 + "Nurse" + "')";

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
                    MessageBox.Show("Nurse is Added");
                    new NurseManagement().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nurse is not added");
                }
            }
            else
            {
                MessageBox.Show("Database Connection is not valid");
            }
        }
    }
}
