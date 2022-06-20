using AuthServer.Core.DTOS;
using AuthServer.Core.Models;
using AuthServer.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAuthServer.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : CustomBaseController
    {
        private readonly IServicesGeneric<Product, ProductDto> _productService;

        public ProductController(IServicesGeneric<Product,ProductDto> productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult>GetProducts()
        {
            return ActionResultInstance(await _productService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult>SaveProduct(ProductDto productDto)
        {
            return ActionResultInstance(await _productService.AddAsync(productDto));
        }

        [HttpPut]
        public async Task<IActionResult>UpdateProduct(ProductDto productDto)
        {
            return ActionResultInstance(await _productService.Update(productDto, productDto.ID));
        }

        //api/product/2
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return ActionResultInstance(await _productService.GetAllAsync());
        }
    }
}
