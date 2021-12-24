using BooksShop.DAL.Entities;
using BooksShop.DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Configurations
{
    public class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);

            builder.Property(user => user.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(user => user.LastName)
                .HasMaxLength(50)
                .IsRequired();

            new UserSeeder().Seed(builder);
        }
    }
}
