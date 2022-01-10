using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_bansach.Models
{
    public class newsModel
    {
        public int NewsID { get; set; }
        public string NewsName { get; set; }

        public string NewsDay { get; set; }
        public string NewsMonthYear { get; set; }
        public string Img { get; set; }
        public string short_description { get; set; }
        public string Introduction { get; set; }
        public string Description { get; set; }
    }
}
