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
    public class InventoryModel : PageModel
    {
        private IRepositoryWrapper _repositoryWrapper;
        public List<Item> Items { get; set; }


        public InventoryModel(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task OnGet()
        {
            var items = _repositoryWrapper.Item.FindAll();
            Items = await items.ToListAsync();
        }
    }
}