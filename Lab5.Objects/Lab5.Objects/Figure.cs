using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Objects
{
    public abstract class Figure
    {
        public float X { get; internal set; }
        public float Y { get; internal set; }

        public bool IsLocked { get; internal set; }
        public bool IsCanceled { get; set; }
        public abstract void Start();

        public Action<string> Notification;

        public Figure(Action<string> Notification)
        {
            this.Notification = Notification;
        }
    }
}
