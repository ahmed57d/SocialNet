﻿using Microsoft.AspNetCore.Identity;

namespace SocialNet.Domain.Models
{
    public class User : IdentityUser<string>
    {
        public int RoleId { get; set; }
        public int IsActive { get; set; }
        public IList<Post> Posts { get; set; } = new List<Post>();

    }
}
