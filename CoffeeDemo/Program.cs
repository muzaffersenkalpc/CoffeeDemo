using CoffeeDemo.Abstract;
using CoffeeDemo.Adapters;
using CoffeeDemo.Concrete;
using CoffeeDemo.Entities;
using System;

namespace CoffeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1996,5,21), FirstName = "MUZAFFER", LastName = "ŞENKAL", NationalityId = "19504383882" }); ;


            Console.ReadLine();            
        }

    }
}
