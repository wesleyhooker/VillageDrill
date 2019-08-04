using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace VillageDrill.Models.Objects
{
    public class Vendor
    {
        [Key]
        public int VendorID { get; set; }

        [Required(ErrorMessage = "A Vendor Name is required")]
        [DisplayName("Name")]
        public string VendorName { get; set; }

        [Required(ErrorMessage = "A Vendor Address is required")]
        [DisplayName("Address")]
        public string VendorAddress { get; set; }

        [DisplayName("Last Modified by")]
        public string LastModifiedBy { get; set; }

        [DisplayName("Last Modified on")]
        public DateTime LastModifiedDate { get; set; }

        [ForeignKey("PurchaseOrderID")]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
