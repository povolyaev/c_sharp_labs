using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Objects
{
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
}
