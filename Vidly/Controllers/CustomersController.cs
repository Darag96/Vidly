using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;
namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            // THIS QUERY WILL BE IMMEDIATELY EXECUTED BECAUSE WE'RE USIGN SINGLEORDEFAULT 
            var customer = _context.Customers.Include(c => c.MembershipType ).SingleOrDefault(c => c.Id == id);
            //var customer = GetCustomers().Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        // GET: Customer
        public ActionResult Index()
        {
            //var customers = this.GetCustomers();
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        private RandomMovieViewModel GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
            var customersView = new RandomMovieViewModel
            {
                Customers = customers
            };
            return customersView;
        }
    }
}