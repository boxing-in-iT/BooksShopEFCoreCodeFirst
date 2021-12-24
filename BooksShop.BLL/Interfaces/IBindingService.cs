using BooksShop.BLL.DTO.Binding;
using BooksShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.BLL.Interfaces
{
    public interface IBindingService
    {
        public Task<IEnumerable<BindingDTO>> Get();
        public Task<BindingDTO> GetById(int id);
    }
}
