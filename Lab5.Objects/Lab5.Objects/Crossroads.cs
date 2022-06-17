using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Objects
{
    public class Crossroads : Figure
    {
        private readonly List<Person> people;
        private readonly object peopleLocker;

        List<Person> peopleInAction;
        string Name { get; }

        int maxPeopleInAction;

        public Crossroads(Action<string> Notification, List<Person> people, object peopleLocker, float x, float y, string name, int maxPeopleInAction = 5): base(Notification)
        {
            this.people = people;
            this.peopleLocker = peopleLocker;
            X = x;
            Y = y;

            peopleInAction = new List<Person>();
            Name = name;
            this.maxPeopleInAction = maxPeopleInAction;
        }

        bool StartAction()
        {
            peopleInAction.Clear();

            lock(peopleLocker)
            {
                int peopleInActionNumber = 0;
                for (int i = 0; i < people.Count && peopleInActionNumber < maxPeopleInAction; i++)
                {
                    if (!people[i].IsLocked)
                    {
                        people[i].ToX = X;
                        people[i].ToY = Y;
                        people[i].IsLocked = true;
                        peopleInAction.Add(people[i]);
                        peopleInActionNumber++;
                    }
                }
            }

            return peopleInAction.Count != 0;
        }

        void WaitAllPeople()
        {
            bool allPeopleFree = false;
            while (!allPeopleFree)
            {
                Task.Delay(100).Wait();
                lock (peopleLocker)
                {
                    allPeopleFree = peopleInAction.FirstOrDefault(item => !item.IsCome()) == null;
                }
            }
        }

        void DoAction()
        {
            Notification($"На перекрестке {Name} активничают {peopleInAction.Count} людей");
            WaitAllPeople();

            Notification($"Движение на {Name} начинается");
            Notification($"Движение на {Name} идёт");

            Task.Delay(10 * 1000).Wait();
        }

        void WaitHelp(List<Person> peopleInDanger)
        {
            bool safety = true;
            do
            {
                Task.Delay(100).Wait();
                safety = peopleInDanger.Count(person => person.isInDanger) == 0;
            } while (!safety);
        }

        void PrintAllDangers(List<Person> peopleInDanger)
        {
            string message = "";
            foreach (var item in peopleInDanger)
            {
                message += Danger.allDangers[item.DangerIndex] += "\r\n";
            }
            Notification(message);
        }

        List<Person> DeterminePeopleInDanger()
        {
            List<Person> peopleInDanger = new List<Person>();
            Random random = new Random();
            for (int i = 0; i < peopleInAction.Count; i++)
            {
                    peopleInAction[i].RandomDanger(random);
                    if (peopleInAction[i].isInDanger)
                        peopleInDanger.Add(peopleInAction[i]);
                    else
                        peopleInAction[i].IsLocked = false;
            }
            return peopleInDanger;
        }

        public void EndAction()
        {
            Notification($"Движение на {Name} закончилось");

            List<Person> peopleInDander = DeterminePeopleInDanger();

            if (peopleInDander.Count != 0)
            {
                Notification($"На перекрестке {Name} люди попали в беду\n");

                PrintAllDangers(peopleInDander);
                Notification($"Пока всех не спасут, движение на {Name} не начнётся");
                WaitHelp(peopleInDander);

                Notification($"Ситуация на {Name}: Все люди спасены!");
            }
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                Notification($"Скоро начнется движение на {Name}");

                Task.Delay(3000).Wait();

                if (!StartAction())
                {
                    Notification($"На перекрестке {Name} никого нет, движения не будет.");
                }
                else
                {
                    DoAction();
                    EndAction();
                }

                Task.Delay(5000).Wait();
            }    
        }
    }
}
