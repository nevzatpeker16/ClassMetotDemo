using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer musteri = new Customer();
            musteri.CustomerName = "Nevzat";
            musteri.CustomerSurname = "Peker";
            musteri.CustomerID = 1;
            musteri.CustomerBalance = 100.0;


            CustomerManager cm = new CustomerManager();

            cm.AddCustomer(musteri);




        }
    }
    
}
