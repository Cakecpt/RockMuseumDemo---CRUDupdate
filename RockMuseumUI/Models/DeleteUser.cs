using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockMuseumUI.Models
{
    public class DeleteUser
    {
        public partial class ManagingUsersSnippets
        {
            public static void DeleteUser(string username)
            {
                UserManager userManager = UserManager.GetManager();
                UserProfileManager profileManager = UserProfileManager.GetManager();

                User user = userManager.GetUsers().Where(u => u.UserName == username).SingleOrDefault();

                if (user != null)
                {
                    UserProfileManager userProfile = profileManager.GetUserProfile<UserProfileManager>(user);

                    if (userProfile != null)
                    {
                        profileManager.Delete(userProfile);
                    }

                    userManager.Delete(user);
                }

                profileManager.SaveChanges();
                userManager.SaveChanges();
            }
        }
    }
}
