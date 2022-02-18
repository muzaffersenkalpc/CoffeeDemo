using CoffeeDemo.Abstract;
using CoffeeDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDemo.Concrete
{
    public class NeroCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService customerCheckService;
        public override void Save(Customer customer)
        {
            base.Save(customer);
        }

    }
}
