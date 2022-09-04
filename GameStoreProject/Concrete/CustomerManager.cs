using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    public class CustomerManager : ICustomer
    {
        List<Customer> CustomerList = new List<Customer>();
        
        public void Add(Customer customer)
        {
            CustomerList.Add(customer);
            Console.WriteLine("Oyuncu eklendi");
        }

        public void Delete(Customer customer)
        {
            CustomerList.Remove(customer);
            Console.WriteLine("Oyuncu silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi");
        }
    }
}
