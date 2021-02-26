using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace MediatorPatternSample.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] Guid? categoryId)
        {
            var data = await _mediator.Send(new Contracts.Queries.GetProducts
            {
                CategoryId = categoryId,
            });

            return Ok(data);
        }

        [HttpGet("categories")]
        public async Task<IActionResult> GetCategories()
        {
            var data = await _mediator.Send(new Contracts.Queries.GetCategories());
            return Ok(data);
        }
    }
}
