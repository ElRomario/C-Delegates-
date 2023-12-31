using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public delegate void EventHandler(string message);

    public class Calendar
    {
        public event EventHandler HolidayOccured;
        Dictionary<int, string> holidays = new Dictionary<int, string>();
        public void holidayInitializer()
        {
            holidays[3] = "Saint day";
            holidays[5] = "Day of the Day";
            holidays[6] = "The dayest day ever";
        }
        public Dictionary<int, string> Holidays => holidays;
        public int CurrentDay { get; set; } = 1;

        public void checkForHoliday()
        {
            string holiday;
            if (holidays.ContainsKey(CurrentDay))
            {
                holiday = holidays[CurrentDay];
                HolidayOccured?.Invoke(holiday);
            }
            else 
            {
                HolidayOccured?.Invoke("not holiday");

            }
        }

        public Calendar() { }

        public void moveDay()
        {
            this.CurrentDay++;
        }

        
        
    }
}
