using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Objects
{
    public class Person : MovingFigure
    {
        public bool isInDanger { get; internal set; }

        public int DangerIndex { get; internal set; }

        public Person(Action<string> Notification, float defaultX, float defaultY) : base(Notification, defaultX, defaultY)
        { }

        public bool WaitHelp { get; internal set; }

        public void RandomDanger(Random random)
        {
            if (random.Next(0, 10) < 4)
            {
                DangerIndex = random.Next(0, Danger.allDangers.Length);
                isInDanger = true;
                WaitHelp = false;
            }
        }



        protected override void CheckEvents()
        {
            if (!IsLocked)
            {
                ToX = defaultX;
                ToY = defaultY;
            }
        }
    }
}
