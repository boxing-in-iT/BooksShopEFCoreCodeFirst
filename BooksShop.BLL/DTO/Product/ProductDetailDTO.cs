using BooksShop.BLL.DTO.Binding;
using BooksShop.BLL.DTO.Category;
using BooksShop.BLL.DTO.mainPhoto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.BLL.DTO.Product
{
    public class ProductDetailDTO
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public int numberPages { get; set; }
        public int value { get; set; }

        public int categoryId { get; set; }
        public CategoryDTO category { get; set; }

        public BindingDTO binding { get; set; }
        public int bindingId { get; set; }
        public MainPhotoDTO mainPhoto { get; set; }
        public int mainPhotoId { get; set; }
    }
}
