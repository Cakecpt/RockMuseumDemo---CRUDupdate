using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace RockMuseumUI.Models
{
   
    public class ModifyUser
    {
        public partial class ManagingUsers
        {
            public static void ModifyUser(string username, string newEmail)
            {
                AspNetUserManager userManager = AspNetUserManager.GetManager();
                UserProfileManager profileManager = UserProfileManager.GetManager();

                User user = userManager.GetUsers().Where(u => u.UserName == username).SingleOrDefault();

                if (user != null)
                {
                    user.Email = newEmail;

                    userManager.SaveChanges();
                }
            }
        }
    }
}
