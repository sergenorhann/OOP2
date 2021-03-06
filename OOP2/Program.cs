using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Indıvidual indıvidual1 = new Indıvidual();
            indıvidual1.Id = 1;
            indıvidual1.CustomerNumber = "125";
            indıvidual1.Name = "Ali";
            indıvidual1.LastName = "Yılmaz";
            indıvidual1.TcNo = "1234567890";

            Corporate corporate1 = new Corporate();
            corporate1.Id = 2;
            corporate1.CustomerNumber = "125";
            corporate1.CompanyName = "Kodlama.io";
            corporate1.TaxNumber = "234";

            Customer indıvidual2 = new Indıvidual();
            Customer corporate2 = new Corporate(); 




        }
    }
}
