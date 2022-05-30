using System;
using System.Collections.Generic;

namespace RockMuseumUI.Models
{
    internal class AspNetUserManager
    {
        internal static AspNetUserManager GetManager()
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal User CreateUser(string username, string password, string mail, string secretQuestion, string secretAnswer, bool isApproved, object p, out System.Web.Security.MembershipCreateStatus status)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<object> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}