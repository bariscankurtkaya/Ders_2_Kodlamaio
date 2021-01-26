using System;

namespace Constructor_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=7652,LastName="Kurtkaya",FirstName="Baris", City="Manisa"};
            Console.WriteLine(customer.Id);

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
            Console.WriteLine(customer2.Id);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person //Customer Class'ında Person'dan izler bulunmaktadır. //inheritance - Miras
    {
        //default constructor // Otomatik olarak çalışır.
        public Customer() //ctor //customer'ın çalışması için
        {
            Console.WriteLine("1.Yapıcı Blok Çalıştı");
        }
        public Customer(int id, string firstName, string lastName, string city) //customer2'nin çalışması için
        {
            Console.WriteLine("2.Yapıcı Blok Çalıştı");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public string City { get; set; }
    }
}
