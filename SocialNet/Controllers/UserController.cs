using Microsoft.AspNetCore.Mvc;
using SocialNet.Domain.Models;
using SocialNet.Service.IService;

namespace SocialNet.Controllers
{
    public class UserController : Controller
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
        [HttpGet("{Id:string}", Name = "Id")]
        public async Task<IActionResult> GetUser(string Id)
        {
            var user = await userService.GetUser(Id);
            return Ok(user);
        }
        [HttpPost]
        void InsertUser(User user)
        {
            userService.InsertUser(user);
        }
        [HttpPut]
        void UpdateUser(User user)
        {
            userService.UpdateUser(user);
        }
        [HttpDelete]
        void DeleteUser(string Id)
        {
            userService.DeleteUser(Id);
        }
    }
}
