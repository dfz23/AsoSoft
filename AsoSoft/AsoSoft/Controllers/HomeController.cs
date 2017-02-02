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
                var getBookId = contextobj.book.Find(BookId);

                return Json()
            }
        }
    }
}