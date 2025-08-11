using HelloWorldApp;

namespace HelloWorldTests
{
    public class Tests
    {
        DateTime _now; //relative and subjective, set once
        [SetUp]
        public void Setup()
        {
            _now = DateTime.Now;
        }

        [Test]
        public void GetTimeOfDay_8am_Morning()
        {
            DateTime morningTest = new(_now.Year, _now.Month, _now.Day, 8,00,00);
            string timeOfDay = ConsoleUtilities.GetTimeOfDay(morningTest);
            Assert.IsTrue(timeOfDay.Equals("Morning"));
        }

        [Test]
        public void GetTimeOfDay_2pm_Afternoon()
        {
            DateTime afternoonTest = new(_now.Year, _now.Month, _now.Day, 14,00,00);
            string timeOfDay = ConsoleUtilities.GetTimeOfDay(afternoonTest);
            Assert.IsTrue(timeOfDay.Equals("Afternoon"));
        }

        [Test]
        public void GetTimeOfDay_8pm_Evening()
        {
            DateTime eveningTest = new(_now.Year, _now.Month, _now.Day, 20,00,00);
            string timeOfDay = ConsoleUtilities.GetTimeOfDay(eveningTest);
            Assert.IsTrue(timeOfDay.Equals("Evening"));
        }

        [Test]
        public void GetTimeOfDay_Noon_Afternoon()
        {
            DateTime eveningTest = new(_now.Year, _now.Month, _now.Day, 12,00,00);
            string timeOfDay = ConsoleUtilities.GetTimeOfDay(eveningTest);
            Assert.IsTrue(timeOfDay.Equals("Afternoon"));
        }

        [Test]
        public void GetTimeOfDay_1159pm_Evening()
        {
            DateTime eveningTest = new(_now.Year, _now.Month, _now.Day, 23,59,59);
            string timeOfDay = ConsoleUtilities.GetTimeOfDay(eveningTest);
            Assert.IsTrue(timeOfDay.Equals("Evening"));
        }

        [Test]
        public void GetTimeOfDay_1200am_Morning()
        {
            DateTime eveningTest = new(_now.Year, _now.Month, _now.Day, 00,00,01);
            string timeOfDay = ConsoleUtilities.GetTimeOfDay(eveningTest);
            Assert.IsTrue(timeOfDay.Equals("Morning"));
        }
    }
}