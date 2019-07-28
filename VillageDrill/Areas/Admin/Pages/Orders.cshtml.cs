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
    public class OrdersModel : PageModel
    {
        private IRepositoryWrapper _repositoryWrapper;
        public List<Vendor> Vendors { get; set; }

        public OrdersModel(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task OnGet()
        {
            var vendors = _repositoryWrapper.Vendor.FindAll();
            Vendors = await vendors.ToListAsync();
        }
    }
}