using KampOyun.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOyun.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
