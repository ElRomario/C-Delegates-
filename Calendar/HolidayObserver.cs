using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public delegate void HolidayEventHandler(string holidayName);
    internal class HolidayObserver
    {
        public event HolidayEventHandler HolidaysOccured;

        public void checkForHoliday(int currentDay, Dictionary<int, string> holidays)
        {
            string holiday;
            if(holidays.ContainsKey(currentDay)) 
            {
                holiday = holidays[currentDay];
                HolidaysOccured?.Invoke(holiday);
            }
        }

        public void handleEvent(string message)
        {
            Console.WriteLine($"this day is {message}");
        }

        public HolidayObserver()
        {
            
        }
    }
}
