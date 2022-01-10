using web_bansach.Areas.Admin.Data;
using web_bansach.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_bansach.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        public IActionResult addCategory()

        {
            return View();
        }

        public IActionResult InsertCategorycontroller(CategoryModel c)
        {
            int count;
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            count = context.InsertCategory(c);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }


        public IActionResult allCategory()
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.sqlListCate());
        }


        public IActionResult deleteCategory(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.XoaCategory(id);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

        public IActionResult viewupdateCategory(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            CategoryModel a = context.viewCategory(id);
            ViewData.Model = a;
            return View();
        }


        public IActionResult updateCategory(CategoryModel c)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.capnhatCategory(c);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

        public IActionResult searchCategoryController(string searchString)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.searchCategory(searchString));
        }

       

    }
}
