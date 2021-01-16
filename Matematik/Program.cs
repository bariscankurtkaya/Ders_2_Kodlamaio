using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            dortIslem Dortislem = new dortIslem();
            Dortislem.Topla(2, 6);
            Dortislem.Çıkarma(2, 6);
            Dortislem.Çarpma(2, 6);
            Dortislem.Bölme(2, 6);
        }
    }
}
