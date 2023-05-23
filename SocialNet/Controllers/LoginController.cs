using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SocialNet.Domain.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace SocialNet.Controllers
{
    [ApiController]
    [Route("api/Login")]
    public class LoginController : ControllerBase
    {
        private IConfiguration configuration;
        public LoginController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        private User AuthenticateUser(User user)
        {
            User _user = null;
            if (user.UserName == "admin" && user.Password == "admin")
                _user = new User { UserName = "ahmed57d" };
            return _user;
        }
        private string GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:key"]));
            var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(configuration["Jwt:key"], configuration["Jwt:Audience"], null, expires: DateTime.Now.AddMinutes(1), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(User user)
        {
            IActionResult response = Unauthorized();
            var user_ = AuthenticateUser(user);
            if (user_ != null)
            {
                var token = GenerateToken(user_);
                response = Ok(new { token = token });
            }
            return response;
        }
    }
}
