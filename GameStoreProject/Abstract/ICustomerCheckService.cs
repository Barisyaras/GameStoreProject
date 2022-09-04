using System;
using System.Text;

namespace GameStoreProject
{
    interface ICustomerCheckService
    {
        bool CheckIfRealPearson(Customer customer);
    }
}
