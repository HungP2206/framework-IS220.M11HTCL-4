using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_bansach.ModelView
{
    public class LoginViewModel
    {
        [Key]

        [Required(ErrorMessage = "Vui lòng nhập tên tài khoản")]
        public string UserName { get; set; }

        [MinLength(8, ErrorMessage = "Mật khẩu tối thiểu 8 ký tự")]
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string Password { get; set; }
      
    }
}
