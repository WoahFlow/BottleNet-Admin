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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadform(new Dashboard());

        }
        public void loadform(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;    
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dash_Click_1(object sender, EventArgs e)
        {
            loadform(new Dashboard());
        }

        private void btn_analytics_Click_1(object sender, EventArgs e)
        {
            loadform(new Analytics());
        }

        private void btn_acc_Click(object sender, EventArgs e)
        {
            loadform(new Accounts());
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
