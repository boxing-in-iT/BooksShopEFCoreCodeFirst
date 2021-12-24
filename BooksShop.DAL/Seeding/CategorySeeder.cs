using BooksShop.DAL.Entities;
using BooksShop.DAL.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Seeding
{
    public class CategorySeeder:ISeeder<Category>
    {
        private static readonly List<Category> categories = new List<Category>()
        {
            new Category
            {
                Id = 1,
                category = "Horror"
            },
            new Category
            {
                Id = 2,
                category = "Fantasy"
            },
            new Category
            {
                Id = 3,
                category = "Detective"
            }
        };

        public void Seed(EntityTypeBuilder<Category> builder) => builder.HasData(categories);

    }
}
