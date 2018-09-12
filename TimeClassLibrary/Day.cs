using System;

namespace TimeClassLibrary
{
    public class Day
    {
        private Hour Hour
        { get; set; }
        private Minute Minute
        { get; set; }
        public Day(int h, int m)
        {
            Hour = new Hour();
            Hour.Value = h;
            Minute = new Minute();
            Minute.Value = m;
        }
        public string CurrentTime()
        {
            if (Minute.ToString().Length == 2)
                return Hour.ToString() + ":" + Minute.ToString();
            return Hour.ToString() + ":0" + Minute.ToString();
        }
        public string TimesOfDayCalculation()
        {
            if (Hour.Value >= 5 && Hour.Value < 11)
                return "Утро";
            if (Hour.Value >= 11 && Hour.Value < 17)
                return "День";
            if (Hour.Value >= 17 && Hour.Value < 23)
                return "Вечер";
            if (Hour.Value == 23 || Hour.Value >= 0 && Hour.Value < 5)
                return "Ночь";
            return "Oops!";
        }
    }
}
