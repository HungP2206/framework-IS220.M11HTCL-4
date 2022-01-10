using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using web_bansach.Models;

namespace web_bansach.Areas.Admin.Models
{
    public  class OrderModel
    {
        // //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // [Key]
        // [Display(Name = "Mã hoá đơn")]
        // public int OrderID { get; set; }

        // [Display(Name = "Mã khách hàng")]
        // public int CustomerID { get; set; }
        // [ForeignKey("CustomerID")]
        // //public CustomerModel Customers { get; set; }

        // [Display(Name = "Tên khách hàng")]
        // public string CustomerName { get; set; }
        // [ForeignKey("CustomerName")]
        // //public CustomerModel Customerss { get; set; }

        // [Display(Name = "Giá vận chuyển")]
        // public double PriceShip { get; set; }

        // [Display(Name = "Địa chỉ vận chuyển")]
        // public string Address { get; set; }
        // [ForeignKey("Address")]
        // //public CustomerModel customer { get; set; }

        // [Display(Name = "Tỉnh/Thành phố vận chuyển")]
        // public int ProvinceID { get; set; }
        // [ForeignKey("ProvinceID")]
        // public ProvinceModel province { get; set; }

        // [Display(Name = "Quận/Huyện vận chuyển")]
        // public int DistrictID { get; set; }
        // [ForeignKey("DistrictID")]
        // public DistrictModel district { get; set; }

        // public OrderModel()
        // {
        //     Created_at = DateTime.Now;
        // }
        // [Display(Name = "Ngày tạo")]
        // public DateTime Created_at { get; set; }


        // [Display(Name = "Trạng thái của hóa đơn")]
        // public int OrderStatus { get; set; }

        ////public virtual ICollection<OrderDetailModel> OrderDetails { get; set; }
        //public virtual ICollection<OrderDetailModel> Orderdetails { get; set; }


        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        //public OrderModel()
        //{
        //    Orderdetail = new HashSet<OrderDetailModel>();
        //}

        public int? CustomerID { get; set; }
        public string CustomerName { get; set; }
        public double? Total { get; set; }
        public string Address { get; set; }
        //public int? ProvinceID { get; set; }
        //public int? DistrictID { get; set; }
        public int? OrderStatus { get; set; }
        public DateTime? Created_at { get; set; }
        public virtual CustomerModel Customer { get; set; }
        //public virtual District District { get; set; }
        //public virtual Province Province { get; set; }
        public virtual ICollection<OrderDetailModel> Orderdetails { get; set; }
    }
}