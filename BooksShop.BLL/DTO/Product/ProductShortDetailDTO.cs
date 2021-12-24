using BooksShop.BLL.DTO.Binding;
using BooksShop.BLL.DTO.Category;
using BooksShop.BLL.DTO.mainPhoto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.BLL.DTO.Product
{
    public class ProductShortDetailDTO
    {
        public int Id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public CategoryDTO category { get; set; }
        public int categoryId { get; set; }
        public BindingDTO binding { get; set; }
        public int bindingId { get; set; }
        public MainPhotoDTO mainPhoto { get; set; }
        public int mainPhotoId { get; set; }
    }
}
