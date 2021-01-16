using System;

namespace input
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad;
            Console.Write("Adınızı Giriniz: ");
            ad = Console.ReadLine();

            Console.Write("Merhaba: " + ad);
            Console.ReadKey(); // Tuşa basana kadar açık kalması için
        }
    }
}
