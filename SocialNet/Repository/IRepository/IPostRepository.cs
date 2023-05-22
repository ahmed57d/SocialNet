using SocialNet.Domain.Models;

namespace SocialNet.Repository.IRepository
{
    public interface IPostRepository
    {
        Task<Post> GetUserPosts(string Id);
        IEnumerable<Post> GetAllUsersPosts();
        void AddPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(Post post);
        void SaveChanges();
    }
}
