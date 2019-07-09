using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VillageDrill.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        [Display(Name = "Item (Part)")]
        public int ItemID { get; set; }

        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; }


        public int PurchaseOrderID {get; set;}

        [ForeignKey("PurchaseOrderID")]
        public virtual PurchaseOrder PurchaseOrder { get; set; }

        public string VendorSKU { get; set; }

        public double Price { get; set; }

        public int QuantityOrdered { get; set; }

        public DateTimeOffset DateDelivered { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }
 
    }
}
