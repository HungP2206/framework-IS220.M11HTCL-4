using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_bansach.Areas.Admin.Models;
using web_bansach.Models;

namespace web_bansach.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult News()
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.sqlListNews());
        }

        public IActionResult detailNews(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            newsModel a = context.detailsNews(id);
            ViewData.Model = a;
            return View();
        }

    }
}
