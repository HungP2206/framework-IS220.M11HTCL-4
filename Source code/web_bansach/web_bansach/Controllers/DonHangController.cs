using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_bansach.Areas.Admin.Data;
using web_bansach.Models;

namespace web_bansach.Controllers
{
    public class DonHangController : Controller
    {
        private readonly BookStoreContext _context;
        public DonHangController(BookStoreContext context)
        {
            _context = context;
        }
        //[HttpPost]
        //public async Task<IActionResult> Deatails(int? id)
        //{
        //    if(id == null) {
        //        return NotFound();
        //    }
        //    try
        //    {
        //        var taikhoanID = HttpContext.Session.GetString("CustomerID");
        //        if (string.IsNullOrEmpty(taikhoanID)) 
        //            return RedirectToAction("Login", "Accounts");
        //        var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerID == Convert.ToInt32(taikhoanID));
        //        if (khachhang == null) 
        //            return NotFound();
        //        var donhang = await _context.DbOrders
        //            .Include(x => x.OrderStatus)
        //            .FirstOrDefaultAsync(m => m.OrderID == id && Convert.ToInt32(taikhoanID) == m.CustomerID);
        //        if (donhang == null)
        //            return NotFound();

        //        var chitietdonhang = _context.Orderdetails
        //            .Include(x => x.Book)
        //            .AsNoTracking()
        //            .Where(x => x.OrderID == id)
        //            .OrderBy(x => x.OrderdetailID)
        //            .ToList();
        //        XemDonHang donHang = new XemDonHang();
        //        donHang.DonHang = donHang;
        //        donHang.ChiTietDonHang = chitietdonhang;
        //        return PartialView("Details", donHang);

        //    }
        //    catch(Exception e)
        //    {
        //        return NotFound();
        //    }
        //}
    }
}
