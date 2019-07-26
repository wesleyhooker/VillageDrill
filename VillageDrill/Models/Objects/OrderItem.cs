using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VillageDrill.Models.Objects
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }
        [Required]
        [Display(Name = "Vendor SKU")]
        public string VendorSKU { get; set; }

        [Required]
        //Decide between decimal or small money
        //[Column(TypeName = "smallmoney")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Quantity Ordered")]
        public int QuantityOrdered { get; set; }
        [Display(Name = "Date Delivered")]
        public DateTime DateDelivered { get; set; }
        [Display(Name = "Last Modified by")]
        public string LastModifiedBy { get; set; }
        [Display(Name = "Last Modified on")]
        public DateTime LastModifiedDate { get; set; }


        //Foreign Keys
        [Display(Name = "Item (Part)")]
        public int ItemID { get; set; }

        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; }

        [Display(Name = "Purchase Order")]
        public int PurchaseOrderID { get; set; }

        [ForeignKey("PurchaseOrderID")]
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
