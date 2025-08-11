using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    public class ConsoleUtilities
    {
        public static string GetTimeOfDay()
        {
            return GetTimeOfDay(DateTime.Now);
        }

        public static string GetTimeOfDay(DateTime now)
        {
            Console.WriteLine($"Time | {now}"); //Convert to Logging
            DateTime noon = new(now.Year, now.Month, now.Day, 12, 00, 00);
            DateTime evening = new(now.Year, now.Month, now.Day, 17, 00, 00);

            if (now < noon) return "Morning";
            else if (now < evening) return "Afternoon";
            else return "Evening";
        }
    }
}
