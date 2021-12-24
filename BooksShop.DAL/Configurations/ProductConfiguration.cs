using BooksShop.DAL.Entities;
using BooksShop.DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Configurations
{
    public class ProductConfiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(product => product.Id)
                   .UseIdentityColumn()
                   .IsRequired();

            builder.Property(product => product.name)
                   .HasMaxLength(75)
                   .IsRequired();

            builder.Property(product => product.description)
                   .HasMaxLength(1000);

            builder.Property(product => product.price)
                   .HasMaxLength(6)
                   .IsRequired();

            builder.Property(product => product.numberPages)
                   .HasMaxLength(7)
                   .IsRequired();

            builder.Property(product => product.value)
                   .HasMaxLength(5)
                   .IsRequired();

            builder.HasOne(product => product.category)
                    .WithMany(category => category.products)
                    .HasForeignKey(product => product.categoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Products_categoryId");

            builder.HasOne(product => product.mainPhoto)
                    .WithMany(mainp => mainp.product)
                    .HasForeignKey(product => product.mainPhotoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Products_mainPhotoId");

            builder.HasOne(product => product.binding)
                    .WithMany(binding => binding.products)
                    .HasForeignKey(product => product.bindingId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Products_bindingId");

            new ProductSeeder().Seed(builder);
        }
    }
}
