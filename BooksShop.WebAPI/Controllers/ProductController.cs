using BooksShop.BLL.DTO.Product;
using BooksShop.BLL.Interfaces;
using BooksShop.BLL.ServiceWrapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IServiceWrapper serviceWrapper;

        public ProductController(IServiceWrapper _serviceWrapper)
        {
            this.serviceWrapper = _serviceWrapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Result = await serviceWrapper.ProductService.GetShortDetail();
            return Ok(Result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Result = await serviceWrapper.ProductService.GetProductDetails(id);
            return Ok(Result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await serviceWrapper.ProductService.Delete(id);
                return NoContent();
            }
            catch (System.Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductDTOForCreating productDTOForCreating)
        {
            try
            {
                var productDtoPrint = serviceWrapper.ProductService.Post(productDTOForCreating);
                return CreatedAtRoute(
                      "Id",
                      new { Id = productDtoPrint.Id },
                      productDtoPrint);
            }
            catch (System.Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ProductDTOForCreating productDTOForCreating)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
                await serviceWrapper.ProductService.Put(id, productDTOForCreating);
                return NoContent();
            }
            catch (System.Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
