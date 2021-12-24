using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string path { get; set; }
        public List<Product> product { get; set; }
    }
}
