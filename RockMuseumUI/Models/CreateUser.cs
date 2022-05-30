using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RockMuseumUI.Models
{
    public class CreateUser
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }

        internal CreateUser CreateProfile(User user, Guid guid, Type type)
        {
            throw new NotImplementedException();
        }

        internal void RecompileItemUrls(CreateUser uiProfile)
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

        public partial class ManagingUsers
        {
        private static object UserProfileManager;

        public static CreateUser CreateUser(string username, string password, string firstName, string lastName, string mail, string secretQuestion, string secretAnswer, bool isApproved)
        {
            AspNetUserManager userManager = AspNetUserManager.GetManager();
            CreateUser profileManager = UserProfileManager.GetManager();

            System.Web.Security.MembershipCreateStatus status;

            User user = userManager.CreateUser(username, password, mail, secretQuestion, secretAnswer, isApproved, null, out status);

            if (status == CreateUser.Success)
            {
                CreateUser uiProfile = profileManager.CreateProfile(user, Guid.NewGuid(), typeof(CreateUser)) as CreateUser;

                if (uiProfile != null)
                {
                    uiProfile.FirstName = firstName;
                    uiProfile.LastName = lastName;
                }

                userManager.SaveChanges();
                profileManager.RecompileItemUrls(uiProfile);
                profileManager.SaveChanges();

                return status;

            }
            return status;
        }
    }
    }
