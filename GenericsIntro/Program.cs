﻿using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            isimler.Add("Engin");

            isimler.Add("Barış");
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
