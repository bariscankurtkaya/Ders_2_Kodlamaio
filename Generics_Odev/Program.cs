using System;
using System.Collections.Generic;

namespace Generics_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
            foreach (var items in sehirler)
            {
                Console.WriteLine(items);
            }

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);

            sehirler2.Print();

        }
    }

    class MyList<T>  //Generic class
    {
        T[] _array;
        T[] _tempArray;
        public MyList() //ctor - constructor //newlendiğinde bu çalışacak.
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count //propfull ile açtık
        {
            get { return _array.Length; }
            //set { _array.Length = value; } //set etmek istemiyorum.
        }
        public void Print()
        {
            foreach (var items in _array)
            {
                Console.WriteLine(items);
            }
        }

    }
}
