using CoffeeDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
