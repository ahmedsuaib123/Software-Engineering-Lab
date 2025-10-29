//using Hospital_Managment_Sytem;
//using HospitalManagement;
using PrototypeOfAll;
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
    public partial class Login : Form
    {
        public static string username;
        public static string fullName;
        public static string contact;
        public static int age;
        public static string gender;
        public static string bloodGroup;
        public static string availableSlot;
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True");

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Login where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0][4].ToString() == "1")
                {
                    Login.username = dt.Rows[0]["Username"].ToString();
                    string role = dt.Rows[0]["Role"].ToString();

                    if (role == "Doctor")
                    {
                        SqlDataAdapter da = new SqlDataAdapter(
                            "SELECT DoctorID, DoctorName, DoctorContact, DoctorAge, Gender, BloodGroup, AvailableSlot " +
                            "FROM Doctor WHERE DoctorUsername='" + username + "'", con);
                        DataTable dtt = new DataTable();
                        da.Fill(dtt);
                        if (dtt.Rows.Count > 0)
                        {
                            Login.fullName = dtt.Rows[0]["DoctorName"].ToString();
                            Login.contact = dtt.Rows[0]["DoctorContact"].ToString();
                            Login.age = Convert.ToInt32(dtt.Rows[0]["DoctorAge"]);
                            Login.gender = dtt.Rows[0]["Gender"].ToString();
                            Login.bloodGroup = dtt.Rows[0]["BloodGroup"].ToString();
                            Login.availableSlot = dtt.Rows[0]["AvailableSlot"].ToString();
                        }
                    }
                    else if (role == "Patient")
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SELECT PatientID, PatientName FROM Patient WHERE PatientUsername='" + username + "'", con);
                        DataTable dtt = new DataTable();
                        da.Fill(dtt);
                        if (dtt.Rows.Count > 0) Login.fullName = dtt.Rows[0]["PatientName"].ToString();
                    }
                    else if (role == "Nurse")
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SELECT NurseID, NurseName FROM Nurse WHERE NurseUsername='" + username + "'", con);
                        DataTable dtt = new DataTable();
                        da.Fill(dtt);
                        if (dtt.Rows.Count > 0) Login.fullName = dtt.Rows[0]["NurseName"].ToString();
                    }
                    else
                    {
                        Login.fullName = username;
                    }

                    // Open dashboard based on role
                    if (role == "Admin")
                    {
                        new AdminDashboard().Show();
                        this.Hide();
                    }
                    else if (role == "Patient")
                    {
                        new PatientDashboard().Show();
                        this.Hide();
                    }
                    else if (role == "Doctor")
                    {
                        new DoctorDashboard().Show();
                        this.Hide();
                    }
                    else if (role == "Nurse")
                    {
                        // fetch NurseID
                        SqlDataAdapter da = new SqlDataAdapter("SELECT NurseID FROM Nurse WHERE NurseUsername='" + username + "'", con);
                        DataTable dtNurse = new DataTable();
                        da.Fill(dtNurse);
                        int nurseId = 0;
                        if (dtNurse.Rows.Count > 0)
                        {
                            nurseId = Convert.ToInt32(dtNurse.Rows[0]["NurseID"]);
                        }

                        new NurseDashboard(nurseId, username).Show(); // ✅ pass arguments
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Unknown Role! Contact admin.");
                    }
                }
                else
                {
                    MessageBox.Show("Account is disabled. Contact with admin");
                }
            }
            else
            {
                MessageBox.Show("Wrong Credentials!! Try Again.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgetPassword().Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
