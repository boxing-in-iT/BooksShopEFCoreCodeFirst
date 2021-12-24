using BooksShop.BLL.DTO.Category;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.BLL.Interfaces
{
    public interface ICategoryService
    {
        public Task<IEnumerable<CategoryDTO>> GetCategoryList();
    }
}
