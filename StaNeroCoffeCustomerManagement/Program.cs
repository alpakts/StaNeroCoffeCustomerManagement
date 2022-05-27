using StaNeroCoffeCustomerManagement.Abstracts;
using StaNeroCoffeCustomerManagement.Classes;
using System;

namespace StaNeroCoffeCustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerService(new MernisCustomerCheckManager());
            customerManager.Save(new Customer { Id = 1, Name = "alper", Surname = "aktaş", NationalId = 18565092040 });
                
        }
    }
}
