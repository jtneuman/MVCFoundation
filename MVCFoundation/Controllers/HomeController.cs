using MVCFoundation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFoundation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var contact = new ContactModel()
            {
                ContactEmail = "contact@company.com",
                ContactName = "Jane Smith"
            };

            return View(contact);
        }
    }
}