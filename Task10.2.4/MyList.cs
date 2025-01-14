using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2._4
{
    public class MyList<T> : IEnumerable<T>
    {
        private T[] _items;
        private int _count;

        public MyList()
        {
            _items = new T[4]; // Початковий розмір масиву
            _count = 0;
        }

        // Властивість для отримання кількості елементів
        public int Count
        {
            get { return _count; }
        }

        // Індексатор для доступу до елементів за індексом
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException("Індекс виходить за межі списку.");
                return _items[index];
            }
        }

        // Метод додавання елемента
        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                // Збільшуємо розмір масиву, якщо він заповнений
                Array.Resize(ref _items, _items.Length * 2);
            }
            _items[_count++] = item;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
