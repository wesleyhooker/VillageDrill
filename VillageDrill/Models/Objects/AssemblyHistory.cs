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
    public class AssemblyHistory
    {
        [Display(Name = "History ID")]
        public int AssemblyHistoryID { get; set; }

        [Display(Name = "Item ID")]
        public int ItemID { get; set; }

        [Required]
        [Display(Name = "Date Assembled")]
        public DateTime AssemblyDate { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int QtyAssembled { get; set; }

        [Display(Name = "Additional Notes")]
        public string Notes { get; set; }

        [Display(Name = "Modified By")]
        public string LastModifiedBy { get; set; }

        [Display(Name = "Modified On")]
        public DateTime LastModifiedDate { get; set; }

        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; }
    }
}
