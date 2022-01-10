using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using web_bansach.Areas.Admin.Data;
using web_bansach.Areas.Admin.Models;
using web_bansach.Models;
namespace web_bansach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.listBookHomePage());

        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

  

        public IActionResult all_bookhomepage()
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.allBookHomePage());

        }


        public IActionResult searchBookHome(string searchString)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.searchSach(searchString));
            
        }

        public IActionResult detailBook(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;

            return View(context.bookDetailHomePage2(id));

        }

        public IActionResult viewCart()
        {
            return View();
        }

        public IActionResult lienhe()
        {
            return View();
        }
        public IActionResult gioithieu()
        {
            return View();
        }
        public IActionResult chinhsach()
        {
            return View();
        }

        public IActionResult searchBookHomePage(string searchString)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.search_SachHomePage(searchString));
        }

        //public IActionResult orderDetail(int id)
        //{
        //    Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
        //    return View(context.DetailOrderHomePage(id));
        //}
        
    }
}
