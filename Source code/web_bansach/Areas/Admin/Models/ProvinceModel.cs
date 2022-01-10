using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace web_bansach.Areas.Admin.Models
{
    public class ProvinceModel
    {
        [Key]
        [Display(Name = "Mã Tỉnh/Thành phố")]
        public int ProvinceID { get; set; }

        [Display(Name = " Tên Tỉnh/Thành phố")]
        public string ProvinceName { get; set; }

        public ICollection<DistrictModel> Districts { get; set; }
        //public ICollection<OrderModel> Orders { get; set; }
    }
}
