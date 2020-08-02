using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace task.Models
{
    public class StoreModel
    {
        [Key]
        public int id { get; set; }
        public string  storeName { set; get; }
    }
}