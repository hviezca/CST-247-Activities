using Activity3Part1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity3Part1.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();

        public CustomerController()
        {
            customers.Add(new CustomerModel { Id = 0, Name = "Hiram", Age = 34 });
            customers.Add(new CustomerModel { Id = 1, Name = "Sherlock", Age = 7 });
            customers.Add(new CustomerModel { Id = 2, Name = "Watson", Age = 6 });
            customers.Add(new CustomerModel { Id = 3, Name = "Jhon", Age = 18 });
            customers.Add(new CustomerModel { Id = 4, Name = "Dan", Age = 40 });
            customers.Add(new CustomerModel { Id = 5, Name = "N'nette", Age = 35 });
        }

        public IActionResult Index()
        {            
            return View(Tuple.Create(customers, customers[0]));
        }

        [HttpPost]
        public IActionResult OnSelectCustomer(int Id)
        {
            ViewBag.Title = "Customer Details";

            CustomerModel c = customers.FirstOrDefault(x => x.Id == Id);            

            return PartialView("_CustomerDetails", Tuple.Create(customers, c));
        }

        [HttpPost]
        public string GetMoreInfo(string id)
        {
            string returnString = "Good Job!";

            return returnString;
        }
    }
}
