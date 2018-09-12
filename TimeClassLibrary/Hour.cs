using System;

namespace TimeClassLibrary
{
    class Hour
    {
        private int v;
        public int Value
        {
            get { return v; }
            set { if (value < 0 || value > 23)
                    throw new Exception("Часы должны быть в пределах от 0 до 23 включительно.");
                else v = value;
            }
        }
        public string ToString()
        {
            return Convert.ToString(Value);
        }
    }
}
