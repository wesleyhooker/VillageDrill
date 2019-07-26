using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace VillageDrill.Models.Objects
{
    public class PurchaseOrder
    {
        [Display(Name = "Purchase Order ID")]
        public int PurchaseOrderID { get; set; }
        [Display(Name = "Vendor ID")]
        public int VendorID { get; set; }
        [Required]
        [Display(Name = "Date Ordered")]
        public DateTime DateOrdered { get; set; }
        [Required]
        [Display(Name = "Vendor PO")]
        public string VendorPO { get; set; }
        [Display(Name = "Last Modified By")]
        public string LastModifiedBy { get; set; }
        [Display(Name = "Last Modified On")]
        public DateTime LastModifiedDate { get; set; }

        [ForeignKey("VendorID")]
        public virtual Vendor Vendor { get; set; }
    }
}
