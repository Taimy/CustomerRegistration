using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerRegistration.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBrith { get; set; }
        public string Address { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}