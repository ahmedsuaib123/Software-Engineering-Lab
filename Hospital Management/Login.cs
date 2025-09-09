using HospitalManagement;
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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital Management;Integrated Security=True;TrustServerCertificate=True");
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
                    if (dt.Rows[0][3].ToString() == "Admin")
                    {
                        new AdminDashboard().Show();
                        this.Hide();
                    }
                    //else if (dt.Rows[0][3].ToString() == "Patient")
                    //{
                    //    new PatientDashboard().Show();
                    //    this.Hide();
                    //}
                    //else if (dt.Rows[0][3].ToString() == "Doctor")
                    //{
                    //    new DoctorDashboard().Show();
                    //    this.Hide();
                    //}
                }
                else
                {
                    MessageBox.Show("Account is disabled. Contact with admin");
                }
            }
            else
            {
                MessageBox.Show("Wrong Credentials!! \n Try Again.");
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
            else{
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
