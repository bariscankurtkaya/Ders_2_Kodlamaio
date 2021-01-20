using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T type'ın t sinden geliyor
    {
        T[] items;
        public MyList() //constructor //classı newlersem otomatik olarak çalışacak burası ctor tab tab
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
        public T[] Items
        {
           get { return items; }
        }   
    }
}
