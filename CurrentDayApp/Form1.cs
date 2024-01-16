using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrentDayApp
{
    public partial class MainFom : Form
    {
        public MainFom()
        {
            InitializeComponent();
        }

        private void MainFom_Load(object sender, EventArgs e)
        {
            DateTimeClass dateTimeClass = new DateTimeClass();

            lb_CurrentDay.Text = "Current Date: " + dateTimeClass.getDate() + " Month: " +
                dateTimeClass.getMonth() + " Week day: " + dateTimeClass.getWeekDay() + " Year: " + dateTimeClass.getYear();
        }
    }
}
