using System;

namespace Ders_2._2_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string Kurs2 = "Programlamaya başlangıç için temel kurs";
            //string Kurs3 = "Java";
            //Javada string'in S si büyük ve console.writeline yerine System.out.println

            //Listeler array-dizi 'lerde tutulur

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java",
                "Python"};

            for (int i =0; i < kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("\n1.Döngü bitti!\n");

            //foreach dizileri kolay dolaşırken kullanılır.

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("\n2.Döngü bitti!\n");
        }
    }
}
