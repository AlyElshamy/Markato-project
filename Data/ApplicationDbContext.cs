using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Markatooo.Data
{
    public class ApplicationUser : IdentityUser
    {

        public int EntityId { get; set; }

        public int EntityName { get; set; }
        public string Photo { get; set; }
        public DateTime LastChangePassword { get; set; }

    }
    public class ApplicationDbContext : IdentityDbContext
    {
    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.EntityId);

            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.EntityName);
            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.Photo);
            modelBuilder.Entity<ApplicationUser>()
                .Property(e => e.LastChangePassword);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "Admin".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Customer", NormalizedName = "Customer".ToUpper() });


        }
    }
}
