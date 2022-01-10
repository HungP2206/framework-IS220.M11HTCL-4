using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_bansach.Models
{
    public class CartItem
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Img { get; set; }

        public double PriceUnit { get; set; }
        public double Sale { get; set; }
        public int Quantity { get; set; }
 
        public double PriceSale => (PriceUnit * (1 - Sale));
        public double TotalMoney => (PriceSale * Quantity);


    }
}
