using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.BLL.DTO.Product
{
    public class ProductDTOForCreating
    {
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public int numberPages { get; set; }
        public string binding { get; set; }
        public int value { get; set; }
        public int categoryId { get; set; }
    }
}
