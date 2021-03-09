using System;
using System.Collections.Generic;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> workers = new List<IWorker> { new Manager(), new Worker(), new Robot()};
            foreach (var worker in workers)
            {
                worker.Work();
            }
            List<IEat> eats = new List<IEat> { new Manager(), new Worker() };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

        }

        interface IWorker
        {
            void Work();
        }
        interface IEat
        {
            void Eat();
        }
        interface ISalary
        {
            void GetSalary();
        }

        class Manager : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
        class Robot : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    } 
}
