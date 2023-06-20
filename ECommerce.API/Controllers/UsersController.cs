using ECommerce.API.Repositories;
using ECommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UsersController(IUserRepository repository) {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var userList = _repository.Get();

            return Ok(userList);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _repository.Get(id);
            
            if (user == null) return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Add([FromBody]User user)
        {
            _repository.Add(user);

            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody]User user, int id)
        {
            _repository.Update(user);

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            
            return Ok();
        }
    }
}
