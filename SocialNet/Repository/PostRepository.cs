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

        public async Task<Post> GetUserPosts(string userId)
        {
            return await context.Posts
                .Include(p => p.Comments) 
                .SingleOrDefaultAsync(p => p.UserId == userId);
        }
        public IEnumerable<Post> GetAllUsersPosts()
        {
            return context.Posts
                .Include(p => p.Comments) 
                .ToList();
        }


        public void AddPost(Post post)
        {
            
            context.Posts?.Add(post);
            context.SaveChanges();
        }

        public void UpdatePost(Post post)
        {
            context.Posts?.Update(post);
            context.SaveChanges();
        }

        public void DeletePost(Post post)
        {
            context.Posts?.Remove(post);
            context.SaveChanges();
        }  

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
