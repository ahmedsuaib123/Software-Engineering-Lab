using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class PatientDashboard : Form
    {
        
        public PatientDashboard()
        {
            InitializeComponent();
        }


        

        private void PatientDashboard_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + Login.username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to Logout?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }
    }
}
