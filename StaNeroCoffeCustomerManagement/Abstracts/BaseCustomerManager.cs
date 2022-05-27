using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaNeroCoffeCustomerManagement.Abstracts
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved To db :"+customer.Name+" "+customer.Surname);
        }
    }
}
