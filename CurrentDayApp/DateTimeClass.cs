using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentDayApp
{
    public class DateTimeClass
    {
        public string getDate()
        {
           return DateTime.Now.Date.ToLongDateString();
        }

        public string getMonth()
        {
            return DateTime.Now.Date.Month.ToString();
        }

        public string getWeekDay()
        {
            return DateTime.Now.Date.DayOfWeek.ToString();
        }

        public string getYear()
        {
            return DateTime.Now.Date.Year.ToString();
        }
    }
}
