using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _4сем_c_sharp_5
{
    class ViewObject
    {
        public virtual float X { get; set; }
        public virtual float Y { get; set; }

        public Image Image { get; set; }

        public ViewObject(Image image)
        {
            this.Image = image;
        }

        public ViewObject(Image image, float x, float y)
        {
            this.Image = image;
            X = x;
            Y = y;
        }
    }
}
