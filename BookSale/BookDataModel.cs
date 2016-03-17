using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BookSale
{
    public class BookDataModel
    {
        [Key]
        public string BookID { get; set; }
        public string BookName { get; set; }
        public double BookPrice { get; set; }
    }

    public class BookOrderModel
    {
        [Key]
        public string BookID { get; set; }
        public int OrderAmt { get; set; }
    }
}
