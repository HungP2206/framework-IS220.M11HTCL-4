using web_bansach.Areas.Admin.Data;
using web_bansach.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_bansach.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProducerController : Controller
    {
        public IActionResult addProducer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertProducercontroller(ProducerModel p)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.InsertProducer(p);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();

        }

        public IActionResult allProducer()
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.sqlListncc());
        }


        public IActionResult deleteProducer(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.XoaProducer(id);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

        public IActionResult viewupdateProducer(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            ProducerModel a = context.viewProducer(id);
            ViewData.Model = a;
            return View();
        }


        public IActionResult updateProducer(ProducerModel p)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.capnhatProducer(p);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

        public IActionResult searchProducerController(string searchString)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.searchProducer(searchString));
        }
    }
}
