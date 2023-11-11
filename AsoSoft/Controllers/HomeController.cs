using AsoSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AsoSoft.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllBooks()
        {
            using (BookDBContext contextobj = new BookDBContext())
            {
                var booklist = contextobj.book.ToList();

                return Json(booklist, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult GetBookById(string id)
        {
            using (BookDBContext contextobj = new BookDBContext())
            {
                var BookId = int.Parse(id);
                var getBookById = contextobj.book.Find(BookId);

                return Json(getBookById, JsonRequestBehavior.AllowGet);
            }
        }

        public string UpdateBook(Book book)
        {
            if (book != null)
            {
                using (BookDBContext contextobj = new BookDBContext())
                {
                    contextobj.book.Add(book);
                    contextobj.SaveChanges();

                    return "Book record added successfully";
                }
            }
            else
            {
                return "Invalid Book record";
            }
        }

        public string DeleteBook(string bookId)
        {
            if (!string.IsNullOrEmpty(bookId))
            {
                try
                {
                    int _bookId = int.Parse(bookId);

                    using (BookDBContext contextobj = new BookDBContext())
                    {
                        var _book = contextobj.book.Find(_bookId);
                        contextobj.book.Remove(_book);
                        contextobj.SaveChanges();

                        return "Selected book record deleted successfully";
                    }
                }
                catch (Exception)
                {
                    return "Book details not found";                  
                }
            }
            else
            {
                return "Invalid operation";
            }
        }

    }
}