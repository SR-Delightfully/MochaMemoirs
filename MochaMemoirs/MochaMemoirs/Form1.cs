using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MochaMemoirs
{
    public partial class MochaMemoirsForm : Form
    {
        public MochaMemoirsForm()
        {
            InitializeComponent();
            InitDateLabel();
        }
        public void InitDateLabel()
        {
            int numDay = System.DateTime.Now.Day;
            string nameDay = System.DateTime.Now.DayOfWeek.ToString();

            int numMonth = (int)DateTime.Now.Month;
            string nameMonth = "";

            string year = System.DateTime.Now.Year.ToString();

            string suffix = "";

            switch (numMonth)
            {
                case 1: nameMonth = "January"; break;
                case 2: nameMonth = "February"; break;
                case 3: nameMonth = "March"; break;
                case 4: nameMonth = "April"; break;
                case 5: nameMonth = "May"; break;
                case 6: nameMonth = "June"; break;
                case 7: nameMonth = "July"; break;
                case 8: nameMonth = "August"; break;
                case 9: nameMonth = "September"; break;
                case 10: nameMonth = "October"; break;
                case 11: nameMonth = "November"; break;
                case 12: nameMonth = "December"; break;
                default: nameMonth = "N/A"; break;
            }

            switch (numDay)
            {
                case 1: suffix = "st"; break;
                case 2: suffix = "nd"; break;
                case 3: suffix = "rd"; break;
                default: suffix = "th"; break;
            }


            DateLabel.Text = nameDay + ", " + nameMonth + " " + numDay + suffix;
        }
        public void InitTimeLabel()
        {

        }
        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void PersonalLibraryGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
