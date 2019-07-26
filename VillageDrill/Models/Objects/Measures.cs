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
    public class Measures
    {
        [Key]
        public int MeasureID { get; set; }
        [Required]
        [Display(Name = "Measurement Name")]
        public string MeasureName { get; set; }
    }
}
