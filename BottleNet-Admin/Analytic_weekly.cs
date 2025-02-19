using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace BottleNet_Admin
{
    public partial class Analytic_weekly : Form
    {
        public Analytic_weekly()
        {
            InitializeComponent();
        }

        private void Analytic_weekly_Load(object sender, EventArgs e)
        {
            // Set chart title
            chart1.Titles.Add("Sales Data");

            // Set X-axis title
            chart1.ChartAreas[0].AxisX.Title = "Days of the Week";

            // Set custom labels for the X-axis (assuming 7 data points)
            chart1.Series[0].Points[0].AxisLabel = "Monday";
            chart1.Series[0].Points[1].AxisLabel = "Tuesday";
            chart1.Series[0].Points[2].AxisLabel = "Wednesday";
            chart1.Series[0].Points[3].AxisLabel = "Thursday";
            chart1.Series[0].Points[4].AxisLabel = "Friday";
            chart1.Series[0].Points[5].AxisLabel = "Saturday";
            chart1.Series[0].Points[6].AxisLabel = "Sunday";
        }
    }
}
