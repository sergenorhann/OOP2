using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Concrete;
using InterfaceAndAbstractDemo.Adapter;
using System;
using InterfaceAndAbstractDemo;

namespace InterdaceAndAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1997, 7, 16), FirstName = "Sergen", LastName = "Orhan", NationalityId = "" });
            Console.ReadLine();
        }
    }
}
