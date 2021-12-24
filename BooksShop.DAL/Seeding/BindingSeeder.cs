using BooksShop.DAL.Entities;
using BooksShop.DAL.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Seeding
{
    public class BindingSeeder:ISeeder<Binding>
    {
        private static readonly List<Binding> bindings = new List<Binding>()
        {
            new Binding
            {
                Id = 1,
                bindingType = "Hard"
             },
            new Binding
            {
                Id=2,
                bindingType = "Soft"
            }
        };

        public void Seed(EntityTypeBuilder<Binding> builder) => builder.HasData(bindings);
    }
}
