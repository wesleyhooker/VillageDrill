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
        public List<PurchaseOrder> Orders { get; set; }

        public OrdersModel(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task OnGet()
        {
            var orders = _repositoryWrapper.PurchaseOrder.FindAll();
            Orders = await orders.ToListAsync();
        }
    }
}