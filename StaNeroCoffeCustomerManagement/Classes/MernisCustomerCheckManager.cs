using StaNeroCoffeCustomerManagement.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisService;

namespace StaNeroCoffeCustomerManagement.Classes
{
    public class MernisCustomerCheckManager : ICheckService
    {
        public bool CheckifRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalId), customer.Name.ToUpper(),
                customer.Surname.ToUpper(), customer.DateOfBirth.Year);
        }

  
    }
}
