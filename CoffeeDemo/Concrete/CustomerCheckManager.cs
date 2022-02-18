using CoffeeDemo.Abstract;
using CoffeeDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

     
    }
}
