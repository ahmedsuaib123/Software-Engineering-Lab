using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class AddAppointments : Form
    {
        public AddAppointments()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ShowAppointments().Show();
            this.Hide();
        }
    }
}
