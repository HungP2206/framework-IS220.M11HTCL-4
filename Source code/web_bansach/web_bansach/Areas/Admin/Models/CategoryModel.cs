using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using web_bansach.Areas.Admin.Data;

namespace web_bansach.Areas.Admin.Models
{
    public class CategoryModel
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Display(Name = "Mã thể loại sách")]
        [Key]
        public int CategoryID { get; set; }

        [Display(Name = "Tên thể loại sách")]
        public string CategoryName { get; set; }

        public CategoryModel()
        {
            Created_at = DateTime.Now;
        }
        public DateTime Created_at { get; set; }

        [Display(Name = "Trạng thái của thể loại")]
        public Byte CategoryStatus { get; set; }

        public ICollection<BookModel> Books { get; set; }


    }
}
