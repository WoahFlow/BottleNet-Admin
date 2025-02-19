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
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.analyticPanel.Controls.Count > 0)
                this.analyticPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.analyticPanel.Controls.Add(f);
            this.analyticPanel.Tag = f;
            f.Show();
        }
        private void btn_week_Click(object sender, EventArgs e)
        {
            loadform(new Analytic_weekly());
        }

        private void btn_month_Click(object sender, EventArgs e)
        {
            loadform(new Analytic_month());
        }

        private void btn_year_Click(object sender, EventArgs e)
        {
            loadform(new Analytic_year());

        }
    }
}
