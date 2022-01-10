using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Dynamic;
using web_bansach.Areas.Admin.Data;
using web_bansach.Areas.Admin.Models;
using web_bansach.Models;
//using System.ComponentModel.DataAnnotations;

namespace web_bansach.Areas.Admin.Models
{
    public class UserModel
    {
        [Key]
        [Display(Name = "Mã user")]
        public int UserID { get; set; }


        [Required(ErrorMessage ="Tên tài khoản không được bỏ trống")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được bỏ trống")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Hãy nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }


        [Display(Name = "Tên nhân viên")]
        public string EmployeeName { get; set; }

        [Display(Name = "Email user")]
        public string Email { get; set; }

        [Display(Name = "SĐT user")]
        public string Phone { get; set; }

        [Display(Name = "Giới tính user")]
        public Byte Gender { get; set; }

        public int Role { get; set; }

        public UserModel()
        {
            Created_at = DateTime.Now;
        }
        public DateTime Created_at { get; set; }

        public string Address { get; set; }

        [Display(Name = "Trạng thái của user")]
        public Byte UserStatus { get; set; }
    }
}
