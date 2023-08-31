using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairCut_Management_System
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            Client Client = new Client();
            Client.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Services Services = new Services();
            Services.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Appointment Appointment = new Appointment();
            Appointment.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Product1 Product1 = new Product1();
            Product1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Billing Billing = new Billing();
            Billing.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Employees Employees = new Employees();
            Employees.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Logout Logout = new Logout();
            Logout.Show();

        }
    }
}
