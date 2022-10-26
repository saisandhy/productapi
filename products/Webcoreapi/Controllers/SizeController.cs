using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_bussiness.Services;
using Product_Entity;
using System;

namespace Webcoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        private Sizeservice _sizeservice;
        public SizeController(Sizeservice sizeservice)
        {
            _sizeservice = sizeservice;
        }
        [HttpGet("GetSize")]
        public PSize GetSize(Guid Id)
        {
            return _sizeservice.GetSize(Id);
        }


        [HttpPost("AddSize")]
        public IActionResult AddSize(PSize pSize)
        {
            _sizeservice.AddSize(pSize);
            return Ok("products added successfully!!");

        }
    }
}
