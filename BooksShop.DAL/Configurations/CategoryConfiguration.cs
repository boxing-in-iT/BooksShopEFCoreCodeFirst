using BooksShop.DAL.Entities;
using BooksShop.DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(category => category.Id)
                   .UseIdentityColumn()
                   .IsRequired();
            builder.Property(category => category.category)
                   .IsRequired();

            new CategorySeeder().Seed(builder);
        }
    }
}
