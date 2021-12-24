using BooksShop.DAL.Configurations;
using BooksShop.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL
{
    public class AppDbContext: IdentityDbContext<User>
    {
       

        
        public DbSet<Category> Categories { get; set; }
        public DbSet<MainPhoto> MainPhotos { get; set; }
        public DbSet<Binding> Bindings { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new MainPhotoConfiguration());
            modelBuilder.ApplyConfiguration(new BindingConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
