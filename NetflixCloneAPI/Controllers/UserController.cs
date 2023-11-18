using Microsoft.AspNetCore.Mvc;

namespace NetflixCloneAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : Controller
    {
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
