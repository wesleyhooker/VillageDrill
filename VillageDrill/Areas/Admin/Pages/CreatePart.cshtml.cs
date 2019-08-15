using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VillageDrill.Models;
using VillageDrill.Models.Objects;
using VillageDrill.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VillageDrill.Areas.Admin.Pages
{
    public class CreatePartModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        /// <summary>
        /// will hold the measurements stored in the database
        /// </summary>
        public List<SelectListItem> UnitMeasurementOptions { get; set; }
        public Item CreatedItem { get; set; }

        public CreatePartModel(ApplicationDbContext db)
        {
            _db = db;           
        }

        public void OnGet()
        {
            //fill the measurement selection dropdwon
            UnitMeasurementOptions = _db.Measures.Select(m =>
                                                    new SelectListItem
                                                    {
                                                        Value = m.MeasureID.ToString(),
                                                        Text = m.MeasureName
                                                    }).ToList();
            
        }
    }
}