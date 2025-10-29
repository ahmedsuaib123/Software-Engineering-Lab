using Hospital_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PrototypeOfAll
{
    public partial class ForgetPassword : Form
    {
        private string userType = ""; // Tracks which table to check for phone verification

        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            PhonenumberLabel.Visible = false;
            PhonenumberTextBox.Visible = false;
            VerifyButton2.Visible = false;

            NewPassLabel.Visible = false;
            NewPassTextBox.Visible = false;
            ConfirmPassLabel.Visible = false;
            ConfirmPasswordTextBox.Visible = false;
            ConfirmButton.Visible = false;
        }

        private void UsernameLabel_Click(object sender, EventArgs e) { }
        private void PhonenumberLabel_Click(object sender, EventArgs e) { }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e) { }
        private void PhonenumberTextBox_TextChanged(object sender, EventArgs e) { }
        private void NewPassLabel_Click(object sender, EventArgs e) { }
        private void ConfirmPassLabel_Click(object sender, EventArgs e) { }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    // Check Doctor table
                    string doctorQuery = "SELECT COUNT(*) FROM Doctor WHERE DoctorUsername = '" + username + "'";
                    SqlCommand doctorCmd = new SqlCommand(doctorQuery, con);
                    int doctorCount = (int)doctorCmd.ExecuteScalar();
                    if (doctorCount > 0)
                    {
                        userType = "Doctor";
                        PhonenumberLabel.Visible = true;
                        PhonenumberTextBox.Visible = true;
                        VerifyButton2.Visible = true;
                        return;
                    }

                    // Check Nurse table
                    string nurseQuery = "SELECT COUNT(*) FROM Nurse WHERE NurseUsername = '" + username + "'";
                    SqlCommand nurseCmd = new SqlCommand(nurseQuery, con);
                    int nurseCount = (int)nurseCmd.ExecuteScalar();
                    if (nurseCount > 0)
                    {
                        userType = "Nurse";
                        PhonenumberLabel.Visible = true;
                        PhonenumberTextBox.Visible = true;
                        VerifyButton2.Visible = true;
                        return;
                    }

                    // Check Patient table
                    string patientQuery = "SELECT COUNT(*) FROM Patient WHERE PatientUsername = '" + username + "'";
                    SqlCommand patientCmd = new SqlCommand(patientQuery, con);
                    int patientCount = (int)patientCmd.ExecuteScalar();
                    if (patientCount > 0)
                    {
                        userType = "Patient";
                        PhonenumberLabel.Visible = true;
                        PhonenumberTextBox.Visible = true;
                        VerifyButton2.Visible = true;
                        return;
                    }

                    // Username not found
                    MessageBox.Show("Invalid username. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerifyButton2_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string phone = PhonenumberTextBox.Text.Trim();

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter your phone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string query = "";

                    if (userType == "Doctor")
                        query = "SELECT COUNT(*) FROM Doctor WHERE DoctorUsername = '" + username + "' AND DoctorContact = '" + phone + "'";
                    else if (userType == "Nurse")
                        query = "SELECT COUNT(*) FROM Nurse WHERE NurseUsername = '" + username + "' AND NurseContact = '" + phone + "'";
                    else if (userType == "Patient")
                        query = "SELECT COUNT(*) FROM Patient WHERE PatientUsername = '" + username + "' AND PatientContact = '" + phone + "'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Phone number verified. You can now reset your password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Show password reset fields
                        NewPassLabel.Visible = true;
                        NewPassTextBox.Visible = true;
                        ConfirmPassLabel.Visible = true;
                        ConfirmPasswordTextBox.Visible = true;
                        ConfirmButton.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Phone number does not match our records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewPassTextBox_TextChanged(object sender, EventArgs e) { }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e) { }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string newPassword = NewPassTextBox.Text.Trim();
            string confirmPassword = ConfirmPasswordTextBox.Text.Trim();

            if (newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Please enter and confirm your password.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            // Password validation logic
            if (newPassword.Length < 6 || !HasUpperCase(newPassword) || !HasLowerCase(newPassword) || !HasNumber(newPassword) || !HasSpecialChar(newPassword))
            {
                MessageBox.Show("Password must contain at least one lowercase letter, one uppercase, one number, one special character and be at least 6 characters long.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    string updateQuery = "UPDATE Login SET Password = @password WHERE Username = @username";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@password", newPassword);
                    updateCmd.Parameters.AddWithValue("@username", username);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hide password fields after update
                    NewPassLabel.Visible = false;
                    NewPassTextBox.Visible = false;
                    ConfirmPassLabel.Visible = false;
                    ConfirmPasswordTextBox.Visible = false;
                    ConfirmButton.Visible = false;

                    // Clear all textboxes
                    UsernameTextBox.Clear();
                    PhonenumberTextBox.Clear();
                    NewPassTextBox.Clear();
                    ConfirmPasswordTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper methods for password validation
        private bool HasUpperCase(string str) => str.Any(c => char.IsUpper(c));
        private bool HasLowerCase(string str) => str.Any(c => char.IsLower(c));
        private bool HasNumber(string str) => str.Any(c => char.IsDigit(c));
        private bool HasSpecialChar(string str) => Regex.IsMatch(str, @"[!@#$%^&*(),.?:{}|<>]");

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
