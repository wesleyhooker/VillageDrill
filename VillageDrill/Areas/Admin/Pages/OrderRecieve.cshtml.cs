using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VillageDrill.Models.Objects;
using VillageDrill.Models.Repositories;

namespace VillageDrill.Areas.Admin.Pages
{
    public class OrderRecieveModel : PageModel
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public OrderRecieveModel(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public Vendor Vendor { get; set; }

        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vendor = await _repositoryWrapper.Vendor.FindByCondition(m => m.VendorID == id).ToAsyncEnumerable().FirstOrDefault();

            if (Vendor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}