using StaNeroCoffeCustomerManagement.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaNeroCoffeCustomerManagement.Classes
{
    public class CustomerCheckManager : ICheckService
    {
        public bool CheckifRealPerson(Customer customer)
        {
            return true;
        }
    }
}
