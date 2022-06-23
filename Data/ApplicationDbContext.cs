using Final_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Final_Project.Models.ViewModels;

namespace Final_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserBookHall>().HasKey(UH => new { UH.RequiredDay, UH.HallId });
        }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<HallImage> hallImages { get; set; }

        public DbSet<UserBookHall> UserBookHalls { get; set; }

        public DbSet<HallPackages> HallPackages { get; set; }

        public DbSet<Final_Project.Models.ViewModels.PackageVM> PackageVM { get; set; }
    }
}
