using MVCFoundation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFoundation.Controllers
{
    public class BooksController : Controller
    {
        static List<Book> books = new List<Book>
        {
            new Book { Id = 1, ISBN ="123456789", Title = "My Fantasy Bok"},
            new Book{ Id = 2, ISBN = "234567890", Title = "My Sci-Fi Bok"},
            new Book{ Id = 3, ISBN = "345678901", Title = "<script>alert('You have been hacked!');</script>"}
        };

        // GET: Books
        public ActionResult Index()
        {
            var model = books.OrderByDescending(b => b.Title);
            return View(model);
        }

        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Books/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Books/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
