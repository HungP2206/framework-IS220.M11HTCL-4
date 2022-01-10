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
    public class UserController : Controller
    {
        public IActionResult addUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertUsercontroller(UserModel p)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.InsertUser(p);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();

        }

        public IActionResult alluser()
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.sqlListUser());
        }


        public IActionResult deleteuser(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.XoaUser(id);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

        public IActionResult viewupdateUser(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            UserModel a = context.viewUser(id);
            ViewData.Model = a;
            return View();
        }


        public RedirectResult lockUser(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            context.lockND(id);
            return Redirect("allUser");
        }
        public RedirectResult unlockUser(int id)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            context.unlockND(id);
            return Redirect("allUser");
        }


            public IActionResult updateUser(UserModel p)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            int count = context.capnhatUser(p);
            if (count == 1)
                ViewData["kq"] = "1";
            else
                ViewData["kq"] = "0";
            return View();
        }

        public IActionResult searchUsercontroller(string searchString)
        {
            Storectx context = HttpContext.RequestServices.GetService(typeof(web_bansach.Areas.Admin.Models.Storectx)) as Storectx;
            return View(context.searchUser(searchString));
        }
    }
}
