using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Objects
{
    public abstract class RescueService : MovingFigure, IRescueService
    {
        private readonly List<Person> people;
        private readonly object personLocker;

        Person person;  // человек, которому нужна помощь

        public RescueService(Action<string> Notification, float defaultX, float defaultY, List<Person> people, object personLocker) : base(Notification, defaultX, defaultY)
        {
            DangerSavingIndexes = new List<int>();

            this.people = people;
            this.personLocker = personLocker;
        }

        public List<int> DangerSavingIndexes { get; }

        void Help()
        {
            if (IsMoving())
            {
                Notification("Служба спасения помогает человеку");
                Task.Delay(5000).Wait();

                person.isInDanger = false;
                person.IsLocked = false;

                Notification("Человеку больше ничего не угражает");

                DoSomething = null;
                IsLocked = false;

                ToX = defaultX;
                ToY = defaultY;
            }
        }

        protected override void CheckEvents()
        {
            if (IsLocked)
                return;

            lock (personLocker)
            {
                person = people.FirstOrDefault(person => person.isInDanger && DangerSavingIndexes.Contains(person.DangerIndex) && !person.WaitHelp);

                if (person != null)
                {
                    person.WaitHelp = true;
                    ToX = person.X;
                    ToY = person.Y;

                    IsLocked = true;
                    DoSomething = Help;

                    Notification("Служба спасение отправилась к человеку в беде");
                }
            }
        }
    }
}
