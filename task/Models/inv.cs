using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task.Models
{
    public class inv
    {

        public int id { set; get; }
        public string Invoice_No { set; get; }
        public string Invoice_Date { set; get; }
        public string Store { set; get; }
        public string Item { set; get; }
        public string Unit { set; get; }
        public string Price { set; get; }
        public string Qty { set; get; }
        public string Total { set; get; }
        public string Discount { set; get; }
        public string Net { set; get; }
        public string Total_All { set; get; }
        public string Taxes_All { set; get; }
        public string Net_All { set; get; }
    }
}