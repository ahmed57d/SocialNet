using Microsoft.AspNetCore.Mvc;
using SocialNet.Domain.Models;
using SocialNet.Service.IService;
using System.Threading.Tasks;

namespace SocialNet.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await userService.GetUsers();
            return Ok(users);
        }

        [HttpGet("{Id}", Name = "UserId")]
        public async Task<IActionResult> GetUser(string Id)
        {
            var user = await userService.GetUser(Id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public IActionResult InsertUser( User user)
        {
            userService.InsertUser(user);
            return CreatedAtRoute("UserId", new { Id = user.Id }, user);
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateUser(string Id, [FromBody] User user)
        {
            if (Id != user.Id)
                return BadRequest();

            userService.UpdateUser(user);
            return NoContent();
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteUser(string Id)
        {
            userService.DeleteUser(Id);
            return NoContent();
        }
    }
}
