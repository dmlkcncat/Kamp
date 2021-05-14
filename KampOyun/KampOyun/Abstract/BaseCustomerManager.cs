using System;
using System.Collections.Generic;
using System.Text;
using KampOyun.Entities;

namespace KampOyun.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void register(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " -> " + "Kaydınız başarıyla tamamlanmıştır!");
        }

        public void update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " -> Kaydınız başarıyla güncellenmiştir.");
        }

        public void delete(Customer customer)
        {
            Console.WriteLine("Kaydınız başarıyla silinmiştir!");
        }
    }
}
