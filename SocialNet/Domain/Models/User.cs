using Microsoft.AspNetCore.Identity;

namespace SocialNet.Domain.Models
{
    public class User : IdentityUser<string>
    {
        int Id;
        public string Username { get; set; }
        
        string Password;
        string Email;
        int RoleId;
        int IsActive;
        public IList<Post> Posts { get; set; } = new List<Post>();

    }
}
