using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;


namespace web_bansach.Areas.Admin.Models
{
    public class AuthorModel
    {
        [Key]
        [Display(Name = "Mã tác giả")]
        public int AuthorID { get; set; }

        [Display(Name = "Tên tác giả")]
        public string AuthorName { get; set; }

        [Display(Name = "Email tác giả")]
        public string Email { get; set; }

        [Display(Name = "SĐT tác giả")]
        public string Phone { get; set; }

        [Display(Name = "Giới tính tác giả")]
        public Byte Gender { get; set; }

        public AuthorModel()
        {
            Created_at = DateTime.Now;
        }
        [Display(Name = "Ngày tạo")]
        
        public DateTime Created_at { get; set; }

       
        [Display(Name = "Trạng thái của tác giả")]
        public Byte AuthorStatus { get; set; }


        public ICollection<BookModel> Books { get; set; }
    }
}
