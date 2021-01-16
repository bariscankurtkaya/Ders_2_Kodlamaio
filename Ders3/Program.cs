using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 150;
            product1.Aciklama = "Amasya Elması";

            Product[] product = new Product[] { product1};

            Console.WriteLine("Methods****************");

            SepetManager sepet = new SepetManager();
            sepet.Ekle(product1);

        }
    }
}


//Do not repeat yourself - DRY - Clean Code - Best Practice
