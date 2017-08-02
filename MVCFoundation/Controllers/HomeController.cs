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
        List<Month> months = new List<Month>
        {
            new Month{ Name = "January", Days= "31"},
            new Month{ Name = "February", Days = "28*"},
            new Month{ Name = "March", Days = "31"},
            new Month{ Name = "April", Days = "30"},
            new Month{ Name = "May", Days = "31"},
            new Month{ Name = "June", Days = "30"},
            new Month{ Name = "July", Days = "31"},
            new Month{ Name = "August", Days = "31"},
            new Month{ Name = "September", Days = "30"},
            new Month{ Name = "October", Days = "31"},
            new Month{ Name = "November", Days = "30"},
            new Month{ Name = "December", Days = "31"}
        };
        public ActionResult Index(string searchTerm)
        {
            if (Request.IsAjaxRequest())
            {
                var model = months.Where(m => m.Name.ToLower()
                 .StartsWith(searchTerm.ToLower()));
                return PartialView("_MonthPartial", model);
            }
            else
            return View(months);
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