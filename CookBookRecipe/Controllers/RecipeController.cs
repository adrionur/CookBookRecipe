using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CookBookRecipe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public void GetAllRecipes()
        {

        }

        [HttpGet]
        public void GetRecipe(int id)
        {

        }

        [HttpPost]
        public void AddRecipe()
        {

        }

        [HttpPut]
        public void UpdateRecipe()
        {

        }

        [HttpDelete]
        public void DeleteRecipe(int recipeId)
        {

        }
    }
}
