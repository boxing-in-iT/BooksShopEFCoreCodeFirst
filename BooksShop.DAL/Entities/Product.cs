using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public int numberPages { get; set; }
        public int value { get; set; }

        public int bindingId { get; set; }
        public Binding binding { get; set; }

        public int categoryId { get; set; }
        public Category category { get; set; }

        public int mainPhotoId { get; set; }
        public MainPhoto mainPhoto { get; set; }
    }
}
