using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace web_bansach.Areas.Admin.Models
{
    public class DistrictModel
    {
        [Key]
        [Display(Name = "Mã Quận/Huyện")]
        public int DistrictID { get; set; }

        [Display(Name = " Tên Quận/Huyện")]
        public string DistrictName { get; set; }

        [Display(Name = "Mã Tỉnh/Thành phố")]
        public int ProvinceID { get; set; }
        [ForeignKey("ProvinceID")]
        public ProvinceModel province { get; set; }

        //public ICollection<OrderModel> Orders { get; set; }
    }
}
