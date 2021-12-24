using BooksShop.DAL.Entities;
using BooksShop.DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Configurations
{
    public class BindingConfiguration : IEntityTypeConfiguration<Binding>
    {
        public void Configure(EntityTypeBuilder<Binding> builder)
        {
            builder.Property(binding => binding.Id)
                   .UseIdentityColumn()
                   .IsRequired();
            builder.Property(binding => binding.bindingType)
                   .IsRequired();

            new BindingSeeder().Seed(builder);
        }
    }
}
