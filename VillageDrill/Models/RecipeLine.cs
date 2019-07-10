using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VillageDrill.Models
{
    public class RecipeLine
    {
        [Key]
        public int RecipeLineID { get; set; }
        [DisplayName("Required Item Quantity")]
        [Required]
        public int RequiredItemQuantity { get; set; }
        [DisplayName("Last Modified by")]
        public string LastModifiedBy { get; set; }
        [DisplayName("Last Modified on")]
        public DateTime LastModifiedDate { get; set; }


        //Foreign Key
        [Display(Name = "Item (Part)")]
        public int ItemID { get; set; }

        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; }

        [Display(Name = "Assembly Recipe")]
        public int AssemblyRecipeID { get; set; }

        [ForeignKey("AssemblyRecipeID")]
        public virtual AssemblyRecipe AssemblyRecipe { get; set; }
    }
}
