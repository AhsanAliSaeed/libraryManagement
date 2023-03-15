
using libraryManagement.DContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace libraryManagement.Controllers
{
    public class LibraryController : Controller
    {
        private readonly LibraryContext context;

        public LibraryController(LibraryContext context)
        {
            this.context = context;
        }

        public JsonResult Book()
        {
            //var data = context.Book.ToList();
            var data = context.Book.FromSqlRaw("sp_BookDetail").ToList();
            return new JsonResult(data);
        }
        public JsonResult Author(int? id)
        {
            var data = context.Author.Where(a => a.Book.BookID == id).ToList();
            return new JsonResult(data);
        }
        public IActionResult LibraryDropdown()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
