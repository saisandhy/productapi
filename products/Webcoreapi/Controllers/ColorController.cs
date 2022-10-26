using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_bussiness.Services;
using Product_Entity;
using System;

namespace Webcoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private Colorservice _colorservice;
        public ColorController(Colorservice colorservice)
        {
            _colorservice = colorservice;
        }

        [HttpGet(" GetColor")]
        public ColorP GetColor(Guid Id)
        {
            return _colorservice.GetColor(Id);
        }

        [HttpPost("AddColor")]
        public IActionResult AddColor(ColorP color)
        {
            _colorservice.AddColor( color);
            return Ok("products added successfully!!");
        }
    }
}
