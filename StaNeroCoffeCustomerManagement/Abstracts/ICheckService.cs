using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaNeroCoffeCustomerManagement.Abstracts
{
     public interface ICheckService
    {
        public bool CheckifRealPerson(Customer customer);
    }
}
