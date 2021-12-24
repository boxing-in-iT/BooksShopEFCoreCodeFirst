using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.BLL.DTO.Product
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public int numberPages { get; set; }
        public int value { get; set; }
    }
}
