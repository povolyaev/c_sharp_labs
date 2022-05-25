using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4сем_c_sharp_3
{
    public interface IFigure
    {
        string name { get; set; }

        string existance();

        string say_hello();
    }

    public abstract class Figure : IFigure
    {
        public Figure(string name, bool is_closed, int amount_of_angles)
        {
            this.name = name;
            this.is_closed = is_closed;
            this.amount_of_angles = amount_of_angles;
        }

        public string name { get; set; }

        public string existance()
        {
            return "I exist";
        }

        public abstract double area { get; set; }

        public string say_hello()
        {
            return "Hello, my name is " + name;
        }

        public abstract double count_perimeter();

        public abstract double count_area();

        public bool is_closed { get; set; }

        public int amount_of_angles { get; set; }

    }


    public class Rhombus: Figure
    {
        public Rhombus(string name, bool is_closed, int amount_of_angles, string colour, double sin_angle, double length): base(name, is_closed, amount_of_angles)
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
