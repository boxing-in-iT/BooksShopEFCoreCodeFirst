using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Repositories
{
    public interface ISeeder<T> where T : class
    {
        void Seed(EntityTypeBuilder<T> builder);
    }
}
