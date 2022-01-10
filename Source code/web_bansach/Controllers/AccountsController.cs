using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using web_bansach.Areas.Admin.Data;
using web_bansach.Areas.Admin.Models;
using web_bansach.Extension;
using web_bansach.Helpers;
using web_bansach.Models;
using web_bansach.ModelView;

namespace web_bansach.Controllers
{
  
    public class AccountsController : Controller
    {
       
        private readonly BookStoreContext _context;
        //public INotyfService _notifyService { get; }
        private readonly INotyfService _notfy;
        public AccountsController(BookStoreContext context, INotyfService notfy)
        {
            _context = context;
            _notfy = notfy;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ThongBao()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            var taikhoanID = HttpContext.Session.GetString("CustomerID");
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerID == Convert.ToInt32(taikhoanID));
                if (khachhang != null)
                {
                    return View(khachhang);
                }
            }
            return RedirectToAction("Login");
        }
        public IActionResult Dashboard_Login()
        {
            var taikhoanID = HttpContext.Session.GetString("CustomerID");
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerID == Convert.ToInt32(taikhoanID));
                if (khachhang != null)
                {
                    return View(khachhang);
                }
            }
            return RedirectToAction("Login");
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult ValidatePhone(string PhoneNumber)
        {
            try
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.PhoneNumber.ToLower() == PhoneNumber.ToLower());
                if (khachhang != null)
                    return Json(data: "Số điện thoại: " + PhoneNumber + " đã được sử dụng");
                else
                    return Json(data: true);
            }
            catch { return Json(data: true); }
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult ValidateEmail(string Email)
        {
            try
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == Email.ToLower());
                if (khachhang != null)
                    return Json(data: "Email: " + Email + " đã được sử dụng");
                return Json(data: true);
            }
            catch { return Json(data: true); }
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult ValidateUsername(string UserName)
        {
            try
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.UserName.ToLower() == UserName.ToLower());
                if (khachhang != null)
                    return Json(data: "Tên tài khoản: " + UserName + " đã được sử dụng");
                return Json(data: true);
            }
            catch { return Json(data: true); }
        }


        [HttpGet]
        public IActionResult DangKyTaiKhoan()
        {
           
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
       
        public async Task<IActionResult> DangKyTaiKhoan(RegisterViewModel taikhoan)
        {


            try
            {
                if (ModelState.IsValid)
                {

                    string salt = Utilities.GetRandomKey();
                    CustomerModel khachhang = new CustomerModel
                    {
                        CustomerName = taikhoan.CustomerName,
                        Email = taikhoan.Email,
                        UserName = taikhoan.UserName,
                        Password = (taikhoan.Password + salt.Trim()).ToMD5(),
                        Role = 2,
                        Salt = salt,
                        Created_at = DateTime.Now,
                        CustomerStatus = 0,
                        PhoneNumber = taikhoan.PhoneNumber
                    };
                    try
                    {
                        _context.Add(khachhang);
                        await _context.SaveChangesAsync();

                        HttpContext.Session.SetString("CustomerName", taikhoan.CustomerName.ToString());
                        ViewBag.CustomerName = HttpContext.Session.GetString("CustomerName");

                        HttpContext.Session.SetString("CustomerID", khachhang.CustomerID.ToString());
                        var taikhoanID = HttpContext.Session.GetString("CustomerID");

                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, khachhang.CustomerName),
                            new Claim("CustomerID", khachhang.CustomerID.ToString())
                        };
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);

                        _notfy.Success("Đăng ký thành công");
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                        catch
                    {
                       return RedirectToAction("Login", "Accounts");
                    }
                
                }
                else
                {
                    return View(taikhoan);
                }
            }
            catch { return View(taikhoan); }
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            var taikhoanID = HttpContext.Session.GetString("CustomerID");
            if(taikhoanID != null)
            {
                return RedirectToAction("Dashboard", "Accounts");
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel customer, string returnUrl = null)
        {
            try
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.UserName.Trim() == customer.UserName);
                //_notfy.Success("conheo");
                if (khachhang == null) 
                    return RedirectToAction("DangKyTaiKhoan", "Accounts");
                string pass = (customer.Password + khachhang.Salt.Trim()).ToMD5();
                
                if(khachhang.Password != pass)
                {
                    _notfy.Success("Thông tin đăng nhập chưa chính xác");
                    //swal("Good job!", "You clicked the button!", "success");
                    return View(customer);
                }

                if(khachhang.CustomerStatus == 1) return RedirectToAction("ThongBao", "Accounts");

                HttpContext.Session.SetString("CustomerName", khachhang.CustomerName.ToString());
                //var tenKH = HttpContext.Session.GetString("CustomerName");
                //ViewBag.tenKH = tenKH;
                HttpContext.Session.SetString("CustomerID", khachhang.CustomerID.ToString());
                var taikhoanID = HttpContext.Session.GetString("CustomerID");

                var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, khachhang.CustomerName),
                            new Claim("CustomerID", khachhang.CustomerID.ToString())
                        };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                _notfy.Success("Đăng nhập thành công");
                return RedirectToAction("Index", "Home");
            }
            catch 
            { 
                return RedirectToAction("DangKyTaiKhoan", "Accounts");
            }

            //return View(customer);
        }


        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("CustomerID");
            HttpContext.Session.Remove("CustomerName");
            HttpContext.Session.Remove("GioHang");
            
            return RedirectToAction("Index", "Home");
        }
    }
}
