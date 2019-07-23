using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VillageDrill.Models
{
    public class AssemblyRecipe
    {
        [Key]
        public int AssemblyRecipeID { get; set; }

        //Foreign Key
        [Display(Name = "Item")]
        public int ItemID { get; set; }

        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; }
    }
}
