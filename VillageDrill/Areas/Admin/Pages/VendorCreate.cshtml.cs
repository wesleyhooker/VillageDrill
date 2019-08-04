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
    public class VendorCreateModel : PageModel
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public VendorCreateModel(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        [BindProperty]
        public Vendor Vendor { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _repositoryWrapper.Vendor.Create(Vendor);
            _repositoryWrapper.Save();

            return RedirectToPage("./Vendor");
        }

    }
}