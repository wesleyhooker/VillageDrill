using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel;

namespace VillageDrill.Models
{
    public class Vendor
    {
        [Key]
        public int VendorID { get; set; }
        [Required(ErrorMessage = "A Vendor Name is required")]
        [DisplayName("Vendor Name")]
        public string VendorName { get; set; }
        [DisplayName("Vendor Address")]
        public string VendorAddress { get; set; }
        [DisplayName("Last Modified by")]
        public string LastModifiedBy { get; set; }
        [DisplayName("Last Modified on")]
        public DateTime LastModifiedDate { get; set; }
    }
}
