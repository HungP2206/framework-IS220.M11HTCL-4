using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using web_bansach.Areas.Admin.Models;

namespace web_bansach.Areas.Admin.Models

{
    public class BookModel
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Mã sách")]
        public int BookID { get; set; }

        [Display(Name = "Tên sách")]
        public string BookName { get; set; }

        [Display(Name = "Nhà sản xuất")]
        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public ProducerModel producer { get; set; }

        [Display(Name = "Thể loại sách")]
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public CategoryModel category { get; set; }

        [Display(Name = "Mã tác giả")]
        public int AuthorID { get; set; }
        [ForeignKey("AuthorID")]
        public AuthorModel author { get; set; }

        [Display(Name = "Giới thiệu")]
        public string Introduction { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [Display(Name = "Khuyến mãi")]
        public double Sale { get; set; }

        [Display(Name = "Đơn giá")]
        public double PriceUnit { get; set; }

        //[Display(Name = "Giá sau giảm")]
        //public double PriceSale { get; set; }

        public BookModel()
        {
            Created_at = DateTime.Now;
        }
        [Display(Name = "Ngày tạo")]
        public DateTime Created_at { get; set; }

        [Display(Name = "Ảnh của sách")]
        public string Img { get; set; }


        [Display(Name = "Số lượng sách còn")]
        public int Quantity { get; set; }

        //[Display(Name = "Số lượng sách đã bán")]
        public int Quantity_buy { get; set; }


        [Display(Name = "Trạng thái của sách")]
        public int BookStatus { get; set; }


        public virtual ICollection<OrderDetailModel> Orderdetails { get; set; }

    }
}
