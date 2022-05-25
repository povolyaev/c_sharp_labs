using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4сем_c_sharp_1
{
    public class Day
    {
        public Hour h;
        public Minute m;

        public Day()
        {
            h = new Hour();
            h.set_hour(0);
            m = new Minute();
            m.set_min(0);
        }

        public Day(int hour, int min)
        {
            h.set_hour(hour);
            m.set_min(min);
        }

        public string time()
        {
            string result="";
            if (h.get_hour() == 0)
                result += "0";
            result += h.get_hour().ToString();
            result += ":";
            if (m.get_min() < 10)
                result += "0";
            result += m.get_min().ToString();
            return result;
        }

        public string func()
        {
            int hour = h.get_hour();
            if (hour == 23 || hour < 6)
                return "Ночь";
            else
                if (hour < 12)
                return "Утро";
            else
                    if (hour < 18)
                return "День";
            else
                return "Вечер";
        }
    }

    public class Hour
    {
        int hour;

        public void set_hour(int h)
        {
            if (h >= 0 && h < 24)
                hour = h;
            else
                hour = 0;
        }

        public int get_hour()
        {
            return hour;
        }

        public Hour()
        {
            hour = 0;
        }
        public Hour(int h)
        {
            set_hour(h);
        }
    }

    public class Minute
    {
        int min;

        public void set_min(int m)
        {
            if (m < 60 && m >= 0)
                min = m;
            else
                min = 0;
        }

        public int get_min()
        {
            return min;
        }

        public Minute()
        {
            min = 0;
        }

        public Minute(int m)
        {
            set_min(m);
        }
    }

}
