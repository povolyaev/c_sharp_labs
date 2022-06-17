using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Objects
{
    public static class Danger
    {
        static string[] _allDangers = new string[]
            {
                "Пожар №1",
                "Пожар №2",
                "Пожар №3",
                "Преступление №1",
                "Преступление №2",
                "Преступление №2",
                "Травма №1",
                "Травма №2",
                "Травма №3"
            };
        public static string[] allDangers { get => _allDangers; }
    }
}
