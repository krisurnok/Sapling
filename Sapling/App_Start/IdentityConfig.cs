﻿using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Sapling.Models;
using System;

namespace Sapling
{
    // Configure the application user manager used in this application. UserManager is defined in ASP.NET Identity and is used by the application.
    //UserManager<ApplicationUser>
    public class ApplicationUserManager : UserManager<ApplicationUser,Guid>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser,Guid> store)
            : base(store)
        {
        }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            var manager = new ApplicationUserManager(new UserStore<ApplicationUser,ApplicationRole, Guid, ApplicationLogin, ApplicationUserRole, ApplicationClaim>(context.Get<ApplicationDbContext>()));
            // Configure validation logic for usernames
            manager.UserValidator = new UserValidator<ApplicationUser,Guid>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };
            // Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = true,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
            };
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = new DataProtectorTokenProvider<ApplicationUser,Guid>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }
    }
}
