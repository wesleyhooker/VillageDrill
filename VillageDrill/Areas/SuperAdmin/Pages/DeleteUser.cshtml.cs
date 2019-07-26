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
    public class DeleteUserModel : PageModel
    {

        public ApplicationUser myUser { get; set; }
        private readonly ApplicationDbContext _db;
        public readonly IToastNotification _toastNotification;

        public DeleteUserModel(ApplicationDbContext db, IToastNotification toastNotification)
        {
            _db = db;
            _toastNotification = toastNotification;
        }

        public async Task OnGetAsync(string id)
        {
            myUser = await _db.ApplicationUser.FindAsync(id);
        }

        public IActionResult OnPostAsync(string id)
        {
            ApplicationUser selectedUser = _db.ApplicationUser.Where(u => u.Id == id).FirstOrDefault();
            selectedUser.LockoutEnd = DateTime.Now.AddYears(1000);

            _db.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Account Disabled Successfully");
            return RedirectToPage("./Users");
        }
    }
}