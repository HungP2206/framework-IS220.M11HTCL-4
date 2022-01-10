using web_bansach.Areas.Admin.Data;
using web_bansach.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rotativa.AspNetCore;
using Rotativa;

namespace web_bansach.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {

        private readonly Storectx _context;
        public OrderController(Storectx context)
        {
            _context = context;
        }
        public ActionResult allOrder()
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.sqlListOrder());
        }
        public IActionResult viewdetailOrder(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.sqlListDetailOrder(id));
        }
        public IActionResult searchOrder(string searchString)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.searchOrder(searchString));
        }

        public IActionResult viewupdateOrder(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            OrderModel a = context.viewOrder(id);
            ViewData.Model = a;
            return View();
        }

        public IActionResult updateOrder(OrderModel p)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.updateOrder(p);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

        public IActionResult detailOrderPDF(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            //OrderModel a = new OrderModel();

            return new ViewAsPdf("detailOrderPDF", context.sqlListDetailOrder(id));
        }

        //context.sqlListDetailOrder(id)
        //public IActionResult orderDetail(int id)
        //{
        //    Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
        //    return View(context.DetailOrderHomePage(id));
        //}
    }
}
