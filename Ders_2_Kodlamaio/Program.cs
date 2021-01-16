using System;

namespace Ders_2_Kodlamaio
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself
            //const değişmeyen

            const int Degismeyen = 1;
            char Harf = '6';
            string Kategori_Etiketi = "Kategori";
            int Ogrenci_Sayisi = 32000;
            long Cok_Uzun_Sayi = 1000000000000000000;
            double Faiz_Orani= 1.45;
            bool Sisteme_Giris_Yapmis_Mi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            // Console.WriteLine("Degismeyen: " + Degismeyen + ", Harf: " + Harf + ", Kategori_etiketi: " + Kategori_Etiketi + ", Ogrenci_Sayisi: " + Ogrenci_Sayisi + ", Cok_Uzun_Sayi: " + Cok_Uzun_Sayi+ ", Faiz_Orani: " + Faiz_Orani + ", Sisteme_Giris_Yapmis_Mi: " + Sisteme_Giris_Yapmis_Mi);

            if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            
            if (Sisteme_Giris_Yapmis_Mi== true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Lütfen Giriş Yapın");
                fonksiyon();
            }
        }
        static void fonksiyon() 
        {
            Console.WriteLine("Selam Canım");
        }
    }
}
