using web_bansach.Areas.Admin.Data;
using web_bansach.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using web_bansach.Areas.Admin.Data;
namespace web_bansach.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : Controller
    {


        private readonly Storectx _context;
        public CustomerController(Storectx context)
        {
            _context = context;
        }
        public IActionResult allCustomer()
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.sqlListKH());
        }


        public IActionResult deleteCustomer(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.XoaKH(id);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

        public IActionResult searchCustomercontroller(string searchString)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.searchKH(searchString));
        }

        public RedirectResult lockCustomer(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            context.lockKH(id);
            return Redirect("allCustomer");
        }
        public RedirectResult unlockCustomer(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            context.unlockKH(id);
            return Redirect("allCustomer");

        }


        public IActionResult CustomerEmail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CustomerEmail(MailModel model)
        {

            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            foreach (var item in context.ListEmailCustomer())
            {
                //MailModel model = new MailModel();

                MailMessage mm = new MailMessage("mewbs.bookstore@gmail.com", item.GetType().GetProperty("Email").GetValue(item, null).ToString());
                //vtdat.1652001@gmail.com
                mm.Subject = model.Subject;
                mm.Body = model.Body;
                mm.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                NetworkCredential nc = new NetworkCredential("mewbs.bookstore@gmail.com", "framework@123");
                //vtdat.1652001@gmail.com
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = nc;
                smtp.Send(mm);
                ViewBag.Message = "Gửi mail thành công";
            }
            return View();

        }
    }
}
