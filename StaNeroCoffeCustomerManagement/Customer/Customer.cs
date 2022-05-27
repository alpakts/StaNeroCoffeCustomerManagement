using StaNeroCoffeCustomerManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaNeroCoffeCustomerManagement
{
    public class Customer:IEntity
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string  Surname { get; set; }
        public Int64 NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
