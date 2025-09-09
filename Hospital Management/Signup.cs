using Hospital_Management;
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

namespace HospitalManagement
{
    public partial class Signup : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HOP36BN\\SQLEXPRESS;Initial Catalog=Hospital Management;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {
            DOB_DTP.Format = DateTimePickerFormat.Long;

            DateTime dob = DOB_DTP.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age))
            {
                age--;
            }

            AgeTextBox.Text = age.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Text = "";
            ContactTextBox.Text = "";
            BloodGroupComboBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            AgeTextBox.Text = "";

            if (GenderComboBox.Items.Count > 0)
            {
                GenderComboBox.Text = "Select";
            }

            if (CategoryComboBox.Items.Count > 0)
            {
                CategoryComboBox.Text = "Select";
            }

            DOB_DTP.Format = DateTimePickerFormat.Custom;
            DOB_DTP.CustomFormat = "'Select'";

            FullNameTextBox.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            // Validation check (use OR instead of AND)
            if (FullNameTextBox.Text == "" &&
                DOB_DTP.CustomFormat == "'Select'" &&
                GenderComboBox.Text == "Select" &&
                BloodGroupComboBox.Text == "" &&
                ContactTextBox.Text == "" &&
                CategoryComboBox.Text == "Select" &&
                UsernameTextBox.Text == "" &&
                PasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields before proceeding.");
                return;
            }

            // Calculate Age from DOB
            int age = DateTime.Now.Year - DOB_DTP.Value.Year;
            if (DateTime.Now.DayOfYear < DOB_DTP.Value.DayOfYear)
            {
                age--;
            }

            string category = CategoryComboBox.Text;
            string insert_query = "";
            string login_query = "";

            // Choose table based on category
            if (category == "Patient")
            {
                insert_query = "INSERT INTO Patient (PatientName, PatientAge, Gender, PatientPhoneNumber, Diagnosis) VALUES ('"
                + FullNameTextBox.Text + "', '"
                + age + "', '"
                + GenderComboBox.Text + "', '"
                + ContactTextBox.Text + "', '"
                + "N/A" + "')";
            }
            else if (category == "Doctor")
            {
                insert_query = "INSERT INTO Doctor (DoctorName, Age, Gender, DoctorPhoneNumber, Qualifications, AvailableTime) VALUES ('"
                + FullNameTextBox.Text + "', '"
                + age + "', '"
                + GenderComboBox.Text + "', '"
                + ContactTextBox.Text + "', '"
                + "MBBS" + "', '"
                + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            }
            else if (category == "Nurse")
            {
                insert_query = "INSERT INTO Nurse (NurseName, NurseAge, NursePhoneNumber, Shift) VALUES ('"
                + FullNameTextBox.Text + "', '"
                + age + "', '"
                + ContactTextBox.Text + "', '"
                + "Morning" + "')";
            }
            else
            {
                MessageBox.Show("Invalid category selected!");
                return;
            }

            // Login table insert (username, password, role, status)
            login_query = "INSERT INTO Login (Username, Password, Role) VALUES ('"
            + UsernameTextBox.Text + "', '"
            + PasswordTextBox.Text + "', '"
            + category + "' )";   // BIT value (1 = Active)

            try
            {
                con.Open();

                // Insert into category-specific table
                SqlCommand cmd = new SqlCommand(insert_query, con);
                cmd.ExecuteNonQuery();

                // Insert into Login table
                SqlCommand loginCmd = new SqlCommand(login_query, con);
                loginCmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show(category + " account created successfully!");

                FullNameTextBox.Text = "";
                ContactTextBox.Text = "";
                BloodGroupComboBox.Text = "";
                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";
                AgeTextBox.Text = "";

                if (GenderComboBox.Items.Count > 0)
                {
                    GenderComboBox.Text = "Select";
                }

                if (CategoryComboBox.Items.Count > 0)
                {
                    CategoryComboBox.Text = "Select";
                }

                DOB_DTP.Format = DateTimePickerFormat.Custom;
                DOB_DTP.CustomFormat = "'Select'";

                FullNameTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        //private void SignupBack_Click(object sender, EventArgs e)
        //{
        //    new Login().Show();
        //    this.Hide();
        //}

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = CategoryComboBox.Text;

            // Hide all first
            if (DiagnosisTextBox != null) DiagnosisTextBox.Visible = false;
            if (lblDiagnosis != null) lblDiagnosis.Visible = false;
            if (QualificationTextBox != null) QualificationTextBox.Visible = false;
            if (lblQualification != null) lblQualification.Visible = false;
            if (AvailableTimePicker != null) AvailableTimePicker.Visible = false;
            if (lblAvailableTime != null) lblAvailableTime.Visible = false;
            if (ShiftComboBox != null) ShiftComboBox.Visible = false;
            if (lblShift != null) lblShift.Visible = false;

            // Show relevant controls
            if (category == "Patient")
            {
                if (!this.Controls.Contains(lblDiagnosis))
                {
                    lblDiagnosis = new Label()
                    {
                        Text = "Diagnosis:",
                        Location = new Point(182, 380),
                        Font = new Font("Microsoft Sans Serif", 12),
                        Visible = true
                    };
                    DiagnosisTextBox = new TextBox()
                    {
                        Location = new Point(284, 380),
                        Size = new Size(321, 25),
                        Font = new Font("Microsoft Sans Serif", 12),
                        Visible = true
                    };
                    this.Controls.Add(lblDiagnosis);
                    this.Controls.Add(DiagnosisTextBox);
                }
                else
                {
                    lblDiagnosis.Visible = true;
                    DiagnosisTextBox.Visible = true;
                }
            }
            else if (category == "Doctor")
            {
                if (!this.Controls.Contains(lblQualification))
                {
                    lblQualification = new Label()
                    {
                        Text = "Qualifications:",
                        Location = new Point(182, 380),
                        Font = new Font("Microsoft Sans Serif", 12),
                        Visible = true
                    };
                    QualificationTextBox = new TextBox()
                    {
                        Location = new Point(284, 380),
                        Size = new Size(321, 25),
                        Font = new Font("Microsoft Sans Serif", 12),
                        Visible = true
                    };
                    lblAvailableTime = new Label()
                    {
                        Text = "Available Time:",
                        Location = new Point(182, 410),
                        Font = new Font("Microsoft Sans Serif", 12),
                        Visible = true
                    };
                    AvailableTimePicker = new DateTimePicker()
                    {
                        Location = new Point(284, 410),
                        Format = DateTimePickerFormat.Time,
                        ShowUpDown = true,
                        Font = new Font("Microsoft Sans Serif", 12),
                        Visible = true
                    };
                    this.Controls.Add(lblQualification);
                    this.Controls.Add(QualificationTextBox);
                    this.Controls.Add(lblAvailableTime);
                    this.Controls.Add(AvailableTimePicker);
                }
                else
                {
                    lblQualification.Visible = true;
                    QualificationTextBox.Visible = true;
                    lblAvailableTime.Visible = true;
                    AvailableTimePicker.Visible = true;
                }
            }
            else if (category == "Nurse")
            {
                if (!this.Controls.Contains(lblShift))
                {
                    //lblShift = new Label()
                    //{
                    //    Text = "Shift:",
                    //    Location = new Point(182, 380),
                    //    Font = new Font("Microsoft Sans Serif", 12),
                    //    Visible = true
                    //};
                    //ShiftComboBox = new ComboBox()
                    //{
                    //    Location = new Point(284, 380),
                    //    Size = new Size(121, 25),
                    //    Font = new Font("Microsoft Sans Serif", 12),
                    //    Visible = true
                    //};
                    //ShiftComboBox.Items.AddRange(new string[] { "Morning", "Evening", "Night" });
                    //this.Controls.Add(lblShift);
                    //this.Controls.Add(ShiftComboBox);
                }
                else
                {
                    lblShift.Visible = true;
                    ShiftComboBox.Visible = true;
                }
            }



        }

        private void SignupBack_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
