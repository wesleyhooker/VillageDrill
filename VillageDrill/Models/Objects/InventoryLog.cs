using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VillageDrill.Models.Objects
{
    public class InventoryLog
    {
        [Key]
        public int LogID { get; set; }
        [Required]
        [DisplayName("Previous Quantity")]
        public int PreviousQty { get; set; }
        [Required]
        [DisplayName("New Quantity")]
        public int NewQty { get; set; }
        [Required]
        public bool Reconciled { get; set; }
        [DisplayName("Last Modified by")]
        public string LastModifiedBy { get; set; }
        [DisplayName("Last Modified on")]
        public DateTime LastModifiedDate { get; set; }


        //Foreign Key
        [Display(Name = "Item")]
        public int ItemID { get; set; }

        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; }
    }
}
