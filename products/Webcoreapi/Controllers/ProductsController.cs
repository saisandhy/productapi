using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_bussiness.Services;
using Product_Entity;
using System;
using System.Collections.Generic;

namespace Webcoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    { 
        private ProductService _productService;
        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }
        [HttpGet ("GetProducts")]
        public Products GetProducts(Guid Id)
        {
            return _productService.GetProducts(Id);
        }

        [HttpPost("AddProducts")]
        public IActionResult AddProductsI([FromBody] Products products)
        {
            _productService.AddProductsI(products);
            return Ok("products added successfully!!");
        }
    }
}
