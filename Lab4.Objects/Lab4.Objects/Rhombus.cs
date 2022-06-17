using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Objects
{
    public class Rhombus : Figure
    {


        public double length_of_side { get; set; }

        public override double area { get; set; }

        public string colour { get; set; }

        public double sin_angle { get; set; }

        public override double count_perimeter()
        {
            return 4 * length_of_side;
        }

        public override double count_area()
        {
            return length_of_side * length_of_side * sin_angle;
        }
    }
}
