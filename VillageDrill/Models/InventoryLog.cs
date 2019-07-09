using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VillageDrill.Models
{
    public class InventoryLog
    {
        [Key]
        public int LogID { get; set; }

        public int ItemID { get; set; }

        public int PreviousQty { get; set; }

        public int NewQty { get; set; }

        public bool Reconciled { get; set; }
        
        public string LastModifiedBy { get; set; }

        public DateTimeOffset LastModifieDate { get; set; }

    }
}
