using Microsoft.EntityFrameworkCore;
using SocialNet.Domain.Models;
using SocialNet.Repository.Contexts;
using SocialNet.Repository.IRepository;

namespace SocialNet.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext context;
        string errorMessage = string.Empty;
        public PostRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Post> GetUserPosts(string Id)
        {
            return await context.Posts.SingleOrDefaultAsync(s =>s.UserId == Id);
        }
        public IEnumerable<Post> GetAllUsersPosts()
        {
            return (IEnumerable<Post>)context.Posts.AsAsyncEnumerable();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
