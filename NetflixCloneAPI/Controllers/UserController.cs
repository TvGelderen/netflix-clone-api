using Microsoft.AspNetCore.Mvc;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.DTO;

namespace NetflixCloneAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet("{id:guid}")]
        public IActionResult GetUser(Guid id)
        {
            return Ok(id);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateUser(Guid id)
        {
            return Ok(id);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteUser(Guid id)
        {
            return Ok(id);
        }
    }
}
