using System;

namespace HelloWorldApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO: Convert to Unit Tests:
            /*
            DateTime now = DateTime.Now;
            DateTime morningTest = new(now.Year, now.Month, now.Day, 8,00,00);
            DateTime afternoonTest = new(now.Year, now.Month, now.Day, 14,00,00);
            DateTime eveningTest = new(now.Year, now.Month, now.Day, 20,00,00);
            */
            Console.WriteLine($"Good {GetTimeOfDay()}, Christopher!");
        }

        public static string GetTimeOfDay()
        {
            return GetTimeOfDay(DateTime.Now);
        }

        public static string GetTimeOfDay(DateTime now)
        {
            Console.WriteLine($"{now}");
            DateTime noon = new(now.Year, now.Month, now.Day, 12,00,00);
            DateTime evening = new(now.Year, now.Month, now.Day, 17,00,00);

            if (now < noon) return "Morning";
            else if (now < evening) return "Afternoon";
            else return "Evening";
        }
    }
}
