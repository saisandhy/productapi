using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_bussiness.Services;
using Product_Entity;
using Products_Data.Repository;
using System;
using System.Drawing;

namespace Webcoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
       private ArticleService _articleService;
        public ArticlesController(ArticleService articleService)
        {
            _articleService = articleService;
        }

        
        [HttpGet("GetArticles")]
        public Articles GetArticles(Guid Id)
        {
            return _articleService.GetArticles(Id);
        }


        [HttpPost("AddArticles")]
        public IActionResult AddArticles(Articles articles)
        {
            _articleService.AddArticles(articles);
            return Ok("products added successfully!!");

        }
    }
}
