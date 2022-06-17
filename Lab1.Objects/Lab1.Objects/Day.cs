using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Objects
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

        public string time()
        {
            string result = "";
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
}
