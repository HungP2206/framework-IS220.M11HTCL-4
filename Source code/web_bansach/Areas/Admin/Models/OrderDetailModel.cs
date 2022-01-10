using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace web_bansach.Areas.Admin.Models
{
    public partial class OrderDetailModel
    {
        ////add 2 khóa ngoại
        //[Key]
        //[Display(Name = "Mã hoá đơn")]
        //public int OrderID { get; set; }
        ////[ForeignKey("OrderID")]
        ////public OrderModel order { get; set; }

        ////[Key]
        //[Display(Name = "Mã sách")]
        //public int BookID { get; set; }
        ////[ForeignKey("BookID")]
        ////public BookModel book { get; set; }

        //[Display(Name = "Đơn giá")]
        //public double Price { get; set; }

        //[Display(Name = "Khuyến mãi")]
        //public double Sale { get; set; }

        //[Display(Name = "Số lượng sách được đặt hàng")]
        //public int Quantity { get; set; }

        //[Display(Name = "Trạng thái của hóa đơn chi tiết")]
        //public int OrderdetailStatus { get; set; }

        //public OrderDetailModel()
        //{
        //    Created_at = DateTime.Now;
        //}
        //[Display(Name = "Ngày tạo")]
        //public DateTime Created_at { get; set; }

        //public virtual OrderModel Order { get; set; }

        //
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int OrderdetailID { get; set; }
        public int OrderID { get; set; }
        public int BookID { get; set; }
        public int? Quantity { get; set; }
        public double? PriceUnit { get; set; }
        public double? Sale { get; set; }

        public byte? OrderdetailStatus { get; set; }

        public virtual BookModel Book { get; set; }
        public virtual OrderModel Order { get; set; }
    }
}
