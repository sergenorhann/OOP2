using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person> {
                new Person { FirstName = "Ali" },
                new Customer { FirstName = "Veli" },
                new Student { FirstName = "Salih" }
            };
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
        }

        class Person
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        class Customer:Person
        {
            public string City { get; set; }
        }

        class Student : Person
        {
            public string Departmant { get; set; }
        }

    }
}
