
using web_bansach.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_bansach.Controllers
{
    [Area("Admin")]
    public class AuthorController : Controller
    {
        public IActionResult addAuthor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertAuthorcontroller(AuthorModel a)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.InsertAuthor(a);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();

        }

        public IActionResult allAuthor()
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.sqlListtacgia());
        }


        public IActionResult deleteAuthor(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.XoaAuthor(id);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

        public IActionResult viewupdateAuthor(int id, string name)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            AuthorModel a = context.viewAuthor(id, name);
            ViewData.Model = a;
            return View();
        }


        public IActionResult updateAuthor(AuthorModel a)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.updateAuthor(a);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

        public IActionResult searchAuthorController(string searchString)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.searchAuthor(searchString));
        }
    }
}
