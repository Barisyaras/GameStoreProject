using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    public class PersonCheckService : ICustomerCheckService
    {
        public bool CheckIfRealPearson(Customer customer)
        {
            Console.WriteLine("Kişi doğrulandı.");
            return true;
        }
    }
}

