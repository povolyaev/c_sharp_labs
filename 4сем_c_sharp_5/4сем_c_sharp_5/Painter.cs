using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _4сем_c_sharp_5
{
    class Painter
    {
        private readonly PictureBox pictureBox;

        Bitmap bitmap;

        List<ViewObject> viewObjects;
        private readonly object viewObjectsLocker;

        private readonly List<ViewFigure> viewFigures;
        private readonly object viewFiguresLocker;

        private readonly Graphics graphics;
        private readonly Color backgroundColor;
        private readonly Font textFont;
        Timer timer;

        public Painter(PictureBox pictureBox, Color backgroundColor, Font textFont,
            List<ViewObject> viewObjects, object viewObjectsLocker,
            List<ViewFigure> viewFigures, object viewFiguresLocker)
        {
            this.pictureBox = pictureBox;
            this.viewObjects = viewObjects;
            this.viewObjectsLocker = viewObjectsLocker;
            this.viewFigures = viewFigures;
            this.viewFiguresLocker = viewFiguresLocker;
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);

            this.backgroundColor = backgroundColor;
            this.textFont = textFont;

            timer = new Timer();
            timer.Interval = 30;

            timer.Tick += new EventHandler((obj, e) =>
            {
                graphics.Clear(backgroundColor);

                lock (viewObjectsLocker)
                {
                    foreach (var item in viewObjects)
                    {
                        Draw(item);
                    }
                }

                lock (viewFiguresLocker)
                {
                    foreach (var item in viewFigures)
                    {
                        Draw(item);
                    }
                }

                pictureBox.Image = bitmap;
            });
        }

        void Draw(ViewObject viewObject)
        {
            graphics.DrawImage(viewObject.Image, viewObject.X - viewObject.Image.Width / 2, viewObject.Y - viewObject.Image.Height / 2);
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
