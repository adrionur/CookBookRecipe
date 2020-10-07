using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CookBookRecipe.DAL.Repositories;
using CookBookRecipe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CookBookRecipe.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository userRepository;
        public UserController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        [Route("User/GetUser")]
        [Route("User/GetUser/{id?}")]
        public IActionResult GetUser(int id)
        {
            var test = userRepository.Get(id);
            return null;
        }

        [HttpPost]
        public void AddUser([FromBody]User user)
        {
            if(ModelState.IsValid)
            {

            }
        }

        [HttpPut]
        public void UpdateUser()
        {

        }

        [HttpDelete]
        public void DeleteUser() {
        }
    }
}
