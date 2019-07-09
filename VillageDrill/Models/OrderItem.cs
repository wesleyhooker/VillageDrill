using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VillageDrill.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        public int ItemID { get; set; }

        public int PurchaseOrderID {get; set;}

        public string VendorSKU { get; set; }

        public double Price { get; set; }

        public int QuantityOrdered { get; set; }

        public DateTimeOffset DateDelivered { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }
 
    }
}
