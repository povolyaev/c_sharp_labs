using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Objects
{
    public class Firefighters : RescueService
    {
        public Firefighters(Action<string> Notification, float defaultX, float defaultY, List<Person> people, object personLocker)
            : base(Notification, defaultX, defaultY, people, personLocker)
        {
            for (int i = 0; i < Danger.allDangers.Length; i++)
                if (Danger.allDangers[i].Contains("ожар"))
                    DangerSavingIndexes.Add(i);
        }
    }
}
