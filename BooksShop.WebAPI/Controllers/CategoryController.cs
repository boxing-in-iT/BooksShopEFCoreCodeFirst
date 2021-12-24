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
    public class CategoryController : ControllerBase
    {
        private readonly IServiceWrapper serviceWrapper;

        public CategoryController(IServiceWrapper _servicewrapper)
        {
            this.serviceWrapper = _servicewrapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Result = await serviceWrapper.CategoryService.GetCategoryList();
            return Ok(Result);
        }

    }
}
