using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VillageDrill.Data;
using VillageDrill.Models;
using Microsoft.EntityFrameworkCore;
using VillageDrill.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace VillageDrill.Areas.SuperAdmin.Pages
{
    [Authorize(Roles = SD.SuperAdminEndUser)]
    public class UsersModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public UsersModel(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        /// <summary>
        /// Summarized data of a User 
        /// </summary>
        public struct User
        {
            public string ID;
            public string UserName;
            public string PhoneNumber;
            public string Role;
            public bool LockedOut;
        }

        /// <summary>
        /// List of all Application Users with their roles
        /// </summary>
        public List<User> Users = new List<User>();

        public async Task OnGetAsync()
        {
            var superAdminUsers = await _userManager.GetUsersInRoleAsync("Super Admin");
            var AdminUsers = await _userManager.GetUsersInRoleAsync("Admin");
            var StandardUsers = await _userManager.GetUsersInRoleAsync("Standard User");

            //Adds super admins to the Users list
            for(int i = 0; i < superAdminUsers.Count(); i++)
            {
                User myUser;
                myUser.ID = superAdminUsers[i].Id;
                myUser.UserName = superAdminUsers[i].UserName;
                myUser.PhoneNumber = superAdminUsers[i].PhoneNumber;
                myUser.Role = "Super Admin";

                if(superAdminUsers[i].LockoutEnd >= DateTime.Now)
                {
                    myUser.LockedOut = true;
                }
                else {
                    myUser.LockedOut = false;
                }

                Users.Add(myUser);
            }

            //Adds Admins to the Users List
            for (int i = 0; i < AdminUsers.Count(); i++)
            {
                User myUser;
                myUser.ID = AdminUsers[i].Id;
                myUser.UserName = AdminUsers[i].UserName;
                myUser.PhoneNumber = AdminUsers[i].PhoneNumber;
                myUser.Role = "Admin";

                if (AdminUsers[i].LockoutEnd >= DateTime.Now)
                {
                    myUser.LockedOut = true;
                }
                else
                {
                    myUser.LockedOut = false;
                }

                Users.Add(myUser);
            }

            //Adds Standard Users to the Users List
            for (int i = 0; i < StandardUsers.Count(); i++)
            {
                User myUser;
                myUser.ID = StandardUsers[i].Id;
                myUser.UserName = StandardUsers[i].UserName;
                myUser.PhoneNumber = StandardUsers[i].PhoneNumber;
                myUser.Role = "Standard User";

                if (StandardUsers[i].LockoutEnd >= DateTime.Now)
                {
                    myUser.LockedOut = true;
                }
                else
                {
                    myUser.LockedOut = false;
                }

                Users.Add(myUser);
            }

        }

        public void OnPost(string id)
        {

        }
    }
}