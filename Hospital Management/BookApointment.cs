using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class BookApointment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;");

        public BookApointment()
        {
            InitializeComponent();
        }

        private void BookApointment_Load(object sender, EventArgs e)
        {
            // Make DoctorName and Department read-only
            DocNameTextBox.ReadOnly = true;
            DepartmentTextBox.ReadOnly = true;

            LoadDoctors();
        }

        private void LoadDoctors()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DoctorID FROM Doctor", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DoctorIDComboBox.Items.Add(dr["DoctorID"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }

        private void DoctorIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DoctorName, Department, AvailableSlot FROM Doctor WHERE DoctorID=@DoctorID", con);
                cmd.Parameters.AddWithValue("@DoctorID", DoctorIDComboBox.SelectedItem.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DocNameTextBox.Text = dr["DoctorName"].ToString();
                    DepartmentTextBox.Text = dr["Department"].ToString();

                    // Fill Available Slots
                    AvailableSlotComboBox.Items.Clear();
                    string[] slots = dr["AvailableSlot"].ToString().Split(',');
                    foreach (string slot in slots)
                        AvailableSlotComboBox.Items.Add(slot.Trim());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctor details: " + ex.Message);
            }
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            if (DoctorIDComboBox.SelectedIndex == -1 || AvailableSlotComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Doctor and a Slot.");
                return;
            }

            try
            {
                con.Open();

                // Prevent double booking
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Appointment WHERE DoctorID=@DoctorID AND AppointmentDate=@AppointmentDate AND AppointmentSlot=@AppointmentSlot AND AppointmentStatus='Pending'", con);
                checkCmd.Parameters.AddWithValue("@DoctorID", DoctorIDComboBox.SelectedItem.ToString());
                checkCmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDatePicker.Value.Date);
                checkCmd.Parameters.AddWithValue("@AppointmentSlot", AvailableSlotComboBox.SelectedItem.ToString());
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("This slot is already booked. Please select another slot.");
                    con.Close();
                    return;
                }

                // Insert appointment
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Appointment (DoctorID, AppointmentDate, AppointmentSlot, AppointmentStatus) " +
                    "VALUES (@DoctorID, @AppointmentDate, @AppointmentSlot, @AppointmentStatus)", con);

                cmd.Parameters.AddWithValue("@DoctorID", DoctorIDComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDatePicker.Value.Date);
                cmd.Parameters.AddWithValue("@AppointmentSlot", AvailableSlotComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@AppointmentStatus", "Pending");

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Appointment has booked successfully!");
                else
                    MessageBox.Show("Booking has failed!");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking appointment: " + ex.Message);
            }
        }
    }
}
