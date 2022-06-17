using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Lab5.Objects;

namespace _4сем_c_sharp_5
{
    class ViewFigure : ViewObject
    {
        public Figure figure { get; }

        public override float X { get => figure.X; }
        public override float Y { get => figure.Y; }

        public ViewFigure(Figure figure, Image image) : base(image)
        {
            this.figure = figure;
        }
    }
}
