using BooksShop.BLL.DTO.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.BLL.Interfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductShortDetailDTO>> GetShortDetail();
        public Task <ProductDetailDTO> GetProductDetails(int id);
        public ProductDTO Post(ProductDTOForCreating productsDto);
        public Task Put(int id, ProductDTOForCreating productsDto);
        public Task Delete(int id);
    }
}
