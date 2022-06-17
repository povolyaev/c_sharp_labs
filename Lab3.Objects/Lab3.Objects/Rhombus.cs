using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Objects
{
    public class Rhombus : Figure
    {
        public Rhombus(string name, bool is_closed, int amount_of_angles, string colour, double sin_angle, double length) : base(name, is_closed, amount_of_angles)
        {
            this.colour = colour;
            this.sin_angle = sin_angle;
            this.length_of_side = length;
        }

        public double length_of_side { get; set; }

        public override double area { get { return area; } set { count_area(); } }

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
