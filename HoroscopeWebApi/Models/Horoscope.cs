namespace HoroscopeWebAPi.Models
{
    public class Horoscope
    {
        public string horoscope { get; set; }
        public string sunsign { get; set; }

    }

    public class MonthlyHoroscope : Horoscope
    {
        public string month { get; set; }

    }

    public class DailyHoroscope : Horoscope
    {
        public string date { get; set; }

    }

    public class WeeklyHoroscope : Horoscope
    {
        public string week { get; set; }

    }

}