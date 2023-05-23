using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNet.Domain.Models;
using System.Reflection.Emit;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SocialNet.Repository.Contexts
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
        }
        public DbSet<User>? Users { get; set; }
        public DbSet<Post>? Posts { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Comment>? Comments { get; set; }
    }
}
