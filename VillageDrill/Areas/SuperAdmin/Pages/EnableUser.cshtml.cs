using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VillageDrill.Data;
using Microsoft.EntityFrameworkCore;
using VillageDrill.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using NToastNotify;
using VillageDrill.Models.Objects;

namespace VillageDrill.Areas.SuperAdmin.Pages
{
    [Authorize(Roles = SD.SuperAdminEndUser)]
    public class EnableUserModel : PageModel
    {
        public ApplicationUser myUser { get; set; }
        private readonly ApplicationDbContext _db;
        public readonly IToastNotification _toastNotification;

        public EnableUserModel(ApplicationDbContext db, IToastNotification toastNotification)
        {
            _db = db;
            _toastNotification = toastNotification;
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            myUser = await _db.ApplicationUser.FindAsync(id);
            myUser.LockoutEnd = null;
            _db.SaveChanges();
            _toastNotification.AddSuccessToastMessage("Account Activated");
            return RedirectToPage("./Users");
        }
    }
}