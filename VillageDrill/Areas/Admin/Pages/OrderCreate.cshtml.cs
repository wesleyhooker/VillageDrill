using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VillageDrill.Models.Objects;
using VillageDrill.Models.Repositories;

namespace VillageDrill.Areas.Admin.Pages
{
    public class OrderCreateModel : PageModel
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public OrderCreateModel(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public List<Vendor> Vendors { get; set; }

        public List<Vendor> Sorted { get; set; }

        public List<Item> Items { get; set; }

        [BindProperty]
        public PurchaseOrder PurchaseOrder { get; set; }

        public async Task OnGet()
        {
            var vendors = _repositoryWrapper.Vendor.FindAll();
            Vendors = await vendors.ToListAsync();
            Sorted = Vendors.OrderBy(x => x.VendorName).ToList();
            var items = _repositoryWrapper.Item.FindAll();
            Items = await items.ToListAsync();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _repositoryWrapper.PurchaseOrder.Create(PurchaseOrder);
            _repositoryWrapper.Save();

            return RedirectToPage("./Orders");
        }
    }
}