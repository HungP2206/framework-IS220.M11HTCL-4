using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_bansach.ModelView
{
    public class RegisterViewModel
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ tên của bạn")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên tài khoản")]
        [Remote(action: "ValidateUsername", controller: "Accounts")]
        public string UserName { get; set; }

        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [MinLength(8, ErrorMessage = "Bạn cần đặt mật khẩu tối thiểu 8 ký tự")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Vui lòng nhập lại mật khẩu")]
        [MinLength(8,ErrorMessage ="Bạn cần đặt mật khẩu tối thiểu 8 ký tự")]
        [Compare("Password", ErrorMessage ="Vui lòng nhập mật khẩu giống nhau")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Email")]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "ValidateEmail", controller: "Accounts")]
        public string Email { get; set; }

        [MaxLength(11)]
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [Remote(action: "ValidatePhone", controller: "Accounts")]
        public string PhoneNumber { get; set; }


        public int Role { get; set; }

    }
}
