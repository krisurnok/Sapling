using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;
using System;

namespace Sapling.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser<Guid, ApplicationLogin, ApplicationUserRole, ApplicationClaim>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser,Guid> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationRole : IdentityRole<Guid, ApplicationUserRole>
    {
    }
    public class ApplicationUserRole : IdentityUserRole<Guid>
    {
    }
    public class ApplicationLogin : IdentityUserLogin<Guid>
    {
    }
    public class ApplicationClaim : IdentityUserClaim<Guid>
    {
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid, ApplicationLogin, ApplicationUserRole, ApplicationClaim>
    {
        public ApplicationDbContext()
            : base("SaplingIdentity")
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Mapping to our tables inside the database
            modelBuilder.Entity<ApplicationUser>().ToTable("User");
            modelBuilder.Entity<ApplicationRole>().ToTable("Role");
            modelBuilder.Entity<ApplicationClaim>().ToTable("UserClaim");
            modelBuilder.Entity<ApplicationLogin>().ToTable("UserLogin");
            modelBuilder.Entity<ApplicationUserRole>().ToTable("UserRole");

            //Mapping ApplicationUser Table to User Defined Table

            modelBuilder.Entity<ApplicationUser>().Property(r => r.PasswordHash).HasColumnName("Password");
            modelBuilder.Entity<ApplicationUser>().Property(r => r.PhoneNumber).HasColumnName("Mobile");

        }
    }
}