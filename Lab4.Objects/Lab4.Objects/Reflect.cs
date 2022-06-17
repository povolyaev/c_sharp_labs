using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lab4.Objects
{
    public class Reflect
    {
        public static string MethodReflectInfo<T>(T obj) where T : class
        {
            string s = "***Список методов класса " + obj.ToString() + " ***\n";
            Type t = typeof(T);
            MethodInfo[] MArr = t.GetMethods();

            foreach (MethodInfo m in MArr)
            {
                s += " --> " + m.ReturnType.Name + " \t" + m.Name + "(";
                ParameterInfo[] p = m.GetParameters();
                for (int i = 0; i < p.Length; i++)
                {
                    s += p[i].ParameterType.Name + " " + p[i].Name;
                    if (i + 1 < p.Length)
                    {
                        s += ", ";
                    }
                }
                s += ")\n";
            }

            return s;
        }
        public static MethodInfo[] GetMethod<T>(T obj) where T : class
        {
            Type t = obj.GetType();
            MethodInfo[] MArr = t.GetMethods();

            return MArr;
        }
    }
}
