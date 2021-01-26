using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> newDictionary = new Dictionary<int, string>();
            newDictionary.Add(507, "Barışcan");
            newDictionary.Add(542, "Yeliz");
            newDictionary.Add(549, "Barış");

            Console.WriteLine("Numara giriniz: ");
            int No1 = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(newDictionary[No1]);
            }
            catch
            {
                Console.WriteLine("Böyle biri bulunmamakta");
            }

            MyDictionary<int, string> newMyDictionary = new MyDictionary<int, string>();
            newMyDictionary.Add(507, "Barışcan");
            newMyDictionary.Add(542, "Yeliz");
            newMyDictionary.Add(549, "Barış");

            newMyDictionary.Print();
               
        }
    }
    class MyDictionary<TKey,TValue>
    {
        TKey[] _key;
        TValue[] _value;
        TKey[] tempArrayKey;
        TValue[] tempArrayValue;
        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            tempArrayKey = _key;
            tempArrayValue = _value;
            _key = new TKey[tempArrayKey.Length + 1];
            _value = new TValue[tempArrayValue.Length + 1];
            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                _key[i] = tempArrayKey[i];
                _value[i] = tempArrayValue[i];
            }
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }

        public int Count
        {
            get { return _key.Length; }
            //set { myVar = value; }
        }
        public void Print()
        {
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine("Key: "+ _key[i]);
                Console.WriteLine("Value: "+_value[i]);
            }
        }

    }
}
