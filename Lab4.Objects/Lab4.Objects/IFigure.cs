using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Objects
{
    public interface IFigure
    {
        string name { get; set; }

        string existance();

        string say_hello();
    }
}
