using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Objects
{
    public abstract class MovingFigure : Figure
    {
        protected float defaultX, defaultY;

        public float ToX { get; internal set; }
        public float ToY { get; internal set; }

        public MovingFigure(Action<string> Notification, float defaultX, float defaultY) : base(Notification)
        {
            this.defaultX = defaultX;
            this.defaultY = defaultY;

            X = defaultX;
            Y = defaultY;

            ToX = defaultX;
            ToY = defaultY;


            DoSomething = null;
        }

        protected Action DoSomething;

        const float maxSpeed = 10;

        protected abstract void CheckEvents();

        public bool IsMoving()
        {
            return Math.Abs(X - ToX) < 5 && Math.Abs(Y - ToY) < 5;
        }

        public bool IsCome()
        {
            return Math.Abs(X - ToX) < 5 && Math.Abs(Y - ToY) < 5;
        }

        public void Move()
        {
            // в пункте назначения
            if (IsMoving())
                return;

            if (X - ToX != 0)
            {
                Y += maxSpeed * (ToY - Y) / Math.Abs(X - ToX);
                X += maxSpeed * Math.Sign(ToX - X);
            }
            else
            {
                X += maxSpeed * (ToX - X) / Math.Abs(Y - ToY);
                Y += maxSpeed * Math.Sign(Y - ToY);
            }
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                CheckEvents();
                Move();

                DoSomething?.Invoke();

                Task.Delay(30).Wait();
            }
        }
    }
}
