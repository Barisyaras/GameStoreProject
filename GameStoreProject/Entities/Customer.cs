using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateofBirth { get; set; }
        public bool HavetheGame { get; set; }
    }
}
