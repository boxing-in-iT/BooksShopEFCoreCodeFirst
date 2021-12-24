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
    public class BindingController : ControllerBase
    {
        public IServiceWrapper serviceWrapper;

        public BindingController(IServiceWrapper _serviceWrapper)
        {
            this.serviceWrapper = _serviceWrapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Result = await serviceWrapper.BindingService.Get();
            return Ok(Result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Result = await serviceWrapper.BindingService.GetById(id);
            return Ok(Result);
        }

    }
}
