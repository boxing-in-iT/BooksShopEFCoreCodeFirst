using AutoMapper;
using BooksShop.BLL.DTO.Category;
using BooksShop.BLL.Interfaces;
using BooksShop.DAL.Entities;
using BooksShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.BLL.Services
{
    public class CategoryService: ICategoryService
    {
        private IUnitOfWork _unit;
        private IMapper _mapper;

        public CategoryService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategoryList()
        {
            IEnumerable<Category> categories = await _unit.categoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categories);
        }
    }
}
