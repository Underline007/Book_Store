using Book_Store.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Store.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<StoreOwner> StoreOwners { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedUser(builder);
            SeedRole(builder);
            SeedUserRole(builder);
        }

        private void SeedUser(ModelBuilder builder)
        {

            var admin = new IdentityUser
            {
                Id = "1",
                UserName = "Dung",
                Email = "dung@gmail.com",
                NormalizedUserName = "dung@gmail.com",
                EmailConfirmed = true
            };

            var storeOwner = new IdentityUser
            {
                Id = "2",
                UserName = "Truong",
                Email = "truong@gmail.com",
                NormalizedUserName = "truong@gmail.com",
                EmailConfirmed = true
            };
            var customer = new IdentityUser
            {
                Id = "3",
                UserName = "Dat",
                Email = "dat@gmail.com",
                NormalizedUserName = "dat@gmail.com",
                EmailConfirmed = true
            };





            var hasher = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = hasher.HashPassword(admin, "abc123");
            storeOwner.PasswordHash = hasher.HashPassword(storeOwner, "abc123");
            customer.PasswordHash = hasher.HashPassword(customer, "abc123");
            builder.Entity<IdentityUser>().HasData(admin, storeOwner, customer);
        }

        private void SeedRole(ModelBuilder builder)
        {
            var admin = new IdentityRole
            {
                Id = "A",
                Name = "Administrator",
                NormalizedName = "Administrator"
            };
            var storeOwner = new IdentityRole
            {
                Id = "S",
                Name = "storeOwner",
                NormalizedName = "storeOwner"
            };
            var customer = new IdentityRole
            {
                Id = "C",
                Name = "Customer",
                NormalizedName = "Customer"
            };
            builder.Entity<IdentityRole>().HasData(admin, storeOwner, customer);

        }
        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "A"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "S"
                },
                  new IdentityUserRole<string>
                  {
                      UserId = "3",
                      RoleId = "C"
                  }
             );
        }

    }
    
}
