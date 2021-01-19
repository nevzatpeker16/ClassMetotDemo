using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Musteri Eklendi");
            Console.WriteLine("******************");
            Console.WriteLine("Musteri Adı : {0}  Musteri Soyad : {1}  Musteri Bakiyesi : {2}", customer.CustomerName, customer.CustomerSurname,customer.CustomerBalance);

        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Musteri Silindi");
            Console.WriteLine("******************");
            Console.WriteLine("Musteri Adı : {0}  Musteri Soyad : {1}  Musteri Bakiyesi : ", customer.CustomerName, customer.CustomerSurname, customer.CustomerBalance);
        }
            
    }
}
