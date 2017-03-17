using AspNetMvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.OmaTieto = "ABC123";
            NORTHWNDEntities entities = new NORTHWNDEntities();
            List<Customer> model = entities.Customers.ToList();
            entities.Dispose();

            return View(model);
        }
        public ActionResult Index2()
        {                 
            return View();
        }
    }
}