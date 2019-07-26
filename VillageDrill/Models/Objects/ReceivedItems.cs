using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VillageDrill.Models.Objects
{
    public class ReceivedItems
    {
        [Key]
        public int RecievedID { get; set; }
        [DisplayName("Quantity Received")]
        [Required(ErrorMessage = "A Quantity Received is required")]
        public int QuantityReceived { get; set; }
        public string Notes { get; set; }
        [DisplayName("Last Modified by")]
        public string LastModifiedBy { get; set; }
        [DisplayName("Last Modified on")]
        public DateTime LastModifiedDate { get; set; }


        //Foreign Key
        [Display(Name = "Vendor")]
        public int VendorID { get; set; }

        [ForeignKey("VendorID")]
        public virtual Vendor Vendor { get; set; }
    }
}
