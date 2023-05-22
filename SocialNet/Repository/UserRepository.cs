using Microsoft.EntityFrameworkCore;
using SocialNet.Domain.Models;
using SocialNet.Repository.Contexts;
using SocialNet.Repository.IRepository;

namespace SocialNet.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;
        string errorMessage = string.Empty;
        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<User> GetUser(string Id)
        {
            return await context.Users.SingleOrDefaultAsync(s => s.Id == Id)?? new User();
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }

        public void InsertUser(User user)
        {
            if (user.Id == null)
            {
                user.Id = Guid.NewGuid().ToString(); 
            }
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            context.Users?.Update(user);
            context.SaveChanges();
        }

        public void DeleteUser(string id)
        {
            var user = context.Users.Find(id); 
            if (user != null)
            {
                context.Users.Remove(user); 
                context.SaveChanges(); 
            }
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
