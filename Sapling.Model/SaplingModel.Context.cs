﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sapling.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class saplingEntities : DbContext
    {
        public saplingEntities()
            : base("name=saplingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<Maintance> Maintance { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Sapling> Sapling { get; set; }
        public virtual DbSet<Support> Support { get; set; }
        public virtual DbSet<Tree> Tree { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserClaim> UserClaim { get; set; }
        public virtual DbSet<UserLogin> UserLogin { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<SaplingImage> SaplingImage { get; set; }
    }
}
