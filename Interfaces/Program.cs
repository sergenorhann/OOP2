using System;
using System.Collections.Generic;

namespace Interfaces
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //    PersonManager personManager1 = new PersonManager();
            //    personManager1.Add(new Customer{Id = 1, FirstName = "ali", LastName = "veli", Address = "Adana"});
            //    personManager1.Add(new Student { Id = 1, FirstName = "ali", LastName = "veli"});
            List<ICustomerDal> customerDals = new List<ICustomerDal> {new  OracleServerCustomerDal(), new SqlServerCustomerDal()};
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

        }
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get ; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName); ;
            }
        }
    }
}
