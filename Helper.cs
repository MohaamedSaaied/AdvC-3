using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_3
{
    internal class Helper<T>
    {

        public bool Exists(List<T> list, Predicate<T> match)
        {
            foreach (var item in list)
            {
                if (match(item))
                    return true;
            }
            return false;
        }

        public T Find(List<T> list, Predicate<T> match)
        {
            foreach (var item in list)
            {
                if (match(item))
                    return item;
            }
            return default(T);
        }

        public List<T> FindAll(List<T> list, Predicate<T> match)
        {
            List<T> result = new List<T>();
            foreach (var item in list)
            {
                if (match(item))
                    result.Add(item);
            }
            return result;
        }

        public int FindIndex(List<T> list, Predicate<T> match)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i]))
                    return i;
            }
            return -1;
        }

        public T FindLast(List<T> list, Predicate<T> match)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (match(list[i]))
                    return list[i];
            }
            return default(T);
        }

        public int FindLastIndex(List<T> list, Predicate<T> match)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (match(list[i]))
                    return i;
            }
            return -1;
        }

        public void ForEach(List<T> list, Action<T> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }

        public bool TrueForAll(List<T> list, Predicate<T> match)
        {
            foreach (var item in list)
            {
                if (!match(item))
                    return false;
            }
            return true;
        }

    }
}
