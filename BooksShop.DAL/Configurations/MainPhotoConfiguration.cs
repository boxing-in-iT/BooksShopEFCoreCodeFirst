using BooksShop.DAL.Entities;
using BooksShop.DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Configurations
{
    public class MainPhotoConfiguration : IEntityTypeConfiguration<MainPhoto>
    {
        public void Configure(EntityTypeBuilder<MainPhoto> builder)
        {
            builder.Property(mp => mp.Id)
                   .UseIdentityColumn()
                   .IsRequired();
            builder.Property(mp => mp.path)
                   .IsRequired();

            new MainPhotoSeeder().Seed(builder);
        }
    }
}
