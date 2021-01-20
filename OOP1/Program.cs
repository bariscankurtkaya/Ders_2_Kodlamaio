using System;

namespace OOP1
{
    class Program
    {           //ctrl+k+d kodu düzenler.
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2, UnitsInStock = 5,CategoryId = 5,ProductName= "Kalem",UnitPrice= 35 };

            Product[] products = new Product[] { product1, product2 };

            //Pascal CASE   //Camel Case !!! Önemli
            //case sensitive
            Product_Manager productManager = new Product_Manager();




            //productManager.Add(product1);// kamera yapan uygulama
            //Console.WriteLine(product1.ProductName); //kamera yapar

            //int sayi = 100;
            //productManager.BiseyYap(sayi);  //99 yapan uygulama
            //Console.WriteLine(sayi); //100 kalır

            //int,double,bool ... değer tip
            //diziler,class,abstract class, interface ... referans tip
        }
    }
}
