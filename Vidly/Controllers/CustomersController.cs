using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        //customers/customer
        public ActionResult Customer()
        {
            var cust = new List<Customer>()
            {
                //new Customer { Name = "John Smith" },
                //new Customer { Name = "Mary Williams" },
            };
            var viewModel = new CustomersViewModel
            {
                Customers = cust
            };
            return View(viewModel);
        }

        //customers/customer/{id}
        public ActionResult Details(int id)
        {
            var cust = new Customer();
            cust.Id = id;

            if (id == 1)
                cust.Name = "John Smith";
            else if (id == 2)
                cust.Name = "Mary Williams";
            else
                return HttpNotFound();

            return View(cust);
        }
    }
}