using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeApp
{
    public partial class TimeAppForm : Form
    {
        TimeClassLibrary.Day Today;
        public TimeAppForm()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            Today = new TimeClassLibrary.Day(Int32.Parse(hourBox.Text), Int32.Parse(minuteBox.Text));
        }

        private void savedTimeButton_Click(object sender, EventArgs e)
        {
            savedTimeLabel.Text = Today.CurrentTime();
        }

        private void dayTimeButton_Click(object sender, EventArgs e)
        {
            dayTimeLabel.Text = Today.TimesOfDayCalculation();
        }

        private void saveCurrentTimeButton_Click(object sender, EventArgs e)
        {
            Today = new TimeClassLibrary.Day(DateTime.Now.Hour, DateTime.Now.Minute);
        }
    }
}
