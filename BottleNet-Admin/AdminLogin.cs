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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            SuperAdminLogin admin = new SuperAdminLogin(); // Instantiate the new form
            admin.Show(); // Show the new form
            this.Hide(); // Hide the current login form (optional)
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1(); // Instantiate the new form
            dashboard.Show(); // Show the new form
            this.Hide(); // Hide the current login form (optional)
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
