using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_1
{
    internal class Stapel<T>
    {
        private List<T> stapel = new List<T>();
        public int teller = -1;

        public void addItem(T item)
        {
            stapel.Add(item);
            teller++;
        }

        public T deleteItem()
        {
            if (stapel.Count != 0)
            {
                T temp = stapel.ElementAt<T>(teller);
                stapel.RemoveAt(teller);
                teller--;
                return temp;
            }
            else { return default(T);
           }

        }
        public void removeList()
        {
            stapel.Clear();
            teller = -1;
        }
        public override string ToString()
        {
            string temp = null;
           foreach(T item in stapel)
            {
                temp += item.ToString();
                temp += ", ";
            }
            return temp;
        }
        public bool isPresent(T item)
        {
            return stapel.Contains(item);
        }
        public Stapel<T> stapelCopy()
        {
            return (Stapel<T>)this.MemberwiseClone();
        }
    }
}
