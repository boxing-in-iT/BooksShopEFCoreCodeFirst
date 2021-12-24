using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string category { get; set; }
        public List<Product> products { get; set; }
    }
}
