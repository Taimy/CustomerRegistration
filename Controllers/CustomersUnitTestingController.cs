using CustomerRegistration.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerRegistration.Controllers
{
    [TestClass]
    public class CustomersUnitTestingController : Controller
    {
        CustomersController controller = new CustomersController();
        [TestMethod]
        public void GetCustomer()
        {
            int Id = 1;
            Customer expectedCustomer = new Customer { 
            FirstName = "Taiwo",
            LastName = "Shittu",
            Address = "Nigeria",
            DateOfBrith = Convert.ToDateTime(""),
            DateRegistered = Convert.ToDateTime("")
            };
            var result = controller.GetCustomer(Id);
            Assert.AreEqual(expectedCustomer, result);
        }
        [TestMethod]
        public void PutCustomer()
        {

        }
        [TestMethod]
        public void PostCustomer()
        { 

        }

        [TestMethod]
        public void DeleteCustomer()
        {

        }
        [TestMethod]
        public void Search()
        {

        }
    } 
}