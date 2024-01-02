using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Calendar calendar = new Calendar(); 
            HolidayObserver observer = new HolidayObserver();

            calendar.holidayInitializer();

            calendar.HolidayOccured += observer.handleEvent;
            for (int i = 0; i < 15; i++)
            {
                Console.Write($" It's {calendar.CurrentDay} day of the month and ");
                calendar.moveDay();
                calendar.checkForHoliday();
            
            }

        }
    }
}
