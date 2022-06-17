using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Objects
{
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
}
