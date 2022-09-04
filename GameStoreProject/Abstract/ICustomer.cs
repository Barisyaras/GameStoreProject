using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    interface ICustomer
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);

    }
}
