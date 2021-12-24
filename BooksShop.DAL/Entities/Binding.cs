using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Entities
{
    public class Binding
    {
        public int Id { get; set; }
        public string bindingType { get; set; }
        public List<Product> products { get; set; }
    }
}
