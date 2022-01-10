

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using web_bansach.Areas.Admin.Data;
using web_bansach.Areas.Admin.Models;

namespace web_bansach.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly BookStoreContext _context;
        public BookController(BookStoreContext context)
        {
            _context = context;
        }

        public IActionResult addBook()
        {
            List<CategoryModel> cateList = new List<CategoryModel>();
            cateList = (from category in _context.Categories
                        where category.CategoryStatus == 0
                        select category).ToList();
            cateList.Insert(0, new CategoryModel { CategoryID = 0, CategoryName = "" });
            ViewBag.ListofCategory = cateList;


            List<AuthorModel> authorList = new List<AuthorModel>();
            authorList = (from author in _context.Authors
                          where author.AuthorStatus == 0
                          select author).ToList();
            authorList.Insert(0, new AuthorModel { AuthorID = 0, AuthorName = "" });
            ViewBag.ListofAuthor = authorList;

            List<ProducerModel> proList = new List<ProducerModel>();
            proList = (from pro in _context.Producers
                       where pro.ProducerStatus == 0
                       select pro).ToList();
            proList.Insert(0, new ProducerModel { ProducerID = 0, ProducerName = "" });
            ViewBag.ListofProducer = proList;

            return View();
        }

        [HttpPost]
        public IActionResult InsertBookcontroller(BookModel a)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.InsertBook(a);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();

        }

        public IActionResult allBook() 
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.listBookHomePage());

        }

        public IActionResult searchBook(string searchString)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.searchSach(searchString));
        }

        public IActionResult viewAddQuantity(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            BookModel a = context.viewBook(id);
            ViewData.Model = a;
            return View();
        }

        public IActionResult addQuantity(int BookID, int sl_old, int sl_add)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.tangSL(BookID, sl_old, sl_add);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

        public IActionResult deleteBook(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.xoaSach(id);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

        public IActionResult viewUpdateBook(int id)
        {
            List<CategoryModel> cateList = new List<CategoryModel>();
            cateList = (from category in _context.Categories
                        where category.CategoryStatus == 0
                        select category).ToList();
            cateList.Insert(0,new CategoryModel { });
            ViewBag.ListofCategory = cateList;


            List<AuthorModel> authorList = new List<AuthorModel>();
            authorList = (from author in _context.Authors
                          where author.AuthorStatus == 0
                          select author).ToList();
            authorList.Insert(0, new AuthorModel {  });
            ViewBag.ListofAuthor = authorList;

            List<ProducerModel> proList = new List<ProducerModel>();
            proList = (from pro in _context.Producers
                       where pro.ProducerStatus == 0
                       select pro).ToList();
            proList.Insert(0, new ProducerModel {  });
            ViewBag.ListofProducer = proList;

            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            //BookModel a = context.viewBook(id);
            //ViewData.Model = a;
            return View(context.bookDetailHomePage2(id));
        }


        public IActionResult updateBook(BookModel a)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.updateBook(a);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

     
    }
}
