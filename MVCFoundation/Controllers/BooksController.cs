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
            new Book{ Id = 1, ISBN ="123456789", Title = "My Fantasy Bok", Rating = 4},
            new Book{ Id = 2, ISBN = "234567890", Title = "My Sci-Fi Bok", Rating =3 },
            new Book{ Id = 3, ISBN = "345678901", Title = "My Romance Novel", Rating = 9}
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
        public ActionResult Create(Book book)
        {
           
                // TODO: Add insert logic here
                if (TryUpdateModel(books))
                {
                    books.Add(book);
                    return RedirectToAction("Index");
                }              
            
                return View();
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

        public ActionResult GetStaticBooks()
        {
            return View("StaticBooks", books);
        }

        public ActionResult GetFirstBook()
        {
            var book = (from b in books
                        orderby b.Title descending
                        select b).FirstOrDefault();

            return PartialView("_BookPartial", book);
        }

        public ActionResult GetBestBook()
        {
            var book = from b in books
                       orderby b.Rating descending
                       select b;

            return PartialView("_BookDetailPartial", book.FirstOrDefault());
        }
    }
}
