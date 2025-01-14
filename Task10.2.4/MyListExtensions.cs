using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2._4
{
    public static class MyListExtensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] result = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                result[i] = list[i];
            }
            return result;
        }
    }
}
