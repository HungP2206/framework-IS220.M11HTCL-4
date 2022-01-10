using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_bansach.Areas.Admin.Data;
using web_bansach.Areas.Admin.Models;
using web_bansach.Extension;
using web_bansach.Models;
using web_bansach.ModelView;

namespace web_bansach.Controllers
{
    public class CheckoutController : Controller
    {
        
        private readonly BookStoreContext _context;
        public INotyfService _notifyService { get; }
        public CheckoutController(BookStoreContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }

        [HttpGet]
        public IActionResult Index(string returnUrl = null)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            if(cart != null)
            {
                var taikhoanID = HttpContext.Session.GetString("CustomerID");
                MuaHang model = new MuaHang();
                if (taikhoanID != null)
                {
                    var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerID == Convert.ToInt32(taikhoanID));
                    model.CustomerID = khachhang.CustomerID;
                    model.CustomerName = khachhang.CustomerName;
                    model.Email = khachhang.Email;
                    model.PhoneNumber = khachhang.PhoneNumber;
                    model.Address = khachhang.Address;
                }
                ViewBag.GioHang = cart;
                return View(model);
            }
            else
            {
                return RedirectToAction("Index", "Cart");
            }
        }

        [HttpPost]
        public IActionResult Index(MuaHang muaHang)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CustomerID");
            MuaHang model = new MuaHang();
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerID == Convert.ToInt32(taikhoanID));
                model.CustomerID = khachhang.CustomerID;
                model.CustomerName = khachhang.CustomerName;
                model.Email = khachhang.Email;
                model.PhoneNumber = khachhang.PhoneNumber;
                model.Address = khachhang.Address;

                khachhang.CustomerName = muaHang.CustomerName;
                khachhang.Email = muaHang.Email;
                khachhang.PhoneNumber = muaHang.PhoneNumber;
                khachhang.Address = muaHang.Address;
                model.Address =  muaHang.Address;

                _context.Update(khachhang);
                _context.SaveChanges();
            }
            try
            {
                if (ModelState.IsValid)
                {
                    OrderModel donhang = new OrderModel();
               
                    donhang.OrderID = default;
                    donhang.CustomerID = model.CustomerID;
                    donhang.Address = model.Address;
                    donhang.CustomerName = model.CustomerName;
                    donhang.Created_at = DateTime.Now;
                    donhang.Total = Convert.ToInt32(cart.Sum(x => x.TotalMoney)); //  là tổng tiền cua don hang
                    donhang.OrderStatus = 0; //đơn hàng mới
                    

                    _context.Add(donhang);
                    _context.SaveChanges();
                   

                    foreach (var item in cart)
                    {
                        //var id = item.BookID;
                        //var book = _context.Books.AsNoTracking().SingleOrDefault(x => x.BookID == Convert.ToInt32(id));
                        //if(book != null)
                        //{
                        //    book.Quantity -= item.Quantity;
                        //    _context.Update(book);
                        //    _context.SaveChanges();
                        //}

                 
                       

                        OrderDetailModel orderDetail = new OrderDetailModel();
                        orderDetail.OrderID = donhang.OrderID;
                        orderDetail.BookID = item.BookID;
                        orderDetail.Quantity = item.Quantity;
                        orderDetail.PriceUnit = item.PriceUnit; //đơn giá chua giam?
                        orderDetail.Sale = item.Sale;
                        orderDetail.OrderdetailStatus = 0;
                        _context.Add(orderDetail);

                    }
                    _context.SaveChanges();

                    HttpContext.Session.Remove("GioHang");

                    _notifyService.Success("Đơn hàng đặt thành công");

                }

            }
            catch (Exception e)
            {
                return RedirectToAction("Index","Home");
            }
            ViewBag.GioHang = cart;
            return RedirectToAction("SuccessCheckOut", "Checkout");
        }

        public IActionResult SuccessCheckOut()
        {
            return View();
        }
    }
}
