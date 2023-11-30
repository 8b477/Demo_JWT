using DemoSecurity_BLL.Interface;
using DemoSecurity_DAL.Entities;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TFCyberSecu_DemoSecurity_API.Models;



namespace TFCyberSecu_DemoSecurity_API.Controllers
{
    [Route("api/[controller]")]
    [Authorize("adminPolicy")]
    [ApiController]
    public class ArticleController : ControllerBase
    {

        #region DI <----
        private readonly IArticleBLLService _articleService;

        public ArticleController(IArticleBLLService articleService)
        {
            _articleService = articleService;

        } 
        #endregion


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_articleService.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
{
            return Ok(_articleService.GetById(id));
        }


        [HttpPost]
        public IActionResult Post([FromBody] AddArticle article)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                Article mapperArticle = new() 
                {
                    Nom = article.Nom,
                    Prix = article.Prix,
                    Categorie = article.Categorie,
                    Description = article.Description
                };

                return Ok(_articleService.Create(mapperArticle));
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_articleService.Delete(id))
                return NoContent();

            return BadRequest();
        }
    }
}
