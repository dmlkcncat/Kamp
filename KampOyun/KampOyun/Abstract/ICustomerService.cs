using KampOyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOyun.Abstract
{
   public  interface ICustomerService
    {
        void register(Customer customer);
        void update(Customer customer);
        void delete(Customer customer);
    }
}
