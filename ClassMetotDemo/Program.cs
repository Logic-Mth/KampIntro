using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustumerId = 1;
            customer1.CustomerFirstname = "Hakkı";
            customer1.CustomerLastname = "Karakaş";
            customer1.CustomerNation = "TR";

            Customer customer2 = new Customer();
            customer2.CustumerId = 2;
            customer2.CustomerFirstname = "Hakkı2";
            customer2.CustomerLastname = "Karakaş2";
            customer2.CustomerNation = "TR2";
            Console.WriteLine("----------------EKLENDİ---------------");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            Console.WriteLine("");
            Console.WriteLine("-----------LİSTELENDİ---------------");
            List<Customer> customers = new List<Customer> { customer1, customer2};
            customerManager.List(customers);
            Console.WriteLine("");
            Console.WriteLine("------------SİLİNDİ--------------------");
            customerManager.Delete(customer1);
           
           
           
        }
    }
}
