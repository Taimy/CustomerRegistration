using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerRegistration.EntityModel
{

    public class CustomerEntity
    {
        public CustomerEntity()
        {
            Address = new List<AddressComponent>();
            Orders = new List<Order>();
        }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public DateTime Age { get; set; }
        public Gender Gender { get; set; }
        public List<AddressComponent> Address { get; set; }
        public List<Order> Orders { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public class AddressComponent
    {
        public string Street { get; set; }
        public string Postcode { get; set; }
        public int HouseNumber { get; set; }
    }

    public class Order
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public double Amount { get; set; }
    }

}

