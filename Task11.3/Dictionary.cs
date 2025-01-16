using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._3
{
    public class Dictionary<TKey, TValue>
    {
        private List<TKey> keys;
        private List<TValue> values;

        public Dictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = keys.IndexOf(key);
                return values[index];
            }
            set
            {
                int index = keys.IndexOf(key);
                if (index == -1)
                {
                    keys.Add(key);
                    values.Add(value);
                }
                else
                {
                    values[index] = value;
                }
            }
        }

        public int Count
        {
            get { return keys.Count; }
        }
    }
}
