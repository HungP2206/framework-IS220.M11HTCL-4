using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_bansach.Areas.Admin.Data;
using web_bansach.Helpers;
using web_bansach.Models;

namespace web_bansach.Controllers
{
    public class CartController : Controller
    {
        private readonly BookStoreContext _context;
        public CartController(BookStoreContext context)
        {
            _context = context;
        }

        public List<CartItem> Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (data == null)
                {
                    data = new List<CartItem>();
                }
                return data;
            }
        }

        public IActionResult Index()
        {
            return View(Carts);
        }

     
        public IActionResult CheckOut()
        {
            return View();
        }


        [HttpPost]
        [Route("api/cart/add")]
        public IActionResult AddToCart(int BookID, string BookName, double PriceUnit, int Quantity, double Sale, string Img)
        {
            var myCart = Carts;
            var item = myCart.SingleOrDefault(p => p.BookID == BookID);

            if (item == null)//chưa có
            {
                //var book = _context.Books.SingleOrDefault(p => p.BookID == BookID);
                item = new CartItem
                {
                    BookID = BookID,
                    BookName = BookName,
                    PriceUnit = PriceUnit,
                    Quantity = Quantity,
                    Sale = Sale,
                    Img = Img,

                };
                myCart.Add(item);
            }
            else
            {
                item.Quantity++;
            }
            HttpContext.Session.Set("GioHang", myCart);

            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int BookID, int? Quantity)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            try
            {
                if(cart != null)
                {
                    CartItem item = cart.SingleOrDefault(b => b.BookID == BookID);
                    if(item != null && Quantity.HasValue)
                    {
                        item.Quantity = Quantity.Value;
                    }
                    HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
                }
                return Json(new { success = true });
            }
            catch { return Json(new { success = false }); }
        }



        [HttpPost]
        [Route("api/cart/remove")]
        public ActionResult RemoveItemCart(int BookID)
        {
            try
            {
                List<CartItem> giohang = Carts;
                CartItem item = giohang.SingleOrDefault(p => p.BookID == BookID);
                if (item != null)
                {
                    giohang.Remove(item);
                }

                HttpContext.Session.Set<List<CartItem>>("GioHang", giohang);
                return Json(new { success = true });
            }
            catch { return Json(new { success = false }); }
        }
    }
}
