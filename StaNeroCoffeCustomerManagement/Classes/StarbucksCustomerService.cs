using StaNeroCoffeCustomerManagement.Abstracts;
using StaNeroCoffeCustomerManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StaNeroCoffeCustomerManagement.Classes
{
    public class StarbucksCustomerService : BaseCustomerManager
    {
        private ICheckService _checkService;

        public StarbucksCustomerService(ICheckService checkService)
        {
            _checkService = checkService;
        }


        public override  void Save(Customer customer)
        {
            if (_checkService.CheckifRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
            


        }




    }
}
