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
    public class AddAssemblyPartModel : PageModel
    {
        //Holds needed data to identify the selected part
        public struct SelectedPart
        {
            public bool isSelected;
            public int ItemId;
            public string ItemName;
            public int Qty;
        }

        private IRepositoryWrapper _repositoryWrapper;

        /// <summary>
        /// Holds the list of items from the database
        /// </summary>
        public List<Item> Items { get; set; }
        /// <summary>
        /// holds a selected item from the table
        /// </summary>
        public SelectedPart AssemblyPart;
        /// <summary>
        /// holds a list of selected items from the table
        /// </summary>
        public List<SelectedPart> SelectedParts;


        public AddAssemblyPartModel(IRepositoryWrapper repositoryWrapper)
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