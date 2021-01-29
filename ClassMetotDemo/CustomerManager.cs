using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Id : " + customer.CustumerId);
            Console.WriteLine("Müşteri Adı : " + customer.CustomerFirstname);
            Console.WriteLine("Müşteri Soyadı : " + customer.CustomerLastname);
            Console.WriteLine("Müşterinin Ülkesi : " + customer.CustomerNation);
            
        }

        public void List(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşteri Id : " + customer.CustumerId);
                Console.WriteLine("Müşteri Adı : " + customer.CustomerFirstname);
                Console.WriteLine("Müşteri Soyadı : " + customer.CustomerLastname);
                Console.WriteLine("Müşterinin Ülkesi : " + customer.CustomerNation);
                Console.WriteLine("\n");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustumerId+ " nolu kişi sistemden silinmiştir.");
        }

    }
}
