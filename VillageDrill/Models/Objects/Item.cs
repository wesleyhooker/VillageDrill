using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VillageDrill.Models.Objects
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        [Required(ErrorMessage = "An Item Name is required")]
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
        [Required(ErrorMessage = "A Description is required")]
        public string Description { get; set; }
        [Required]
        [DisplayName("On Hand Quantity")]
        public int OnHandQty { get; set; }
        [Required]
        [DisplayName("Retail Cost")]

        //Decide between decimal or small money
        //[Column(TypeName = "smallmoney")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ListRetailCost { get; set; }

        [Required]
        [DisplayName("Reorder Quantity")]
        public int ReorderQty { get; set; }
        [Required]
        [DisplayName("Max Quantity")]
        public int MaxQty { get; set; }
        [Required]
        [DisplayName("Measure Ammount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MeasureAmnt { get; set; }
        [DisplayName("Last Modified by")]
        public string LastModifiedBy { get; set; }
        [DisplayName("Last Modified on")]
        public DateTime LastModifiedDate { get; set; }


        //Foreign Key
        [Display(Name = "Measure")]
        public int MeasureID { get; set; }

        [ForeignKey("MeasureID")]
        public virtual Measures Measures { get; set; }
    }
}
