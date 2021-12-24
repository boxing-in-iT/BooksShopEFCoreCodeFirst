using AutoMapper;
using BooksShop.BLL.DTO.Product;
using BooksShop.BLL.Interfaces;
using BooksShop.DAL.Entities;
using BooksShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.BLL.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _unit;
        private IMapper _mapper;

        public ProductService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }

        public async Task Delete(int id)
        {
            Product product = await _unit.productRepository.GetByIdAsync(id);
            _unit.productRepository.Delete(product);
        }

        public async Task<ProductDetailDTO> GetProductDetails(int id)
        {
            Product products = await _unit.productRepository.GetByIdWithDetailsAsync(id);
            return _mapper.Map<ProductDetailDTO>(products);
        }

        public async Task<IEnumerable<ProductShortDetailDTO>> GetShortDetail()
        {
            IEnumerable<Product> products = await _unit.productRepository.GetAllWithDetailsAsync();
            return _mapper.Map<IEnumerable<ProductShortDetailDTO>>(products);
        }

        public ProductDTO Post(ProductDTOForCreating productsDto)
        {
            var product = _mapper.Map<Product>(productsDto);
            _unit.productRepository.Add(product);
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task Put(int id, ProductDTOForCreating productsDto)
        {
            Product ToUpdate = await _unit.productRepository.GetByIdAsync(id);
            _mapper.Map(productsDto, ToUpdate);
            _unit.productRepository.Update(ToUpdate);
        }
    }
}
