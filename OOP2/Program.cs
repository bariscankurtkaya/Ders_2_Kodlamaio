using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID
            Person customer1 = new Person();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.FirstName = "Barışcan";
            customer1.LastName = "Kurtkaya";
            customer1.TC = "123456789";

            Company customer2 = new Company();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Yıldız Tech";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new Person();
            Customer customer4 = new Company();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
