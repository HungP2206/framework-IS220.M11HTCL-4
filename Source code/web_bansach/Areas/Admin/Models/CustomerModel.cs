using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace web_bansach.Areas.Admin.Models
{
    public class CustomerModel
    {
        [Display(Name = "Mã khách hàng")]
        [Key]
        public int CustomerID { get; set; }

        [Display(Name = "Tên khách hàng")]
        public string CustomerName { get; set; }

        [Display(Name = "Tên tài khoản khách hàng")]
        public string UserName { get; set; }

        [Display(Name = "Mật khẩu khách hàng")]
        public string Password { get; set; }

        [Display(Name = "Email khách hàng")]
        public string Email { get; set; }

        [Display(Name = "SĐT khách hàng")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Giới tính khách hàng")]
        public int Gender { get; set; }

        [Display(Name = "Địa chỉ khách hàng")]
        public string Address { get; set; }

  
        public CustomerModel()
        {
            Created_at = DateTime.Now;
        }
        [Display(Name = "Ngày tạo")]
        public DateTime Created_at { get; set; }

        [Display(Name = "Trạng thái của khách hàng")]
        public int CustomerStatus { get; set; }
        public int Role { get; set; }

        public string Salt { get; set; }

        public ICollection<OrderModel> Orders { get; set; }
    }
}
