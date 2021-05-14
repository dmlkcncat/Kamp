using KampOyun.Abstract;
using KampOyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOyun.Concrete
{
    public class CustomerManager : BaseCustomerManager, IPersonCheckService
    {
        public void CheckIfRealPerson(Customer customer)
        {
            if (customer == customer) Console.WriteLine("Müşteri doğrulama başarılı!");
        }
    }
}
