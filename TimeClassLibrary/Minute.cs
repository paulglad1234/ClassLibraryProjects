using System;

namespace TimeClassLibrary
{
    class Minute
    {
        private int v;
        public int Value
        {
            get { return v; }
            set {
                if (value < 0 || value > 59)
                    throw new Exception("Минуты должны быть указаны в пределах от 0 до 59 включительно.");
                else v = value;
            }
        }
        public string ToString()
        {
            return Convert.ToString(Value);
        }
    }
}
