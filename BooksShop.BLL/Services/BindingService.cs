using AutoMapper;
using BooksShop.BLL.DTO.Binding;
using BooksShop.BLL.Interfaces;
using BooksShop.DAL.Entities;
using BooksShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.BLL.Services
{
    public class BindingService:IBindingService
    {
        private IUnitOfWork _unit;
        private IMapper _mapper;

        public BindingService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BindingDTO>> Get()
        {
            IEnumerable<Binding> bindings = await _unit.bindingRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<BindingDTO>>(bindings);
        }

        public async Task<BindingDTO> GetById(int id)
        {
            Binding binding = await _unit.bindingRepository.GetByIdAsync(id);
            return _mapper.Map<BindingDTO>(binding);
        }
    }
}
