using KampOyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOyun.Abstract
{
    interface IPersonCheckService
    {
        void CheckIfRealPerson(Customer customer);
    }
}
