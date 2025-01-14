using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    class MyList<T>
    {
        private T[] arr;

        public T this[int index]
        {
            get
            {
                if (index <= 0 || index > arr.Length)
                    throw new IndexOutOfRangeException("Індекс має бути в межах від 1 до arr.Length.");
                return arr[index - 1];
            }
            set
            {
                if (index <= 0 || index > arr.Length)
                    throw new IndexOutOfRangeException("Індекс має бути в межах від 1 до arr.Length.");
                arr[index - 1] = value;
            }
        }
        
        
        public int LengthList => arr.Length;

        public MyList()
        {
            arr = new T[0];
        }

        public void Add(T value)
        {
            T[] newArr = new T[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[arr.Length] = value;
            arr = newArr;
        }
    }
}
