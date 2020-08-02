using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace task.Models
{
    public class Invoce
    {
        public Invoce()
        {
            this.InvoceItems = new HashSet<invoceItem>();
        }
            
        [Key]
        public int id { set; get; }
      
        public string Invoice_No { set; get; }
        public string Invoice_Date { set; get; }
        public string StorId { set; get; }
        public StoreModel Stor { set; get; }
        public string Total_total { set; get; }
        public string Taxes { set; get; }
        public string Total_Net { set; get; }
        public virtual ICollection<invoceItem>InvoceItems { set; get; }




    }


    public class invoceItem
    {
        public invoceItem()
        {
            this.Invoces = new HashSet<Invoce>();
        }
        [Key]
        public int Id { set; get; }
        public string ItemModelId { set; get; }
        public ItemModel ItemModel { set; get; }
        public string unitesModelId { set; get; }
        public unitesModel unitesModel { set; get; }
        public string price { set; get; }
        public string Qty { set; get; }
        public string totalOfItem { set; get; }
        public string Discount { set; get; }
        public string NetOfItem { set; get; }
       public virtual ICollection<Invoce>Invoces { set; get; }



    }

   

    public class unitesModel
    {
        [Key]
        public int id { set; get; }
        public string uniteName { set; get; }
    }
}