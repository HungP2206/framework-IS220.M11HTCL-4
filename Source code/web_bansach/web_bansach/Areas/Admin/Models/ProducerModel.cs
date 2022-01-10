using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace web_bansach.Areas.Admin.Models
{
    public class ProducerModel
    {
        [Display(Name = "Mã nhà sản xuất")]
        [Key]
        public int ProducerID { get; set; }

        [Display(Name = "Tên nhà sản xuất")]
        public string ProducerName { get; set; }

        public ProducerModel()
        {
            Created_at = DateTime.Now;
        }
        [Display(Name = "Ngày tạo")]
        public DateTime Created_at { get; set; }


        [Display(Name = "Trạng thái của nhà sản xuất")]
        public int ProducerStatus { get; set; }

        public ICollection<BookModel> Books { get; set; }
    }
}
