using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Objects
{
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
