using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BottleNet_Admin
{
    public partial class SuperAdminLogin : Form
    {
        public SuperAdminLogin()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_manager_Click(object sender, EventArgs e)
        {
            AdminLogin admin = new AdminLogin(); // Instantiate the new form
            admin.Show(); // Show the new form
            this.Hide(); // Hide the current login form (optional)
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1(); // Instantiate the new form
            dashboard.Show(); // Show the new form
            this.Hide(); // Hide the current login form (optional)
        }
    }
}
