using CodeToGetherChallengeJanFeb.EntityFramework.EntityFramework;
using CodeToGetherChallengeJanFeb.EntityFramework.Models;
using CodeToGetherChallengeJanFeb.EntityFramework.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeToGetherChallengeJanFeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : IGeneralApiController<Recipe>
    {
        private readonly GenericDataService<Recipe> recipeService;
        public RecipesController(RecipeContext context)
        {
            recipeService = new GenericDataService<Recipe>(context);
        }

        [HttpGet]
        [Route("get/{id}")] //recipes/get/{id}
        public async Task<Recipe> Get(int id)
        {
            return await recipeService.Get(id);
        }

        [HttpGet]
        [Route("getall")]//recipes/getall
        public async Task<IEnumerable<Recipe>> GetAll()
        {
            return await recipeService.GetAll();
        }
    }
}
