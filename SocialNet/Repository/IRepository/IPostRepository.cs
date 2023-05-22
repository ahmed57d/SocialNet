using SocialNet.Domain.Models;

namespace SocialNet.Repository.IRepository
{
    public interface IPostRepository
    {
        Task<Post> GetUserPosts(string Id);
        IEnumerable<Post> GetAllUsersPosts();
        void SaveChanges();
    }
}
